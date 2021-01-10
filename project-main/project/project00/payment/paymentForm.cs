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
                    //tbnPaymentID.Text = pmt.PaymentID.ToString();
                    dateTimePicker1.Value = pmt.PaymentDate;
                    rTbnSellerID.Text = pmt.OwnerID.ToString();
                    rTbnAccID.Text = pmt.AccommodationID.ToString();
                    rTbnCustID.Text = pmt.CustomerID.ToString();
                    cbPaymentSelect.SelectedValue = pmt.PaymentSelection;
                    //tbnAmount.Text = pmt.Amount.ToString();
                    tbnStatus.Text = pmt.Status.ToString();
                    //tbnRemain.Text = pmt.Remain.ToString();
                    actionForm = action;
                }
            }
            else
            {
                actionForm = action;
            }
        }

        private void tbnAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckKeyPress(sender, e);
        }

        private static void CheckKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
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
                pmt.Amount = tbnAmount.Text == "" ? 0 : Convert.ToDecimal(tbnAmount.Text);
                pmt.Status = tbnStatus.Text;
                pmt.Remain = tbnRemain.Text == "" ? 0 : Convert.ToDecimal(tbnRemain.Text);
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
            //tbnPaymentID.Text = "";
            dateTimePicker1.Text = "";
            rTbnSellerID.Text = "";
            rTbnCustID.Text = "";
            rTbnAccID.Text = "";
            cbPaymentSelect.Text = "";
            tbnAmount.Text = "";
            tbnStatus.Text = "";
            tbnRemain.Text = "";
        }



        private void tbnRemain_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckKeyPress(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                pmt.Amount = tbnAmount.Text == "" ? 0 : Convert.ToDecimal(tbnAmount.Text);
                pmt.Status = tbnStatus.Text;
                pmt.Remain = tbnRemain.Text == "" ? 0 : Convert.ToDecimal(tbnRemain.Text);
                if (actionForm != "" && actionForm != "edit")
                    pmt.PaymentAdd(pmt);
                else
                    //Edit

                    ClearData();
            }

            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Text = "";
            rTbnAccID.Text = "";
            rTbnCustID.Text = "";
            rTbnSellerID.Text = "";
            cbPaymentSelect.Text = "";
            tbnAmount.Text = ""; 
            tbnStatus.Text = "";
            tbnRemain.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
