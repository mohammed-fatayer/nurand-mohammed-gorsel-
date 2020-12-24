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
    public partial class ownerform : Form
    {
        public ownerform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginform lnform = new loginform();
            lnform.Show();
            this.Hide();
        }
    }
}
