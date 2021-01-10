using project00.Models;
using System;
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
                    if(!string.IsNullOrEmpty(cust.PhoneNumber))
                        mtPhone.Text = cust.PhoneNumber.ToString();
                    

                    actionForm = action;
                }
            }
            else
            {
                actionForm = action;
            }
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
                cust.PhoneNumber = mtPhone.Text;
                cust.CustomerID = customerInfo.customerID;
                if (actionForm != "" && actionForm == "edit")
                    cust.CustomerEdit(cust);
               

                    ////Edit

                    //clearData();
            }

            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbLastName.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
            CBgender.Text = "";
            mtPhone.Text = "";
        }
    }
}


