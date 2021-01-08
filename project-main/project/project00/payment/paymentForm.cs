using project00.model;
using project00.Models;
using System;
using System.Windows.Forms;

namespace project00
{
    public partial class PaymentForm : Form
    {
        private Customer customerInfo; //e1   
        private string actionForm = "";
        public PaymentForm()
        {
        }
        public PaymentForm(Customer obj, Payment pmt, string action)
        {
            InitializeComponent();
            this.customerInfo = obj; //e3
            if (action == "edit")
            {
                if (pmt != null)
                {
                    tbnPaymentID.Text = pmt.PaymentID.ToString();
                    dateTimePicker1.Value = pmt.PaymentDate;
                    rTbnSellerID.Text = pmt.OwnerID.ToString();
                    rTbnAccID.Text = pmt.AccommodationID.ToString();
                    rTbnCustID.Text = pmt.CustomerID.ToString();
                    cbPaymentSelect.SelectedValue = pmt.PaymentSelection;
                    tbnAmount.Text = pmt.Amount.ToString();
                    tbnStatus.Text = pmt.Status.ToString();
                    tbnRemain.Text = pmt.Remain.ToString();
                   actionForm = action;
                }
            }
            else
            {
                actionForm = action;
            }
        }
       
        private void button1_Click(object sender, System.EventArgs e)
        {
            if (customerInfo.customerID > 0)
            {
                Payment pmt = new Payment();
                pmt.PaymentID = customerInfo.CustomerID;
                pmt.PaymentDate = dateTimePicker1.Value;
                pmt.OwnerID = customerInfo.CustomerID;
                pmt.AccommodationID = customerInfo.customerID;
                pmt.CustomerID = customerInfo.CustomerID;
                pmt.PaymentSelection = cbPaymentSelect.Text;
                pmt.Amount = Convert.ToInt32(tbnAmount.Text);
                pmt.Status = tbnStatus.Text;
                pmt.Remain = Convert.ToInt32(tbnRemain.Text);
                if (actionForm != "" && actionForm != "edit")
                    pmt.PaymentAdd(pmt);
                else
                    //Edit

                    ClearData();
            }

            this.Hide();
        }
        private void ClearData()
        {
            tbnPaymentID.Text = "";
            dateTimePicker1.Text = "";
            rTbnSellerID.Text = "";
            rTbnCustID.Text = "";
            rTbnAccID.Text = "";
            cbPaymentSelect.Text = "";
            tbnAmount.Text = "";
            tbnStatus.Text = "";
            tbnRemain.Text = "";
        }
    }
}
