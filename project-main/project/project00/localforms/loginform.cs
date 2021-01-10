using project00.Models;
using System;
using System.Data.SqlClient;
using System.Drawing;
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
                            ownerform oform = new ownerform(result);
                            oform.Show();
                        }
                        else
                        {
                            MessageBox.Show("wrong information");
                        }

                    }


                }
             
                if(comboBox1.Text == "customer")
                {

                    textBox2.Text = textBox2.Text.Replace(" ", "");
                    if (textBox2.Text != "" && textBox1.Text != "")
                    {
                        Customer c = new Customer();
                        var result = c.Login(firstname, password);
                        if (result != null)
                        {
                            label3.ForeColor = Color.Green;
                            label3.Text = ("you are in");
                            this.Hide();
                            AccommodationManagementSystem oform = new AccommodationManagementSystem(result);
                            oform.Show();
                        }
                        else
                        {
                            MessageBox.Show("wrong infromation");
                        }
                    }

                   
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

        private void button3_Click(object sender, EventArgs e)
        {

            registrationform rform = new registrationform();
            rform.ShowDialog();
        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
