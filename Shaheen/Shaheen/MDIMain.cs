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

        public static bool isDashboard = false;

        private void mnuCustomer_Click(object sender, EventArgs e)
        {
            ShowCustomerPage();
        }

        private void MDIMain_Load(object sender, EventArgs e)
        {
        }

        public void ShowCustomerPage()
        {
            if (!isCustomer)
            {
                customer = new frmCustomer();
                customer.MdiParent = this;
                customer.Show();
                customer.Focus();
                isCustomer = true;
            }
            else
            {
                foreach (Form frm in MdiChildren)
                {
                    if (frm.GetType().Name == "frmCustomer")
                    {
                        customer.MdiParent = this;
                        customer.Show();
                        customer.Focus();
                        isCustomer = true;
                    }
                }
            }
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
