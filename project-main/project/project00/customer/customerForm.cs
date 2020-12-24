using project00.accommodation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project00.customer
{
    public partial class customerForm : Form
    {
        public customerForm()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            showForm sform = new showForm();
            sform.Show();
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

    
    }
}
