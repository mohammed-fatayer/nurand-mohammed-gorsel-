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
    public partial class FormEditCustomer : Form
    {

        int customerID = -1; //u2 
        public FormEditCustomer(int cID) //u1
        {
            InitializeComponent();
        }

        //u3 to show the inf of ID from DS by using Load event
        private void FormEditCustomer_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
