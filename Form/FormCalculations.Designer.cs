using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Days
{
    partial class FormCalculations
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormCalculations));
            this.pParameters = new Panel();
            this.groupBox1 = new GroupBox();
            this.rbResultByTypes = new RadioButton();
            this.rbResultByDates = new RadioButton();
            this.nudMonthesStep = new NumericUpDown();
            this.nudWeeksStep = new NumericUpDown();
            this.nudDaysStep = new NumericUpDown();
            this.nudHoursStep = new NumericUpDown();
            this.nudMinutesStep = new NumericUpDown();
            this.chbMonthes = new CheckBox();
            this.chbWeeks = new CheckBox();
            this.chbDays = new CheckBox();
            this.chbHours = new CheckBox();
            this.chbMinutes = new CheckBox();
            this.chbSeconds = new CheckBox();
            this.nudSecondsStep = new NumericUpDown();
            this.btCalculate = new Button();
            this.dgvEvents = new DataGridView();
            this.colDate = new DataGridViewTextBoxColumn();
            this.colInfo = new DataGridViewTextBoxColumn();
            this.pParameters.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.nudMonthesStep.BeginInit();
            this.nudWeeksStep.BeginInit();
            this.nudDaysStep.BeginInit();
            this.nudHoursStep.BeginInit();
            this.nudMinutesStep.BeginInit();
            this.nudSecondsStep.BeginInit();
            ((ISupportInitialize)this.dgvEvents).BeginInit();
            this.SuspendLayout();
            this.pParameters.Controls.Add((Control)this.groupBox1);
            this.pParameters.Controls.Add((Control)this.nudMonthesStep);
            this.pParameters.Controls.Add((Control)this.nudWeeksStep);
            this.pParameters.Controls.Add((Control)this.nudDaysStep);
            this.pParameters.Controls.Add((Control)this.nudHoursStep);
            this.pParameters.Controls.Add((Control)this.nudMinutesStep);
            this.pParameters.Controls.Add((Control)this.chbMonthes);
            this.pParameters.Controls.Add((Control)this.chbWeeks);
            this.pParameters.Controls.Add((Control)this.chbDays);
            this.pParameters.Controls.Add((Control)this.chbHours);
            this.pParameters.Controls.Add((Control)this.chbMinutes);
            this.pParameters.Controls.Add((Control)this.chbSeconds);
            this.pParameters.Controls.Add((Control)this.nudSecondsStep);
            this.pParameters.Controls.Add((Control)this.btCalculate);
            this.pParameters.Dock = DockStyle.Left;
            this.pParameters.Location = new Point(0, 0);
            this.pParameters.Name = "pParameters";
            this.pParameters.Size = new Size(220, 682);
            this.pParameters.TabIndex = 0;
            this.groupBox1.Controls.Add((Control)this.rbResultByTypes);
            this.groupBox1.Controls.Add((Control)this.rbResultByDates);
            this.groupBox1.Location = new Point(9, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(200, 45);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результат";
            this.rbResultByTypes.AutoSize = true;
            this.rbResultByTypes.Checked = true;
            this.rbResultByTypes.Location = new Point(3, 19);
            this.rbResultByTypes.Name = "rbResultByTypes";
            this.rbResultByTypes.Size = new Size(74, 17);
            this.rbResultByTypes.TabIndex = 1;
            this.rbResultByTypes.TabStop = true;
            this.rbResultByTypes.Text = "По видам";
            this.rbResultByTypes.UseVisualStyleBackColor = true;
            this.rbResultByDates.AutoSize = true;
            this.rbResultByDates.Location = new Point(121, 19);
            this.rbResultByDates.Name = "rbResultByDates";
            this.rbResultByDates.Size = new Size(73, 17);
            this.rbResultByDates.TabIndex = 0;
            this.rbResultByDates.Text = "По датам";
            this.rbResultByDates.UseVisualStyleBackColor = true;
            this.nudMonthesStep.Location = new Point(83, 139);
            this.nudMonthesStep.Maximum = new Decimal(new int[4]
            {
        1935228928,
        7,
        0,
        0
            });
            this.nudMonthesStep.Name = "nudMonthesStep";
            this.nudMonthesStep.Size = new Size(126, 20);
            this.nudMonthesStep.TabIndex = 11;
            this.nudMonthesStep.ThousandsSeparator = true;
            this.nudWeeksStep.Location = new Point(83, 113);
            this.nudWeeksStep.Maximum = new Decimal(new int[4]
            {
        1935228928,
        7,
        0,
        0
            });
            this.nudWeeksStep.Name = "nudWeeksStep";
            this.nudWeeksStep.Size = new Size(126, 20);
            this.nudWeeksStep.TabIndex = 10;
            this.nudWeeksStep.ThousandsSeparator = true;
            this.nudDaysStep.Location = new Point(83, 87);
            this.nudDaysStep.Maximum = new Decimal(new int[4]
            {
        1935228928,
        7,
        0,
        0
            });
            this.nudDaysStep.Name = "nudDaysStep";
            this.nudDaysStep.Size = new Size(126, 20);
            this.nudDaysStep.TabIndex = 9;
            this.nudDaysStep.ThousandsSeparator = true;
            this.nudHoursStep.Location = new Point(83, 61);
            this.nudHoursStep.Maximum = new Decimal(new int[4]
            {
        1935228928,
        7,
        0,
        0
            });
            this.nudHoursStep.Name = "nudHoursStep";
            this.nudHoursStep.Size = new Size(126, 20);
            this.nudHoursStep.TabIndex = 8;
            this.nudHoursStep.ThousandsSeparator = true;
            this.nudMinutesStep.Location = new Point(83, 35);
            this.nudMinutesStep.Maximum = new Decimal(new int[4]
            {
        1935228928,
        7,
        0,
        0
            });
            this.nudMinutesStep.Name = "nudMinutesStep";
            this.nudMinutesStep.Size = new Size(126, 20);
            this.nudMinutesStep.TabIndex = 7;
            this.nudMinutesStep.ThousandsSeparator = true;
            this.chbMonthes.AutoSize = true;
            this.chbMonthes.Location = new Point(12, 141);
            this.chbMonthes.Name = "chbMonthes";
            this.chbMonthes.Size = new Size(67, 17);
            this.chbMonthes.TabIndex = 5;
            this.chbMonthes.Text = "Месяцы";
            this.chbMonthes.UseVisualStyleBackColor = true;
            this.chbWeeks.AutoSize = true;
            this.chbWeeks.Location = new Point(12, 115);
            this.chbWeeks.Name = "chbWeeks";
            this.chbWeeks.Size = new Size(64, 17);
            this.chbWeeks.TabIndex = 4;
            this.chbWeeks.Text = "Недели";
            this.chbWeeks.UseVisualStyleBackColor = true;
            this.chbDays.AutoSize = true;
            this.chbDays.Location = new Point(12, 89);
            this.chbDays.Name = "chbDays";
            this.chbDays.Size = new Size(47, 17);
            this.chbDays.TabIndex = 3;
            this.chbDays.Text = "Дни";
            this.chbDays.UseVisualStyleBackColor = true;
            this.chbHours.AutoSize = true;
            this.chbHours.Location = new Point(12, 63);
            this.chbHours.Name = "chbHours";
            this.chbHours.Size = new Size(54, 17);
            this.chbHours.TabIndex = 2;
            this.chbHours.Text = "Часы";
            this.chbHours.UseVisualStyleBackColor = true;
            this.chbMinutes.AutoSize = true;
            this.chbMinutes.Location = new Point(12, 37);
            this.chbMinutes.Name = "chbMinutes";
            this.chbMinutes.Size = new Size(65, 17);
            this.chbMinutes.TabIndex = 1;
            this.chbMinutes.Text = "Минуты";
            this.chbMinutes.UseVisualStyleBackColor = true;
            this.chbSeconds.AutoSize = true;
            this.chbSeconds.Location = new Point(12, 12);
            this.chbSeconds.Name = "chbSeconds";
            this.chbSeconds.Size = new Size(70, 17);
            this.chbSeconds.TabIndex = 0;
            this.chbSeconds.Text = "Секунды";
            this.chbSeconds.UseVisualStyleBackColor = true;
            this.nudSecondsStep.Location = new Point(83, 9);
            this.nudSecondsStep.Maximum = new Decimal(new int[4]
            {
        1935228928,
        7,
        0,
        0
            });
            this.nudSecondsStep.Name = "nudSecondsStep";
            this.nudSecondsStep.Size = new Size(126, 20);
            this.nudSecondsStep.TabIndex = 6;
            this.nudSecondsStep.ThousandsSeparator = true;
            this.btCalculate.Location = new Point(73, 216);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new Size(75, 23);
            this.btCalculate.TabIndex = 12;
            this.btCalculate.Text = "Расчитать";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new EventHandler(this.btCalculate_Click);
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.AllowUserToResizeRows = false;
            this.dgvEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Columns.AddRange((DataGridViewColumn)this.colDate, (DataGridViewColumn)this.colInfo);
            this.dgvEvents.Dock = DockStyle.Fill;
            this.dgvEvents.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dgvEvents.Location = new Point(220, 0);
            this.dgvEvents.MultiSelect = false;
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.RowHeadersVisible = false;
            this.dgvEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvents.Size = new Size(345, 682);
            this.dgvEvents.TabIndex = 1;
            this.colDate.DataPropertyName = "DateString";
            this.colDate.HeaderText = "Дата";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colInfo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.colInfo.DataPropertyName = "Info";
            this.colInfo.HeaderText = "Срок";
            this.colInfo.Name = "colInfo";
            this.colInfo.ReadOnly = true;
            this.AcceptButton = (IButtonControl)this.btCalculate;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(565, 682);
            this.Controls.Add((Control)this.dgvEvents);
            this.Controls.Add((Control)this.pParameters);
            this.Icon = Days.Properties.Resources.Calculations;
            this.Name = "FormCalculations";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Расчеты";
            this.Load += new EventHandler(this.FormCalculations_Load);
            this.pParameters.ResumeLayout(false);
            this.pParameters.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.nudMonthesStep.EndInit();
            this.nudWeeksStep.EndInit();
            this.nudDaysStep.EndInit();
            this.nudHoursStep.EndInit();
            this.nudMinutesStep.EndInit();
            this.nudSecondsStep.EndInit();
            ((ISupportInitialize)this.dgvEvents).EndInit();
            this.ResumeLayout(false);
        }

        private DateTime _startDate = DateTime.Now;
        private Settings _settings;
        private Panel pParameters;
        private DataGridView dgvEvents;
        private NumericUpDown nudSecondsStep;
        private Button btCalculate;
        private NumericUpDown nudMonthesStep;
        private NumericUpDown nudWeeksStep;
        private NumericUpDown nudDaysStep;
        private NumericUpDown nudHoursStep;
        private NumericUpDown nudMinutesStep;
        private CheckBox chbMonthes;
        private CheckBox chbWeeks;
        private CheckBox chbDays;
        private CheckBox chbHours;
        private CheckBox chbMinutes;
        private CheckBox chbSeconds;
        private GroupBox groupBox1;
        private RadioButton rbResultByTypes;
        private RadioButton rbResultByDates;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colInfo;
    }
}
