using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class MDIMain : Form
    {
        public MDIMain()
        {
            InitializeComponent();
        }

        public static bool isCustomer = false;
        public frmCustomer customer = null;

        private void mnuCustomer_Click(object sender, EventArgs e)
        {
            if (!isCustomer)
            {
                customer = new frmCustomer();
                customer.MdiParent = this;
                customer.Show();
                customer.Focus();
                isCustomer = true;
            }
            
        }

        private void MDIMain_Load(object sender, EventArgs e)
        {

        }
    }
}
