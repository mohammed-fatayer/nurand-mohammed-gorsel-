using project00.Models;
using System.Windows.Forms;

namespace project00
{
    public partial class oaddform : Form
    {
        public oaddform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            owner o = new owner();
            string firstname = textBox1.Text.Trim();
            string lastname = textBox2.Text.Trim();
            string email = textBox5.Text.Trim();
            string gender = comboBox1.Text;
            string password = textBox6.Text.Trim();
            string address = textBox3.Text;
            


            var result = o.newownerinfo(firstname,lastname,email,gender,  password, address);
            if (result == null)
            {
                MessageBox.Show("your registration in done you can log in using your firstname and password");
                this.Close();
                
            }
            else
            {
                MessageBox.Show("wrong information");
            }
        }
    }
}
