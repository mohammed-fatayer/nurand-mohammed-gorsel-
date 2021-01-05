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
        int ID = -1;//b1 -1:choose nothing
      
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
                lblTitle.Text = "Customer details";
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
            dgvData.DataSource = obj.GetAccInfo(0);
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
                            btn.BackColor = Color.SkyBlue;
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
            lblTitle.Text = "Payment Details";
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateBorder(((Button)sender).Name);
            }
            catch (Exception)
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                UpdateBorder(((Button)sender).Name);
            }
            catch (Exception)
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateBorder(((Button)sender).Name);
            }
            catch (Exception)
            {
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // object sender : gridview
        private void dgvData_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                // c1
                dgvData.ClearSelection();
                if (e.RowIndex!=-1 && e.ColumnIndex!=-1)
                {
                    if (e.Button==MouseButtons.Right)//clk right,show sth
                    {
                        //c2
                        dgvData.Rows[e.RowIndex].Selected = true;
                        //b2 
                        //var accommodationID = int.Parse(dgvData.Rows[e.RowIndex].Cells["AccomodationID"].Value.ToString());
                        //MessageBox.Show(accommodationID.ToString());
                         ID  = int.Parse(dgvData.Rows[e.RowIndex].Cells[0].Value.ToString());
                        //b1 click following to screen 
                        var relativePosition = dgvData.PointToClient(Cursor.Position);
                        contextMenuStrip1.Show(dgvData, relativePosition);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (ID != -1)
            {
                Customer cust = new Customer();
                var dt = cust.GetCustomerInfo(ID);
                if (dt.Rows.Count > 0)
                {
                    cust.customerID = ID;
                    cust.Firstname = dt.Rows[0]["Firstname"].ToString();
                    cust.Lastname = dt.Rows[0]["LastName"].ToString();
                    cust.Gender = dt.Rows[0]["Gender"].ToString();
                    cust.Email = dt.Rows[0]["Email"].ToString();
                    cust.Password = dt.Rows[0]["Password"].ToString();
                    cust.Address = dt.Rows[0]["Address"].ToString();
             }

                EditCustForm Form = new EditCustForm((Customer)person, cust, "edit");
                Form.Show();
            }
            try
            {
                if (ID==-1)//b2 id=-1 : do nothig => ret eger varsa...
                {
                    return;
                }
                if (lblTitle.Text.ToLower().Contains("customer"))
                {
                    //accommodation.obj.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
  MessageBox.Show("Your click edit");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var acc = new accommodation();
            acc.Accommodation_selection = "Test";
            acc.Details_accommodation = "Test Detail";
            acc.Operation="Test Operation";
            acc.Price = 100;
            acc.Period = 1;
            acc.OwnerID = 4;
            acc.CustomerID = 1;

            acc.AccommodationAdd(acc);
            dgvData.DataSource = acc.GetAccInfo(0);
        }

        private void BtnAddAcc_Click(object sender, EventArgs e)
        {
            //person owner = new person();
            //owner
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Customer o = (Customer)person;
            BindAccData(o);
        }
        private void listView2_load(object sender, EventArgs e)
        {
            Customer o = (Customer)person;
            BindAccData(o);
        }
        private void BindAccData(Customer o)
        {
            dgvData.DataSource = new Customer().GetCustomerInfo(o.CustomerID);
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    
    }

}
