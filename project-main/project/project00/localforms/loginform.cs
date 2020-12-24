using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project00
{
    public partial class loginform : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public loginform()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-QB99BRD;Initial Catalog=sms;Integrated Security=True";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*
                if (comboBox1.Text == "owner")
                {


                    textBox2.Text = textBox2.Text.Replace(" ", "");
                    if (textBox2.Text == Name && textBox1.Text == password && comboBox1.Text == "owner")
                    {
                        label3.ForeColor = Color.Green;
                        label3.Text = ("you are in");
                        this.Hide();
                        ownerform oform = new ownerform();
                        oform.Show();


                    }
                    else
                    {
                        label3.ForeColor = Color.Red;
                        label3.Text = ("wrong information or missing");

                    }


                }
                else
                {

                    textBox2.Text = textBox2.Text.Replace(" ", "");
                    if (textBox2.Text == Name && textBox1.Text == password && comboBox1.Text == "owner")
                    {
                        label3.ForeColor = Color.Green;
                        label3.Text = ("you are in");
                        this.Hide();
                        ownerform oform = new ownerform();
                        oform.Show();


                    }
                    else
                    {
                        label3.ForeColor = Color.Red;
                        label3.Text = ("wrong information or missing");

                    }

            }
                */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox1.Text = null;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }
    }
}
