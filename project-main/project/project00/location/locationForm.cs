using System.Windows.Forms;

namespace project00
{
    public partial class locationForm : Form
    {
        public locationForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            tbLocation.Text = "";
            richTbAddress.Text = "";
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {

        }
    }
}
