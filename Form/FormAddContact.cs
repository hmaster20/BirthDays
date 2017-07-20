using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Days
{
    public partial class FormAddContact : Form
    {
        public FormAddContact()
        {
            this.InitializeComponent();
            this.dtpBirth.Value = DateTime.Now;
        }

        public FormAddContact(Contact contact)
        {
            this.InitializeComponent();
            this.EditedContact = contact;
            this.tbFio.Text = contact.Fio;
            this.dtpBirth.Value = contact.BirthDate;
            this.tbInfo.Text = contact.Info;
            this.Text = "Редактируем контакт";
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DateTime date = this.GetDate();
            if (this.EditedContact != null)
            {
                if (date != this.EditedContact.BirthDate && MessageBox.Show("Перерасчитать события?", "Новая дата", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    this.Recalc = true;
                this.EditedContact.Fio = this.tbFio.Text;
                this.EditedContact.Info = this.tbInfo.Text;
                this.EditedContact.BirthDate = date;
            }
            else
                this.EditedContact = new Contact(this.tbFio.Text, date, this.tbInfo.Text);
            this.DialogResult = DialogResult.OK;
        }

        private DateTime GetDate()
        {
            DateTime dateTime = this.dtpBirth.Value;
            int year = dateTime.Year;
            dateTime = this.dtpBirth.Value;
            int month = dateTime.Month;
            dateTime = this.dtpBirth.Value;
            int day = dateTime.Day;
            dateTime = this.dtpBirth.Value;
            int hour = dateTime.Hour;
            dateTime = this.dtpBirth.Value;
            int minute = dateTime.Minute;
            int second = 0;
            return new DateTime(year, month, day, hour, minute, second);
        }

        private void dtpBirth_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan timeSpan = DateTime.Now - this.dtpBirth.Value;
            Label lSeconds = this.lSeconds;
            double num1 = Math.Floor(timeSpan.TotalSeconds);
            string str1 = num1.ToString("N0") ?? "";
            lSeconds.Text = str1;
            Label lMinutes = this.lMinutes;
            num1 = Math.Floor(timeSpan.TotalMinutes);
            string str2 = num1.ToString("N0") ?? "";
            lMinutes.Text = str2;
            Label lHours = this.lHours;
            num1 = Math.Floor(timeSpan.TotalHours);
            string str3 = num1.ToString("N0") ?? "";
            lHours.Text = str3;
            double num2 = Math.Floor(timeSpan.TotalDays);
            this.lDays.Text = num2.ToString("N0") ?? "";
            Label lWeeks = this.lWeeks;
            num1 = Math.Floor(num2 / 7.0);
            string str4 = num1.ToString("N0") ?? "";
            lWeeks.Text = str4;
            int num3 = 0;
            int num4 = 0;
            DateTime dateTime = this.dtpBirth.Value;
            while (dateTime < DateTime.Now.AddMonths(-1))
            {
                dateTime = dateTime.AddMonths(1);
                ++num3;
                if (num3 % 12 == 0)
                    ++num4;
            }
            this.lMonthes.Text = num3.ToString("N0") ?? "";
            this.lYears.Text = string.Concat((object)num4);
        }
        
    }
}
