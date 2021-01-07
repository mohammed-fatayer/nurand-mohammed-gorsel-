using System;
using System.Windows.Forms;

namespace project00
{
    public partial class messageform : Form
    {
        public static string passingtext;
        public messageform()
        {
            InitializeComponent();
            TextBox textBox1 = new TextBox();
            var timer = new System.Timers.Timer();
            timer.Interval = 5000; // every 5 seconds
           
            timer.Start();


        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

                return;
            }
            string massage = textBox1.Text;
            string ownerid = textBox3.Text;
            string customerid = textBox4.Text;
            massages ms = new massages();
            var result = ms.sendmassage(massage,ownerid,customerid);
            if (result == null)
            {
                passingtext = textBox1.Text;
                textBox2.Text = textBox2.Text + passingtext + Environment.NewLine;
                textBox1.Text = null;
            }
            else
            {
                MessageBox.Show("can not send the massage");
            }

           

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string ownerid = textBox3.Text;
            string customerid = textBox4.Text;
            massages ms = new massages();

            var result = ms.deletemassage(ownerid, customerid);
            if (result==null)
            {
                textBox1.Text = null;
                textBox2.Text = null;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_update(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string ownerid = textBox3.Text;
            string customerid = textBox4.Text;
            massages ms = new massages();
           // textBox1.Text = ms.getmassage( ownerid, customerid);
        }
    }
}
