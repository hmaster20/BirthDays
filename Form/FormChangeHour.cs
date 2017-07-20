using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Days
{
  public partial class FormChangeHour : Form
  {

    public FormChangeHour()
    {
      this.InitializeComponent();
    }

    private void btOk_Click(object sender, EventArgs e)
    {
      this.Forward = this.rbForward.Checked;
      DateTime dateTime = this.dtpTimeShift.Value;
      TimeSpan timeSpan1 = TimeSpan.FromHours((double) dateTime.Hour);
      dateTime = this.dtpTimeShift.Value;
      TimeSpan timeSpan2 = TimeSpan.FromMinutes((double) dateTime.Minute);
      this.TimeShift = timeSpan1 + timeSpan2;
      this.DialogResult = DialogResult.OK;
    }

  }
}
