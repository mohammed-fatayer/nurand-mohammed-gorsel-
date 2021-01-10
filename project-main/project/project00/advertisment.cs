using project00.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project00
{
    public partial class advertisment : Form
    {
        public advertisment()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string accommodationid = textBox2.Text;
            string comment = textBox1.Text;
            if (textBox1.Text !=""&&textBox2.Text!="")
            {
                owner o = new owner();
                var result = o.advertismet( comment, accommodationid);
                MessageBox.Show("your add saved sucsesfuly ");
                this.Hide();
            }
            else
            {
                MessageBox.Show("error check all information");
            }
         
        }
    }
}
