using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Days
{
    public partial class FormCalculations : Form
    {
        public FormCalculations(string fio, DateTime startDate, Settings settings)
        {
            this.InitializeComponent();
            this._startDate = startDate;
            this._settings = settings;
            this.Text = this.Text + " " + fio;
            this.dgvEvents.AutoGenerateColumns = false;
            this.nudSecondsStep.Value = (Decimal)settings.SecondsStep;
            this.nudMinutesStep.Value = (Decimal)settings.MinutesStep;
            this.nudHoursStep.Value = (Decimal)settings.HoursStep;
            this.nudDaysStep.Value = (Decimal)settings.DaysStep;
            this.nudWeeksStep.Value = (Decimal)settings.WeeksStep;
            this.nudMonthesStep.Value = (Decimal)settings.MonthesStep;
            this.chbSeconds.Checked = settings.UseSecondsStep;
            this.chbMinutes.Checked = settings.UseMinutesStep;
            this.chbHours.Checked = settings.UseHoursStep;
            this.chbDays.Checked = settings.UseDaysStep;
            this.chbWeeks.Checked = settings.UseWeeksStep;
            this.chbMonthes.Checked = settings.UseMonthesStep;
        }

        private void FormCalculations_Load(object sender, EventArgs e)
        {
            this.Calculate();
        }

        private void Calculate()
        {
            this._settings.SecondsStep = (int)this.nudSecondsStep.Value;
            this._settings.MinutesStep = (int)this.nudMinutesStep.Value;
            this._settings.HoursStep = (int)this.nudHoursStep.Value;
            this._settings.DaysStep = (int)this.nudDaysStep.Value;
            this._settings.WeeksStep = (int)this.nudWeeksStep.Value;
            this._settings.MonthesStep = (int)this.nudMonthesStep.Value;
            this._settings.UseSecondsStep = this.chbSeconds.Checked;
            this._settings.UseMinutesStep = this.chbMinutes.Checked;
            this._settings.UseHoursStep = this.chbHours.Checked;
            this._settings.UseDaysStep = this.chbDays.Checked;
            this._settings.UseWeeksStep = this.chbWeeks.Checked;
            this._settings.UseMonthesStep = this.chbMonthes.Checked;
            this._settings.Save();
            TimeMeasureCollection measureCollection = TimeMeasureCollection.Generate();
            this.dgvEvents.DataSource = (object)null;
            List<DateEvent> dateEventList = new List<DateEvent>();
            if (this.chbSeconds.Checked && this.nudSecondsStep.Value > Decimal.Zero)
            {
                TimeMeasure measure = measureCollection.Find("Seconds");
                if (measure != null)
                    dateEventList.AddRange((IEnumerable<DateEvent>)this.GetEvents((uint)this.nudSecondsStep.Value, TimeSpan.FromSeconds((double)(uint)this.nudSecondsStep.Value), measure));
            }
            if (this.chbMinutes.Checked && this.nudMinutesStep.Value > Decimal.Zero)
            {
                TimeMeasure measure = measureCollection.Find("Minutes");
                if (measure != null)
                    dateEventList.AddRange((IEnumerable<DateEvent>)this.GetEvents((uint)this.nudMinutesStep.Value, TimeSpan.FromMinutes((double)(uint)this.nudMinutesStep.Value), measure));
            }
            if (this.chbHours.Checked && this.nudHoursStep.Value > Decimal.Zero)
            {
                TimeMeasure measure = measureCollection.Find("Hours");
                if (measure != null)
                    dateEventList.AddRange((IEnumerable<DateEvent>)this.GetEvents((uint)this.nudHoursStep.Value, TimeSpan.FromHours((double)(uint)this.nudHoursStep.Value), measure));
            }
            if (this.chbDays.Checked && this.nudDaysStep.Value > Decimal.Zero)
            {
                TimeMeasure measure = measureCollection.Find("Days");
                if (measure != null)
                    dateEventList.AddRange((IEnumerable<DateEvent>)this.GetEvents((uint)this.nudDaysStep.Value, TimeSpan.FromDays((double)(uint)this.nudDaysStep.Value), measure));
            }
            if (this.chbWeeks.Checked && this.nudWeeksStep.Value > Decimal.Zero)
            {
                TimeMeasure measure = measureCollection.Find("Weeks");
                if (measure != null)
                    dateEventList.AddRange((IEnumerable<DateEvent>)this.GetEvents((uint)this.nudWeeksStep.Value, TimeSpan.FromDays((double)(7U * (uint)this.nudWeeksStep.Value)), measure));
            }
            if (this.chbMonthes.Checked && this.nudMonthesStep.Value > Decimal.Zero)
            {
                TimeMeasure measure = measureCollection.Find("Monthes");
                if (measure != null)
                    dateEventList.AddRange((IEnumerable<DateEvent>)this.GetMonthEvents((int)this.nudMonthesStep.Value, measure));
            }
            if (this.rbResultByDates.Checked)
                dateEventList.Sort(new Comparison<DateEvent>(DateEvent.Comparer));
            this.dgvEvents.DataSource = (object)dateEventList;
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            this.Calculate();
        }

        private List<DateEvent> GetEvents(uint step, TimeSpan stepTime, TimeMeasure measure)
        {
            List<DateEvent> dateEventList = new List<DateEvent>();
            DateTime startDate = this._startDate;
            DateTime dateTime = startDate.AddYears(100);
            uint num = 0;
            while (startDate < dateTime)
            {
                startDate += stepTime;
                num += step;
                dateEventList.Add(new DateEvent()
                {
                    Date = startDate,
                    Quantity = num,
                    TimeMeasure = measure
                });
            }
            return dateEventList;
        }

        private List<DateEvent> GetMonthEvents(int step, TimeMeasure measure)
        {
            List<DateEvent> dateEventList = new List<DateEvent>();
            DateTime dateTime1 = this._startDate;
            DateTime dateTime2 = dateTime1.AddYears(100);
            uint num = 0;
            while (dateTime1 < dateTime2)
            {
                dateTime1 = dateTime1.AddMonths(step);
                num += (uint)step;
                dateEventList.Add(new DateEvent()
                {
                    Date = dateTime1,
                    Quantity = num,
                    TimeMeasure = measure
                });
            }
            return dateEventList;
        }

    }
}
