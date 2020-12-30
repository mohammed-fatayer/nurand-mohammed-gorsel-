using project00.Models;
using System;
using System.Windows.Forms;


namespace project00
{
    public partial class ownerform : Form
    {
        Person person = null;
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
            owner obj = new owner();
            dataGridView1.DataSource = obj.GetownerInfo(o.OwnerID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            owner o = (owner)person;
            owner obj = new owner();
            dataGridView1.DataSource = obj.GetownerInfo(o.OwnerID);
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
    }


}
