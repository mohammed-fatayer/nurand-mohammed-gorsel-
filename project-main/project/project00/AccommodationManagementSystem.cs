using project00.model;
using project00.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace project00
{
    public partial class AccommodationManagementSystem : Form
    {
        Person person = null;

        public AccommodationManagementSystem(Person p)
        {
            InitializeComponent();
            person = p;
        }

        private void AccommodationManagementSystem_Load(object sender, EventArgs e)
        {
            if (person != null)
            {
                lblWelcome.Text = "Hello " + person.Firstname;

            }
        }



        private void button10_Click(object sender, EventArgs e)
        {
            if (person != null)
            {
                Customer cust = (Customer)person;
                Customer obj = new Customer();
                dgvData.DataSource = obj.GetCustomerInfo(cust.CustomerID);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void button6_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Accommodation Details";
            accommodation obj = new accommodation();
            dgvData.DataSource = obj.GetAccInfo();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bthome_Click(object sender, EventArgs e)
        {

            try
            {
                // 1.make bt to be class, sender was obj,but now are bt,
                //let the bt read as a name//2.sh as a txbx
                //string name = ((Button)sender).Name;
                //MessageBox.Show(name); 
                //}
                //catch (Exception)
                //{

                //    throw;
                //}

                UpdateBorder(((Button)sender).Name); //4
            }
            catch (Exception)
            {

            }

        }

        // 3 update button 
        private void UpdateBorder(string name) //x1
        {
            try
            { // ctrl prop (get:read only )
                foreach (var control in splitContainer1.Panel1.Controls)
                {
                    if (control is Button) //backgofbutton
                    {
                        //control.GetType();
                        var btn = (Button)control;
                        if (btn.Name == name) //x1        
                        {
                            //btn.FlatAppearance.BorderColor = Color.Red;
                            btn.BackColor = Color.DarkViolet;
                        }
                        else
                        {
                            btn.BackColor = Color.MintCream;
                            //btn.FlatAppearance.BorderColor = Color.DeepSkyBlue;
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void btdetails_Click(object sender, EventArgs e)
        {
            try
            {
                string name = ((Button)sender).Name;
                MessageBox.Show(name);

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btmassage_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateBorder(((Button)sender).Name);
            }
            catch (Exception)
            {
            }
        }

        private void btadvert_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Accommodation Details";
            Payment obj = new Payment();
            dgvData.DataSource = obj.GetPaymentInfo();
            try
            {
                UpdateBorder(((Button)sender).Name);
            }
            catch (Exception)
            {

            }
        }

        private void btdetails_Click_1(object sender, EventArgs e)
        {
            try
            {
                UpdateBorder(((Button)sender).Name);
            }
            catch (Exception)
            {

            }
        }
    }
}
