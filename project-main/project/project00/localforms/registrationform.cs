using System;
using System.Windows.Forms;

namespace project00
{
    public partial class registrationform : Form
    {
        public registrationform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.Hide();
                oaddform odfrom = new oaddform();
                odfrom.Show();
            }
            else
            {
                MessageBox.Show("you must accept policy to make account");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                this.Hide();
                customerForm cdform = new customerForm();
                cdform.Show();
            }
            else
            {
                MessageBox.Show("you must accept policy to make account");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
