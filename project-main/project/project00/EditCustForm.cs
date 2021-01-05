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
    public partial class EditCustForm : Form
    {
        //es 1
        private Customer customerInfo;
        private string actionForm = "";
        public EditCustForm()
        {
        }
        public EditCustForm(Customer custInfo, Customer cust, string action)
        {
            InitializeComponent();
            this.customerInfo = custInfo;
            if (action == "edit")
            {
                if (cust != null)
                {
                    tbName.Text = cust.Firstname;
                    tbLastName.Text = cust.Lastname;
                    CBgender.SelectedValue = cust.Gender;
                    tbEmail.Text = cust.Email;
                    tbPassword.Text = cust.Password;
                    mtPhone.Text = cust.PhoneNumber.ToString();
                    actionForm = action;
                }
            }
            else
            {
                actionForm = action;
            }
        }

        private void btnUpdateCust_Click(object sender, EventArgs e)
        {
           
        }
    
             private void clearData()
        {
            tbName.Text = "";
            tbLastName.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
            CBgender.Text = "";
            mtPhone.Text = "";
        }

        private void btnUpdateCust_Click_1(object sender, EventArgs e)
        {
 if (customerInfo.customerID > 0)
            {
                Customer cust = new Customer();
                cust.Gender = CBgender.Text;
                cust.Firstname = tbName.Text;
                cust.Lastname = tbLastName.Text;
                cust.Email = tbEmail.Text;
                cust.Password = tbPassword.Text;
                //cust.PhoneNumber = Convert.ToInt32(mtPhone.Text);
                if (actionForm != "" && actionForm != "edit")
                   cust.CustomerAdd(cust);
                else
                 
                    //Edit

                    clearData();
            }
       
                this.Hide();
        }
    }
} 


