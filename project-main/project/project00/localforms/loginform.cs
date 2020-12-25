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
using project00.Models;
namespace project00
{
    public partial class loginform : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public loginform()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                string firstname = textBox2.Text.Trim();
                string password = textBox1.Text.Trim();
                if (comboBox1.Text == "owner")
                {
                   
                    textBox2.Text = textBox2.Text.Replace(" ", "");
                    if (textBox2.Text != "" && textBox1.Text != "")
                    {

                        owner o = new owner();
                       var result = o.Login(firstname, password);
                        if (result != null) 
                       
                        {
                            label3.ForeColor = Color.Green;
                            label3.Text = ("you are in");
                            this.Hide();
                            ownerform oform = new ownerform();
                            oform.Show();
                        }

                    }
                
                    
                }
                else
                {
                    Customer c = new Customer();
                    var result = c.Login(firstname, password);
                   // label3.ForeColor = Color.Green;
                   // label3.Text = ("you are in");
                   // this.Hide();
                    label3.ForeColor = Color.Red;
                    label3.Text = ("check the customer form not working");

                }


            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message);
               
            }
          
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
