using project00.Models;
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
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 3000;
            timer.Elapsed += timer_Elapsed;
            timer.Start();


            TextBox.CheckForIllegalCrossThreadCalls = false;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

                return;
            }

            owner o = new owner();


            string massage = textBox1.Text;
            string ownerid = textBox3.Text;
            string customerid = textBox4.Text;
            massages ms = new massages();
            var result = ms.sendmassage(massage, ownerid, customerid);
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
            if (result == null)
            {
                textBox1.Text = null;
                textBox2.Text = null;
            }

        }





        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (textBox3.Text != "" && textBox4.Text != "")
            {

                textBox2.Text = null;
                string ownerid = textBox3.Text;
                string customerid = textBox4.Text;
                massages ms = new massages();

                for (int i = 0; i < ms.getmassage(ownerid, customerid).Length; i++)
                {

                    textBox2.Text = textBox2.Text + ms.getmassage(ownerid, customerid)[i] + Environment.NewLine;

                }
            };

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
