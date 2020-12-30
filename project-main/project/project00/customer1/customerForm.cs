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
            tbHouse.Text = null;
            maskedTextBox1.Text = null;
            comboBox1.Text = null;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //showForm sform = new showForm();
            //sform.Show();
        }
    }
}
