using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Days
{
    public partial class FormEventInfo : Form
    {        
        public FormEventInfo(DateEvent dateEvent)
        {
            this.InitializeComponent();
            this.dtpEventDate.Value = dateEvent.Date;
            this.tbEventInfo.Text = dateEvent.Info;
            this.tbFio.Text = dateEvent.Contact.Fio;
            this.dtpBirthDate.Value = dateEvent.Contact.BirthDate;
            this.tbContactInfo.Text = dateEvent.Contact.Info;
        }

    }
}
