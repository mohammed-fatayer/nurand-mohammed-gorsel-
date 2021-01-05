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
    public partial class AddAccForm : Form
    {
        private owner ownerInfo; //e1   
        private string actionForm = "";
        public AddAccForm()
        {
        }

        public AddAccForm(owner obj, accommodation acc,string action) //e2
        {
            InitializeComponent();
            this.ownerInfo = obj; //e3
            if (action == "edit")
            {
                if(acc != null)
                {
                    cbOperation.SelectedValue = acc.Operation;
                    txtDetail.Text = acc.Details_accommodation;
                    txtPrice.Text = acc.Price.ToString();
                    txtPrice.Text = acc.Period.ToString();
                    
                    actionForm = action;
                }
            }
            else
            {
                actionForm = action;
            }
        }
        //e4
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ownerInfo.OwnerID > 0)
            {
                accommodation acc = new accommodation();
                acc.Operation = cbOperation.Text;
                acc.Details_accommodation = txtDetail.Text;
                //acc.LocationID = cbLocation.SelectedIndex;
                acc.Price = Convert.ToInt32(txtPrice.Text);
                acc.Period = Convert.ToInt32(txtPeriod.Text);
                acc.OwnerID = ownerInfo.OwnerID;
                if(actionForm != "" && actionForm != "edit")
                    acc.AccommodationAdd(acc);
                else
                    //Edit

                ClearData();
            }

            
            this.Hide();

        }

        private void ClearData()
        {
            txtDetail.Text = "";
            txtPrice.Text = "";
            txtPeriod.Text = "";
        }

      
    }
}
