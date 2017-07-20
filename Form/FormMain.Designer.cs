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
   partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormMain));
            this.tcEvents = new TabControl();
            this.tpFuture = new TabPage();
            this.dgvFutureEvents = new DataGridView();
            this.colFutureEventsDate = new DataGridViewTextBoxColumn();
            this.colFutureEventsContact = new DataGridViewTextBoxColumn();
            this.colFutureEventsInfo = new DataGridViewTextBoxColumn();
            this.tpPast = new TabPage();
            this.dgvPastEvents = new DataGridView();
            this.colPastEventsDate = new DataGridViewTextBoxColumn();
            this.colPastEventsContact = new DataGridViewTextBoxColumn();
            this.colPastEventsInfo = new DataGridViewTextBoxColumn();
            this.msContact = new MenuStrip();
            this.контактToolStripMenuItem = new ToolStripMenuItem();
            this.tsmiAddContact = new ToolStripMenuItem();
            this.tsmiEditContact = new ToolStripMenuItem();
            this.tsmiRemoveContact = new ToolStripMenuItem();
            this.tsmiCalculations = new ToolStripMenuItem();
            this.tsmiChangeHour = new ToolStripMenuItem();
            this.tscbContactSort = new ToolStripComboBox();
            this.tstbFilter = new ToolStripTextBox();
            this.tsmiEnableFilter = new ToolStripMenuItem();
            this.tcMain = new TabControl();
            this.tpEvents = new TabPage();
            this.tpContacts = new TabPage();
            this.dgvContacts = new DataGridView();
            this.colFio = new DataGridViewTextBoxColumn();
            this.colBirthDate = new DataGridViewTextBoxColumn();
            this.colContactInfo = new DataGridViewTextBoxColumn();
            this.bsContacts = new BindingSource(this.components);
            this.ssContactLifeTime = new StatusStrip();
            this.tsslContactLifeTime = new ToolStripStatusLabel();
            this.tsslMiddle = new ToolStripStatusLabel();
            this.tsslContactCount = new ToolStripStatusLabel();
            this.msMain = new MenuStrip();
            this.tsmiSettings = new ToolStripMenuItem();
            this.tsmiRecalc = new ToolStripMenuItem();
            this.tsmiAbout = new ToolStripMenuItem();
            this.niMain = new NotifyIcon(this.components);
            this.cmsTray = new ContextMenuStrip(this.components);
            this.tsmiShow = new ToolStripMenuItem();
            this.tsmiExit = new ToolStripMenuItem();
            this.tMain = new Timer(this.components);
            this.tcEvents.SuspendLayout();
            this.tpFuture.SuspendLayout();
            ((ISupportInitialize)this.dgvFutureEvents).BeginInit();
            this.tpPast.SuspendLayout();
            ((ISupportInitialize)this.dgvPastEvents).BeginInit();
            this.msContact.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpEvents.SuspendLayout();
            this.tpContacts.SuspendLayout();
            ((ISupportInitialize)this.dgvContacts).BeginInit();
            ((ISupportInitialize)this.bsContacts).BeginInit();
            this.ssContactLifeTime.SuspendLayout();
            this.msMain.SuspendLayout();
            this.cmsTray.SuspendLayout();
            this.SuspendLayout();
            this.tcEvents.Controls.Add((Control)this.tpFuture);
            this.tcEvents.Controls.Add((Control)this.tpPast);
            this.tcEvents.Dock = DockStyle.Fill;
            this.tcEvents.Location = new Point(3, 3);
            this.tcEvents.Name = "tcEvents";
            this.tcEvents.SelectedIndex = 0;
            this.tcEvents.Size = new Size(961, 556);
            this.tcEvents.TabIndex = 0;
            this.tpFuture.Controls.Add((Control)this.dgvFutureEvents);
            this.tpFuture.Location = new Point(4, 22);
            this.tpFuture.Name = "tpFuture";
            this.tpFuture.Padding = new Padding(3);
            this.tpFuture.Size = new Size(953, 530);
            this.tpFuture.TabIndex = 0;
            this.tpFuture.Text = "Будущие";
            this.tpFuture.UseVisualStyleBackColor = true;
            this.dgvFutureEvents.AllowUserToAddRows = false;
            this.dgvFutureEvents.AllowUserToDeleteRows = false;
            this.dgvFutureEvents.AllowUserToResizeRows = false;
            this.dgvFutureEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFutureEvents.Columns.AddRange((DataGridViewColumn)this.colFutureEventsDate, (DataGridViewColumn)this.colFutureEventsContact, (DataGridViewColumn)this.colFutureEventsInfo);
            this.dgvFutureEvents.Dock = DockStyle.Fill;
            this.dgvFutureEvents.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dgvFutureEvents.Location = new Point(3, 3);
            this.dgvFutureEvents.Name = "dgvFutureEvents";
            this.dgvFutureEvents.ReadOnly = true;
            this.dgvFutureEvents.RowHeadersVisible = false;
            this.dgvFutureEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvFutureEvents.ShowEditingIcon = false;
            this.dgvFutureEvents.Size = new Size(947, 524);
            this.dgvFutureEvents.TabIndex = 0;
            this.dgvFutureEvents.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvFutureEvents_CellDoubleClick);
            this.colFutureEventsDate.DataPropertyName = "DateString";
            this.colFutureEventsDate.HeaderText = "Дата";
            this.colFutureEventsDate.Name = "colFutureEventsDate";
            this.colFutureEventsDate.ReadOnly = true;
            this.colFutureEventsContact.DataPropertyName = "Contact";
            this.colFutureEventsContact.HeaderText = "Контакт";
            this.colFutureEventsContact.Name = "colFutureEventsContact";
            this.colFutureEventsContact.ReadOnly = true;
            this.colFutureEventsContact.Width = 300;
            this.colFutureEventsInfo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.colFutureEventsInfo.DataPropertyName = "Info";
            this.colFutureEventsInfo.HeaderText = "Инфо";
            this.colFutureEventsInfo.Name = "colFutureEventsInfo";
            this.colFutureEventsInfo.ReadOnly = true;
            this.tpPast.Controls.Add((Control)this.dgvPastEvents);
            this.tpPast.Location = new Point(4, 22);
            this.tpPast.Name = "tpPast";
            this.tpPast.Padding = new Padding(3);
            this.tpPast.Size = new Size(953, 530);
            this.tpPast.TabIndex = 1;
            this.tpPast.Text = "Прошлые";
            this.tpPast.UseVisualStyleBackColor = true;
            this.dgvPastEvents.AllowUserToAddRows = false;
            this.dgvPastEvents.AllowUserToDeleteRows = false;
            this.dgvPastEvents.AllowUserToResizeRows = false;
            this.dgvPastEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPastEvents.Columns.AddRange((DataGridViewColumn)this.colPastEventsDate, (DataGridViewColumn)this.colPastEventsContact, (DataGridViewColumn)this.colPastEventsInfo);
            this.dgvPastEvents.Dock = DockStyle.Fill;
            this.dgvPastEvents.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dgvPastEvents.Location = new Point(3, 3);
            this.dgvPastEvents.MultiSelect = false;
            this.dgvPastEvents.Name = "dgvPastEvents";
            this.dgvPastEvents.ReadOnly = true;
            this.dgvPastEvents.RowHeadersVisible = false;
            this.dgvPastEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvPastEvents.ShowEditingIcon = false;
            this.dgvPastEvents.Size = new Size(947, 524);
            this.dgvPastEvents.TabIndex = 1;
            this.dgvPastEvents.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvPastEvents_CellDoubleClick);
            this.colPastEventsDate.DataPropertyName = "DateString";
            this.colPastEventsDate.HeaderText = "Дата";
            this.colPastEventsDate.Name = "colPastEventsDate";
            this.colPastEventsDate.ReadOnly = true;
            this.colPastEventsContact.DataPropertyName = "Contact";
            this.colPastEventsContact.HeaderText = "Контакт";
            this.colPastEventsContact.Name = "colPastEventsContact";
            this.colPastEventsContact.ReadOnly = true;
            this.colPastEventsContact.Width = 300;
            this.colPastEventsInfo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.colPastEventsInfo.DataPropertyName = "Info";
            this.colPastEventsInfo.HeaderText = "Инфо";
            this.colPastEventsInfo.Name = "colPastEventsInfo";
            this.colPastEventsInfo.ReadOnly = true;
            this.msContact.Items.AddRange(new ToolStripItem[6]
            {
        (ToolStripItem) this.контактToolStripMenuItem,
        (ToolStripItem) this.tsmiCalculations,
        (ToolStripItem) this.tsmiChangeHour,
        (ToolStripItem) this.tscbContactSort,
        (ToolStripItem) this.tstbFilter,
        (ToolStripItem) this.tsmiEnableFilter
            });
            this.msContact.Location = new Point(3, 3);
            this.msContact.Name = "msContact";
            this.msContact.Size = new Size(961, 27);
            this.msContact.TabIndex = 1;
            this.msContact.Text = "menuStrip1";
            this.контактToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
            {
        (ToolStripItem) this.tsmiAddContact,
        (ToolStripItem) this.tsmiEditContact,
        (ToolStripItem) this.tsmiRemoveContact
            });
            this.контактToolStripMenuItem.Image = (Image)Resources.iconContact;
            this.контактToolStripMenuItem.Name = "контактToolStripMenuItem";
            this.контактToolStripMenuItem.Size = new Size(78, 23);
            this.контактToolStripMenuItem.Text = "Контакт";
            this.tsmiAddContact.Image = (Image)Resources.iconAdd;
            this.tsmiAddContact.Name = "tsmiAddContact";
            this.tsmiAddContact.Size = new Size(154, 22);
            this.tsmiAddContact.Text = "Добавить";
            this.tsmiAddContact.Click += new EventHandler(this.tsmiAddContact_Click);
            this.tsmiEditContact.Image = (Image)Resources.iconEdit;
            this.tsmiEditContact.Name = "tsmiEditContact";
            this.tsmiEditContact.Size = new Size(154, 22);
            this.tsmiEditContact.Text = "Редактировать";
            this.tsmiEditContact.Click += new EventHandler(this.tsmiEditContact_Click);
            this.tsmiRemoveContact.Image = (Image)Resources.iconDelete;
            this.tsmiRemoveContact.Name = "tsmiRemoveContact";
            this.tsmiRemoveContact.Size = new Size(154, 22);
            this.tsmiRemoveContact.Text = "Удалить";
            this.tsmiRemoveContact.Click += new EventHandler(this.tsmiRemoveContact_Click);
            this.tsmiCalculations.Image = (Image)Resources.iconCalculator;
            this.tsmiCalculations.Name = "tsmiCalculations";
            this.tsmiCalculations.Size = new Size(81, 23);
            this.tsmiCalculations.Text = "Расчеты";
            this.tsmiCalculations.Click += new EventHandler(this.tsmiCalculations_Click);
            this.tsmiChangeHour.Image = (Image)Resources.iconClock;
            this.tsmiChangeHour.Name = "tsmiChangeHour";
            this.tsmiChangeHour.Size = new Size(161, 23);
            this.tsmiChangeHour.Text = "Сменить часовой пояс";
            this.tsmiChangeHour.Click += new EventHandler(this.tsmiChangeHour_Click);
            this.tscbContactSort.Alignment = ToolStripItemAlignment.Right;
            this.tscbContactSort.DropDownStyle = ComboBoxStyle.DropDownList;
            this.tscbContactSort.Items.AddRange(new object[2]
            {
        (object) "По именам",
        (object) "По датам"
            });
            this.tscbContactSort.MaxDropDownItems = 2;
            this.tscbContactSort.Name = "tscbContactSort";
            this.tscbContactSort.Size = new Size(90, 23);
            this.tscbContactSort.ToolTipText = "Сортировка";
            this.tscbContactSort.SelectedIndexChanged += new EventHandler(this.tscbContactSort_SelectedIndexChanged);
            this.tstbFilter.Alignment = ToolStripItemAlignment.Right;
            this.tstbFilter.Name = "tstbFilter";
            this.tstbFilter.Size = new Size(100, 23);
            this.tstbFilter.Visible = false;
            this.tstbFilter.TextChanged += new EventHandler(this.tstbFilter_TextChanged);
            this.tsmiEnableFilter.Alignment = ToolStripItemAlignment.Right;
            this.tsmiEnableFilter.CheckOnClick = true;
            this.tsmiEnableFilter.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.tsmiEnableFilter.Image = (Image)Resources.iconFilter;
            this.tsmiEnableFilter.Name = "tsmiEnableFilter";
            this.tsmiEnableFilter.Size = new Size(28, 23);
            this.tsmiEnableFilter.Text = "Фильтр";
            this.tsmiEnableFilter.ToolTipText = "Фильтр";
            this.tsmiEnableFilter.CheckedChanged += new EventHandler(this.tsmiEnableFilter_CheckedChanged);
            this.tcMain.Controls.Add((Control)this.tpEvents);
            this.tcMain.Controls.Add((Control)this.tpContacts);
            this.tcMain.Dock = DockStyle.Fill;
            this.tcMain.Location = new Point(0, 24);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new Size(975, 588);
            this.tcMain.TabIndex = 2;
            this.tcMain.SelectedIndexChanged += new EventHandler(this.tcMain_SelectedIndexChanged);
            this.tpEvents.Controls.Add((Control)this.tcEvents);
            this.tpEvents.Location = new Point(4, 22);
            this.tpEvents.Name = "tpEvents";
            this.tpEvents.Padding = new Padding(3);
            this.tpEvents.Size = new Size(967, 562);
            this.tpEvents.TabIndex = 0;
            this.tpEvents.Text = "События";
            this.tpEvents.UseVisualStyleBackColor = true;
            this.tpContacts.Controls.Add((Control)this.dgvContacts);
            this.tpContacts.Controls.Add((Control)this.msContact);
            this.tpContacts.Controls.Add((Control)this.ssContactLifeTime);
            this.tpContacts.Location = new Point(4, 22);
            this.tpContacts.Name = "tpContacts";
            this.tpContacts.Padding = new Padding(3);
            this.tpContacts.Size = new Size(967, 562);
            this.tpContacts.TabIndex = 1;
            this.tpContacts.Text = "Контакты";
            this.tpContacts.UseVisualStyleBackColor = true;
            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.AllowUserToDeleteRows = false;
            this.dgvContacts.AllowUserToResizeRows = false;
            this.dgvContacts.AutoGenerateColumns = false;
            this.dgvContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Columns.AddRange((DataGridViewColumn)this.colFio, (DataGridViewColumn)this.colBirthDate, (DataGridViewColumn)this.colContactInfo);
            this.dgvContacts.DataSource = (object)this.bsContacts;
            this.dgvContacts.Dock = DockStyle.Fill;
            this.dgvContacts.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dgvContacts.Location = new Point(3, 30);
            this.dgvContacts.MultiSelect = false;
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.RowHeadersVisible = false;
            this.dgvContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvContacts.Size = new Size(961, 507);
            this.dgvContacts.TabIndex = 2;
            this.dgvContacts.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvContacts_CellDoubleClick);
            this.dgvContacts.SelectionChanged += new EventHandler(this.dgvContacts_SelectionChanged);
            this.dgvContacts.KeyDown += new KeyEventHandler(this.dgvContacts_KeyDown);
            this.colFio.DataPropertyName = "Fio";
            this.colFio.HeaderText = "ФИО";
            this.colFio.Name = "colFio";
            this.colFio.ReadOnly = true;
            this.colFio.Width = 300;
            this.colBirthDate.DataPropertyName = "BirthDateString";
            this.colBirthDate.HeaderText = "Дата рождения";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.ReadOnly = true;
            this.colContactInfo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.colContactInfo.DataPropertyName = "Info";
            this.colContactInfo.HeaderText = "Инфо";
            this.colContactInfo.Name = "colContactInfo";
            this.colContactInfo.ReadOnly = true;
            this.ssContactLifeTime.Items.AddRange(new ToolStripItem[3]
            {
        (ToolStripItem) this.tsslContactLifeTime,
        (ToolStripItem) this.tsslMiddle,
        (ToolStripItem) this.tsslContactCount
            });
            this.ssContactLifeTime.Location = new Point(3, 537);
            this.ssContactLifeTime.Name = "ssContactLifeTime";
            this.ssContactLifeTime.Size = new Size(961, 22);
            this.ssContactLifeTime.TabIndex = 3;
            this.tsslContactLifeTime.Name = "tsslContactLifeTime";
            this.tsslContactLifeTime.Size = new Size(0, 17);
            this.tsslMiddle.Name = "tsslMiddle";
            this.tsslMiddle.Size = new Size(946, 17);
            this.tsslMiddle.Spring = true;
            this.tsslContactCount.Name = "tsslContactCount";
            this.tsslContactCount.Size = new Size(0, 17);
            this.msMain.Items.AddRange(new ToolStripItem[3]
            {
        (ToolStripItem) this.tsmiSettings,
        (ToolStripItem) this.tsmiRecalc,
        (ToolStripItem) this.tsmiAbout
            });
            this.msMain.Location = new Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new Size(975, 24);
            this.msMain.TabIndex = 3;
            this.msMain.Text = "menuStrip2";
            this.tsmiSettings.Image = (Image)Resources.iconSettings;
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new Size(95, 20);
            this.tsmiSettings.Text = "Настройки";
            this.tsmiSettings.Click += new EventHandler(this.tsmiSettings_Click);
            this.tsmiRecalc.Image = (Image)Resources.iconRecalc;
            this.tsmiRecalc.Name = "tsmiRecalc";
            this.tsmiRecalc.Size = new Size(138, 20);
            this.tsmiRecalc.Text = "Пересчет событий";
            this.tsmiRecalc.Click += new EventHandler(this.tsmiRecalc_Click);
            this.tsmiAbout.Alignment = ToolStripItemAlignment.Right;
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new Size(94, 20);
            this.tsmiAbout.Text = "О программе";
            this.tsmiAbout.Click += new EventHandler(this.tsmiAbout_Click);
            this.niMain.BalloonTipIcon = ToolTipIcon.Info;
            this.niMain.BalloonTipTitle = "События на сегодня";
            this.niMain.ContextMenuStrip = this.cmsTray;
            this.Icon = Days.Properties.Resources.Main;
            this.niMain.Text = "События";
            this.niMain.BalloonTipClicked += new EventHandler(this.niMain_BalloonTipClicked);
            this.niMain.DoubleClick += new EventHandler(this.niMain_DoubleClick);
            this.cmsTray.Items.AddRange(new ToolStripItem[2]
            {
        (ToolStripItem) this.tsmiShow,
        (ToolStripItem) this.tsmiExit
            });
            this.cmsTray.Name = "cmsTray";
            this.cmsTray.Size = new Size(155, 48);
            this.tsmiShow.Name = "tsmiShow";
            this.tsmiShow.Size = new Size(154, 22);
            this.tsmiShow.Text = "Показать окно";
            this.tsmiShow.Click += new EventHandler(this.tsmiShow_Click);
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new Size(154, 22);
            this.tsmiExit.Text = "Выйти";
            this.tsmiExit.Click += new EventHandler(this.tsmiExit_Click);
            this.tMain.Interval = 60000;
            this.tMain.Tick += new EventHandler(this.tMain_Tick);
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(975, 612);
            this.Controls.Add((Control)this.tcMain);
            this.Controls.Add((Control)this.msMain);
            this.Icon = Days.Properties.Resources.Main;
            this.MainMenuStrip = this.msMain;
            this.Name = "FormMain";
            this.Text = "События";
            this.Load += new EventHandler(this.FormMain_Load);
            this.Resize += new EventHandler(this.FormMain_Resize);
            this.tcEvents.ResumeLayout(false);
            this.tpFuture.ResumeLayout(false);
            ((ISupportInitialize)this.dgvFutureEvents).EndInit();
            this.tpPast.ResumeLayout(false);
            ((ISupportInitialize)this.dgvPastEvents).EndInit();
            this.msContact.ResumeLayout(false);
            this.msContact.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpEvents.ResumeLayout(false);
            this.tpContacts.ResumeLayout(false);
            this.tpContacts.PerformLayout();
            ((ISupportInitialize)this.dgvContacts).EndInit();
            ((ISupportInitialize)this.bsContacts).EndInit();
            this.ssContactLifeTime.ResumeLayout(false);
            this.ssContactLifeTime.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.cmsTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private TimeMeasureCollection timeMeasures;
        private ContactCollection contacts;
        private DateEventCollection dateEvents;
        private Settings settings;
        private bool formMaximized;
        private const string version = "1.1.3";
        private BackgroundWorker bgwLoader;
        private TabControl tcEvents;
        private TabPage tpFuture;
        private TabPage tpPast;
        private MenuStrip msContact;
        private DataGridView dgvFutureEvents;
        private TabControl tcMain;
        private TabPage tpEvents;
        private TabPage tpContacts;
        private DataGridView dgvContacts;
        private DataGridView dgvPastEvents;
        private MenuStrip msMain;
        private ToolStripMenuItem tsmiSettings;
        private ToolStripMenuItem tsmiRecalc;
        private NotifyIcon niMain;
        private ContextMenuStrip cmsTray;
        private ToolStripMenuItem tsmiShow;
        private ToolStripMenuItem tsmiExit;
        private Timer tMain;
        private BindingSource bsContacts;
        private ToolStripMenuItem tsmiAbout;
        private ToolStripMenuItem tsmiChangeHour;
        private ToolStripMenuItem tsmiCalculations;
        private StatusStrip ssContactLifeTime;
        private ToolStripStatusLabel tsslContactLifeTime;
        private ToolStripComboBox tscbContactSort;
        private ToolStripStatusLabel tsslContactCount;
        private ToolStripStatusLabel tsslMiddle;
        private DataGridViewTextBoxColumn colFio;
        private DataGridViewTextBoxColumn colBirthDate;
        private DataGridViewTextBoxColumn colContactInfo;
        private DataGridViewTextBoxColumn colFutureEventsDate;
        private DataGridViewTextBoxColumn colFutureEventsContact;
        private DataGridViewTextBoxColumn colFutureEventsInfo;
        private DataGridViewTextBoxColumn colPastEventsDate;
        private DataGridViewTextBoxColumn colPastEventsContact;
        private DataGridViewTextBoxColumn colPastEventsInfo;
        private ToolStripMenuItem контактToolStripMenuItem;
        private ToolStripMenuItem tsmiAddContact;
        private ToolStripMenuItem tsmiEditContact;
        private ToolStripMenuItem tsmiRemoveContact;
        private ToolStripTextBox tstbFilter;
        private ToolStripMenuItem tsmiEnableFilter;
    }
}
