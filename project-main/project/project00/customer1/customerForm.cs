using project00.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace project00
{
    public partial class customerForm : Form
    {
        public customerForm()
        {
            InitializeComponent();
        }

        private void customerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.jpg,*.png,*.bim)|*.jpg;*.png;*.bim";
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Bitmap img = new Bitmap(dialog.FileName);
                pictureBox1.Image = img;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbName.Text = null;
            tbLastName.Text = null;
            tbEmail.Text = null;
            tbPassword.Text = null;
            tbAdress.Text = null;
            
            comboBox1.Text = null;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //showForm sform = new showForm();
            //sform.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            string firstname = tbName.Text.Trim();
            string lastname = tbLastName.Text.Trim();
            string email = tbEmail.Text.Trim();
            string gender = comboBox1.Text;
            string password = tbPassword.Text.Trim();
            string address = tbAdress.Text;



            var result = c.newcustomerinfo(firstname, lastname, email, gender, password, address);
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
