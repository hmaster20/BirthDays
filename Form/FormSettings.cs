using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Days
{
    public partial class FormSettings : Form
    {
        public FormSettings(Settings settings)
        {
            this.InitializeComponent();
            this.editedSettings = settings;
            this.chbUseSeconds.Checked = this.editedSettings.UseSeconds;
            this.chbUseMinutes.Checked = this.editedSettings.UseMinutes;
            this.chbUseHours.Checked = this.editedSettings.UseHours;
            this.chbUseDays.Checked = this.editedSettings.UseDays;
            this.chbUseWeeks.Checked = this.editedSettings.UseWeeks;
            this.chbUseMonthes.Checked = this.editedSettings.UseMonthes;
            this.chbUseYears.Checked = this.editedSettings.UseYears;
            this.chbEveryYear.Checked = this.editedSettings.CalcEveryYear;
            this.nudPreviousDays.Value = (Decimal)this.editedSettings.PreviousDaysQuantity;
            this.nudNextDays.Value = (Decimal)this.editedSettings.NextDaysQuantity;
            this.nudRecalcDays.Value = (Decimal)this.editedSettings.RecountDaysQuantity;
            this.chbExponent.Checked = this.editedSettings.UseExponentCalc;
            this.chbSameDigits.Checked = this.editedSettings.UseSameDigitsCalc;
            this.tbMidNums.Text = this.editedSettings.MidNumsString;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.editedSettings.UseSeconds = this.chbUseSeconds.Checked;
            this.editedSettings.UseMinutes = this.chbUseMinutes.Checked;
            this.editedSettings.UseHours = this.chbUseHours.Checked;
            this.editedSettings.UseDays = this.chbUseDays.Checked;
            this.editedSettings.UseWeeks = this.chbUseWeeks.Checked;
            this.editedSettings.UseMonthes = this.chbUseMonthes.Checked;
            this.editedSettings.UseYears = this.chbUseYears.Checked;
            this.editedSettings.CalcEveryYear = this.chbEveryYear.Checked;
            this.editedSettings.PreviousDaysQuantity = (int)this.nudPreviousDays.Value;
            this.editedSettings.NextDaysQuantity = (int)this.nudNextDays.Value;
            this.editedSettings.RecountDaysQuantity = (int)this.nudRecalcDays.Value;
            this.editedSettings.UseExponentCalc = this.chbExponent.Checked;
            this.editedSettings.UseSameDigitsCalc = this.chbSameDigits.Checked;
            this.editedSettings.MidNumsString = this.tbMidNums.Text;
            this.DialogResult = DialogResult.OK;
        }


    }
}
