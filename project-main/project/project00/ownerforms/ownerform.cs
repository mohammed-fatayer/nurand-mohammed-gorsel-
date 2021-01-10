using project00.Models;
using System;
using System.Windows.Forms;


namespace project00
{
    public partial class ownerform : Form
    {
        Person person = null;
        int ID = -1;
        public ownerform(Person p)
        {
            InitializeComponent();
            person = p;
        }



        private void ownerform_Load(object sender, EventArgs e)
        {
            if (person != null)
            {
                label1.Text = "Hello " + person.Firstname;
                owner o = (owner)person;
                BindAccData(o);
                label3.Text = o.OwnerID.ToString();
                 

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loginform lnform = new loginform();
            lnform.Show();
            this.Hide();

        }



        private void listView2_load(object sender, EventArgs e)
        {
            owner o = (owner)person;
            BindAccData(o);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            owner o = (owner)person;
            BindAccData(o);
        }

        private void BindAccData(owner o)
        {
            dataGridView1.DataSource = new accommodation().GetAccInfo(o.OwnerID);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            offerform of = new offerform();
            of.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            messageform mform = new messageform();
            mform.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            owner o = (owner)person;
            owner obj = new owner();
            AddAccForm aForm = new AddAccForm(o, null, "add"); //e5
            aForm.Show();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            owner o = (owner)person;
            BindAccData(o);
        }

        private void dgvData_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                // c1
                dataGridView1.ClearSelection();
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    if (e.Button == MouseButtons.Right)//clk right,show sth
                    {
                        //c2
                        dataGridView1.Rows[e.RowIndex].Selected = true;
                        //b2 
                        //var accommodationID = int.Parse(dgvData.Rows[e.RowIndex].Cells["AccomodationID"].Value.ToString());
                        //MessageBox.Show(accommodationID.ToString());
                        ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                        //b1 click following to screen 
                        var relativePosition = dataGridView1.PointToClient(Cursor.Position);
                        contextMenuStrip1.Show(dataGridView1, relativePosition);
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
                accommodation acc = new accommodation();
                var dt = acc.GetAccByID(ID);
                if (dt.Rows.Count > 0)
                {
                    acc.AccommodationID = ID;
                    acc.Operation = dt.Rows[0]["Operation"].ToString();
                    acc.Details_accommodation = dt.Rows[0]["Details"].ToString();
                    acc.Accommodation_selection = dt.Rows[0]["Accommodation selection"].ToString();
                    //acc.LocationID = Convert.ToInt32( dt.Rows[0]["LocationID"]);
                    acc.Price = Convert.ToInt32(dt.Rows[0]["Price"]);
                    acc.Period = Convert.ToInt32(dt.Rows[0]["Period"]);
                }

                AddAccForm accForm = new AddAccForm((owner)person, acc, "edit");
                accForm.Show();
            }
        }

       
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID == -1)
                {
                    return;
                }

               
                    var dresult = MessageBox.Show("Are you sure?", "System Message", MessageBoxButtons.YesNo);

                    if (dresult == DialogResult.Yes)
                    {
                        accommodation obj = new accommodation();
                        var result = obj.AccommodationDelete(ID);
                        if (result > 0)
                        {
                            MessageBox.Show("Accommodation Deleted.");

                            //      dgvData.DataSource = obj.GetAccInfo();
                        }
                    }
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

  
    private void button4_Click(object sender, EventArgs e)
        {
            if (ID == -1)
            {
                return;
            }
            accommodation a = new accommodation();
            a.AccommodationDelete(ID);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            advertisment ad = new advertisment();
            ad.Show();
            
         
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }


}
