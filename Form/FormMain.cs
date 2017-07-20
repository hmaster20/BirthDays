using Days.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace Days
{
    public partial class FormMain : Form
    {
       

        public FormMain()
        {
            this.InitializeComponent();
            this.dgvContacts.AutoGenerateColumns = false;
            this.dgvFutureEvents.AutoGenerateColumns = false;
            this.dgvPastEvents.AutoGenerateColumns = false;
            this.tsslContactCount.Alignment = ToolStripItemAlignment.Right;
            this.bgwLoader = new BackgroundWorker();
            this.bgwLoader.DoWork += new DoWorkEventHandler(this.bgwLoader_DoWork);
            this.bgwLoader.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwLoader_RunWorkerCompleted);
        }

        private void tMain_Tick(object sender, EventArgs e)
        {
            if (this.tMain.Interval < 86400000)
                this.tMain.Interval = 86400000;
            if (this.niMain.Visible)
            {
                List<DateEvent> todayEvents = this.dateEvents.GetTodayEvents();
                if (todayEvents.Count > 0)
                {
                    this.niMain.BalloonTipText = "";
                    foreach (DateEvent dateEvent in todayEvents)
                    {
                        NotifyIcon niMain = this.niMain;
                        niMain.BalloonTipText = niMain.BalloonTipText + dateEvent.Contact.Fio + ": " + dateEvent.Info + "\r\n";
                    }
                    this.niMain.ShowBalloonTip(10000);
                }
            }
            DateTime dateTime = this.settings.LastRecalcDate;
            dateTime = dateTime.AddDays((double)this.settings.RecountDaysQuantity);
            DateTime date1 = dateTime.Date;
            dateTime = DateTime.Now;
            DateTime date2 = dateTime.Date;
            if (!(date1 >= date2))
                return;
            this.tsmiRecalc_Click(sender, e);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.formMaximized = this.WindowState == FormWindowState.Maximized;
            this.bgwLoader.RunWorkerAsync();
        }

        private void bgwLoader_DoWork(object sender, DoWorkEventArgs e)
        {
            this.timeMeasures = TimeMeasureCollection.Generate();
            this.contacts = ContactCollection.Load();
            this.dateEvents = DateEventCollection.Load(this.timeMeasures, this.contacts);
            this.settings = Settings.Load();
        }

        private void bgwLoader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.tsmiRecalc_Click(sender, EventArgs.Empty);
            for (int index = 0; index < this.tscbContactSort.Items.Count; ++index)
            {
                if (this.tscbContactSort.Items[index].ToString() == this.settings.ContactSort)
                    this.tscbContactSort.SelectedItem = this.tscbContactSort.Items[index];
            }
            this.tMain.Interval = (int)(DateTime.Now.AddDays(1.0).Date - DateTime.Now).TotalMilliseconds;
            this.tMain.Enabled = true;
        }

        private void AddContact()
        {
            FormAddContact formAddContact = new FormAddContact();
            if (formAddContact.ShowDialog() != DialogResult.OK)
                return;
            Contact editedContact = formAddContact.EditedContact;
            this.contacts.Add(editedContact, this.settings.ContactSort);
            this.contacts.Save();
            this.dateEvents.Add(editedContact, this.timeMeasures, this.settings);
            this.dateEvents.Save();
            this.RefreshTables();
            foreach (DataGridViewRow row in (IEnumerable)this.dgvContacts.Rows)
            {
                if ((row.DataBoundItem as Contact).Id == editedContact.Id)
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void EditContact()
        {
            if (this.dgvContacts.SelectedRows.Count <= 0)
                return;
            FormAddContact formAddContact = new FormAddContact(this.dgvContacts.SelectedRows[0].DataBoundItem as Contact);
            if (formAddContact.ShowDialog() != DialogResult.OK)
                return;
            this.contacts.Save();
            if (formAddContact.Recalc)
            {
                this.dateEvents.Remove(formAddContact.EditedContact);
                this.dateEvents.Add(formAddContact.EditedContact, this.timeMeasures, this.settings);
                this.dateEvents.Save();
            }
            this.RefreshTables();
        }

        private void RemoveContact()
        {
            if (this.dgvContacts.SelectedRows.Count <= 0)
                return;
            Contact dataBoundItem = this.dgvContacts.SelectedRows[0].DataBoundItem as Contact;
            if (MessageBox.Show("Вы уверены что хотите удалить контакт " + dataBoundItem.Fio, "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            this.contacts.Remove(dataBoundItem);
            this.contacts.Save();
            this.dateEvents.Remove(dataBoundItem);
            this.dateEvents.Save();
            this.RefreshTables();
        }

        private void OpenCalculations()
        {
            if (this.dgvContacts.SelectedRows.Count <= 0)
                return;
            Contact dataBoundItem = this.dgvContacts.SelectedRows[0].DataBoundItem as Contact;
            new FormCalculations(dataBoundItem.Fio, dataBoundItem.BirthDate, this.settings).Show();
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tcMain.SelectedTab != this.tpContacts)
                return;
            foreach (Control control in (ArrangedElementCollection)this.tcEvents.SelectedTab.Controls)
            {
                if (control is DataGridView)
                {
                    DataGridView dataGridView = control as DataGridView;
                    if (dataGridView.SelectedRows.Count <= 0)
                        break;
                    this.SelectContact((dataGridView.SelectedRows[0].DataBoundItem as DateEvent).Contact);
                }
            }
        }

        private void RefreshTables()
        {
            this.bsContacts.DataSource = this.tsmiEnableFilter.Checked ? (object)this.contacts.Contacts.FindAll((Predicate<Contact>)(c => c.Fio.ToLower().Contains(this.tstbFilter.Text.ToLower()))) : (object)new List<Contact>((IEnumerable<Contact>)this.contacts.Contacts);
            this.bsContacts.ResetBindings(false);
            this.dgvFutureEvents.DataSource = (object)this.dateEvents.GetFutureEvents();
            this.dgvPastEvents.DataSource = (object)this.dateEvents.GetPastEvents();
            this.RefreshCurrentContactInfo();
        }

        private void dgvContacts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.OpenCalculations();
        }

        private void dgvContacts_SelectionChanged(object sender, EventArgs e)
        {
            this.RefreshCurrentContactInfo();
        }

        private void dgvContacts_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    this.RemoveContact();
                    break;
                case Keys.F2:
                    this.EditContact();
                    break;
                case Keys.Return:
                    this.OpenCalculations();
                    break;
                case Keys.Insert:
                    this.AddContact();
                    break;
            }
        }

        private void dgvFutureEvents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            this.OpenDateEventInfo(this.dgvFutureEvents.Rows[e.RowIndex].DataBoundItem as DateEvent);
        }

        private void dgvPastEvents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            this.OpenDateEventInfo(this.dgvPastEvents.Rows[e.RowIndex].DataBoundItem as DateEvent);
        }

        private void OpenDateEventInfo(DateEvent dateEvent)
        {
            int num = (int)new FormEventInfo(dateEvent).ShowDialog();
        }

        private void RefreshCurrentContactInfo()
        {
            if (this.dgvContacts.SelectedRows.Count > 0)
            {
                this.tsslContactCount.Text = (this.dgvContacts.Rows.IndexOf(this.dgvContacts.SelectedRows[0]) + 1).ToString() + " / " + (object)this.contacts.Contacts.Count;
                string str1 = "Контакт прожил полных";
                DateTime birthDate = (this.dgvContacts.SelectedRows[0].DataBoundItem as Contact).BirthDate;
                TimeSpan timeSpan = DateTime.Now - birthDate;
                DateTime dateTime = birthDate;
                int num1 = 0;
                int num2 = 0;
                while (dateTime < DateTime.Now.AddMonths(-1))
                {
                    dateTime = dateTime.AddMonths(1);
                    ++num1;
                    if (num1 % 12 == 0)
                        ++num2;
                }
                string str2 = str1 + " лет: " + (object)num2 + ", месяцев: " + num1.ToString("N0");
                double num3 = Math.Floor(timeSpan.TotalDays);
                string str3 = str2 + ", недель: " + Math.Floor(num3 / 7.0).ToString("N0") + ", дней: " + num3.ToString("N0");
                string str4 = ", часов: ";
                double num4 = Math.Floor(timeSpan.TotalHours);
                string str5 = num4.ToString("N0");
                string str6 = str3 + str4 + str5;
                string str7 = ", минут: ";
                num4 = Math.Floor(timeSpan.TotalMinutes);
                string str8 = num4.ToString("N0");
                string str9 = str6 + str7 + str8;
                string str10 = ", секунд: ";
                num4 = Math.Floor(timeSpan.TotalSeconds);
                string str11 = num4.ToString("N0");
                this.tsslContactLifeTime.Text = str9 + str10 + str11;
            }
            else
            {
                this.tsslContactLifeTime.Text = "";
                this.tsslContactCount.Text = "";
            }
        }

        private void SelectContact(Contact contact)
        {
            foreach (DataGridViewRow row in (IEnumerable)this.dgvContacts.Rows)
            {
                if (row.DataBoundItem as Contact == contact)
                {
                    this.dgvContacts.Rows[row.Index].Selected = true;
                    this.dgvContacts.FirstDisplayedScrollingRowIndex = row.Index;
                }
            }
        }

        private void tsmiSettings_Click(object sender, EventArgs e)
        {
            if (new FormSettings(this.settings).ShowDialog() != DialogResult.OK)
                return;
            this.settings.Save();
        }

        private void tsmiRecalc_Click(object sender, EventArgs e)
        {
            this.dateEvents.Recalc(this.contacts, this.timeMeasures, this.settings);
            this.dateEvents.Save();
            this.RefreshTables();
            this.settings.LastRecalcDate = DateTime.Now;
            this.settings.Save();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            int num = (int)new FormAbout("1.1.3").ShowDialog();
        }

        private void tsmiAddContact_Click(object sender, EventArgs e)
        {
            this.AddContact();
        }

        private void tsmiEditContact_Click(object sender, EventArgs e)
        {
            this.EditContact();
        }

        private void tsmiRemoveContact_Click(object sender, EventArgs e)
        {
            this.RemoveContact();
        }

        private void tsmiCalculations_Click(object sender, EventArgs e)
        {
            this.OpenCalculations();
        }

        private void tsmiChangeHour_Click(object sender, EventArgs e)
        {
            FormChangeHour formChangeHour = new FormChangeHour();
            if (formChangeHour.ShowDialog() != DialogResult.OK)
                return;
            this.contacts.ShiftTime(formChangeHour.Forward, formChangeHour.TimeShift);
            this.contacts.Save();
            this.RefreshTables();
        }

        private void tscbContactSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contact contact = (Contact)null;
            if (this.dgvContacts.SelectedRows.Count > 0)
                contact = this.dgvContacts.SelectedRows[0].DataBoundItem as Contact;
            this.contacts.Sort(this.tscbContactSort.SelectedItem.ToString());
            this.RefreshTables();
            this.settings.ContactSort = this.tscbContactSort.SelectedItem.ToString();
            this.settings.Save();
            if (this.settings.ContactSort == "По датам")
            {
                for (int index1 = 0; index1 < this.dgvContacts.Rows.Count; ++index1)
                {
                    Contact dataBoundItem = this.dgvContacts.Rows[index1].DataBoundItem as Contact;
                    DateTime dateTime = DateTime.Now;
                    int year = dateTime.Year;
                    dateTime = dataBoundItem.BirthDate;
                    int month = dateTime.Month;
                    dateTime = dataBoundItem.BirthDate;
                    int day = dateTime.Day;
                    if (new DateTime(year, month, day) >= DateTime.Now)
                    {
                        int index2 = index1 > 0 ? index1 - 1 : index1;
                        this.dgvContacts.Rows[index2].Selected = true;
                        this.dgvContacts.FirstDisplayedScrollingRowIndex = index2;
                        return;
                    }
                }
                this.dgvContacts.Rows[this.dgvContacts.Rows.Count - 1].Selected = true;
            }
            else
            {
                if (contact == null)
                    return;
                this.SelectContact(contact);
            }
        }

        private void tsmiEnableFilter_CheckedChanged(object sender, EventArgs e)
        {
            this.tstbFilter.Visible = this.tsmiEnableFilter.Checked;
            this.RefreshTables();
        }

        private void tstbFilter_TextChanged(object sender, EventArgs e)
        {
            this.RefreshTables();
            this.tscbContactSort_SelectedIndexChanged(sender, e);
        }

        private void ShowForm()
        {
            this.WindowState = this.formMaximized ? FormWindowState.Maximized : FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.niMain.Visible = false;
        }

        private void HideForm()
        {
            this.ShowInTaskbar = false;
            this.niMain.Visible = true;
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.HideForm();
            else
                this.formMaximized = this.WindowState == FormWindowState.Maximized;
        }

        private void niMain_DoubleClick(object sender, EventArgs e)
        {
            this.ShowForm();
        }

        private void tsmiShow_Click(object sender, EventArgs e)
        {
            this.ShowForm();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void niMain_BalloonTipClicked(object sender, EventArgs e)
        {
            this.ShowForm();
        }

  
    }
}
