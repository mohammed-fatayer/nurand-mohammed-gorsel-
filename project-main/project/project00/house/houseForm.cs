using project00.customer;
using project00.location;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project00.house
{
    public partial class houseForm : Form
    {
        public houseForm()
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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbHouseID.Text = null;
            tbLocation.Text = null;
            tbDetails.Text = null;
            tbPeriod.Text = null;
            tbPrice.Text = null;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            locationForm form = new locationForm();
            form.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            customerForm form = new customerForm();
            form.ShowDialog();
        }
    }
}
