using System.Windows.Forms;

namespace Days
{
    public partial class FormAbout : Form
    {

        public FormAbout(string version)
        {
            this.InitializeComponent();
            this.tbVersion.Text = version;
        }  
    }
}
