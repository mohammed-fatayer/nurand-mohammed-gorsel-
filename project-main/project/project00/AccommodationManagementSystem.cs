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
            if(person != null)            
            {
                Customer cust = (Customer)person;
                Customer obj = new Customer();
                dgvData.DataSource = obj.GetCustomerInfo(cust.CustomerID);
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (person != null)
            {
                Customer cust = (Customer)person;
                Customer obj = new Customer();
                dgvData.DataSource = obj.GetCustomerInfo(cust.CustomerID);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
