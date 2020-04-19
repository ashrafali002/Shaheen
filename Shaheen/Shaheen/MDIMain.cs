using System;
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

        public static bool isCountry = false;
        public frmCountry country = null;

        public static bool isState = false;
        public frmState state = null;

        public static bool isDashboard = false;

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
        private void MnuCountry_Click(object sender, EventArgs e)
        {
            if (!isCountry)
            {
                country = new frmCountry();
                country.MdiParent = this;
                country.Show();
                country.Focus();
                isCountry = true;
            }
            else
            {
                foreach (Form frm in MdiChildren)
                {
                    if (frm.GetType().Name == "frmCountry")
                    {
                        country.MdiParent = this;
                        country.Show();
                        country.Focus();
                        isCountry = true;
                    }
                }
            }
        }

        private void MDIMain_Load(object sender, EventArgs e)
        {
        }


        private void MnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuState_Click(object sender, EventArgs e)
        {
            if (!isState)
            {
                state = new frmState();
                state.MdiParent = this;
                state.Show();
                state.Focus();
                isState = true;
            }
            else
            {
                foreach (Form frm in MdiChildren)
                {
                    if (frm.GetType().Name == "frmState")
                    {
                        state.MdiParent = this;
                        state.Show();
                        state.Focus();
                        isState = true;
                    }
                }
            }
        }
    }
}
