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
    public partial class massageform : Form
    {
        public static string passingtext;
        public massageform()
        {
            InitializeComponent();
            TextBox textBox1 = new TextBox();

            
         
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
               
                return;
            }
            passingtext = textBox1.Text;
            textBox2.Text = textBox2.Text+passingtext+ Environment.NewLine;
            textBox1.Text = null;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }
    }
}
