using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static bool isCustomer = false;
        public frmCustomer customer = null;

        public static bool isCountry = false;
        public frmCountry country = null;

        public static bool isState = false;
        public frmState state = null;

        public static bool isDistrict = false;
        public frmDistrict district = null;

        private bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private void btnCountry_Click(object sender, EventArgs e)
        {
            if (!isCountry)
            {
                country = new frmCountry() { TopLevel = false };
                country.Location = new Point()
                {
                    X = pnlForm.Width / 2 - country.Width / 2,
                    Y = pnlForm.Height / 2 - country.Height / 2
                };
                this.pnlForm.Controls.Add(country);
                country.BringToFront();
                country.Show();
                country.Focus();
                isCountry = true;
            }
            else
            {
                if (CheckOpened("Country"))
                {
                    country.BringToFront();
                    country.Location = new Point()
                    {
                        X = pnlForm.Width / 2 - country.Width / 2,
                        Y = pnlForm.Height / 2 - country.Height / 2
                    };                    
                    country.Show();
                    country.Focus();
                    isCountry = true;
                }
            }
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            if (!isState)
            {
                state = new frmState() { TopLevel = false };
                state.Location = new Point()
                {
                    X = pnlForm.Width / 2 - state.Width / 2,
                    Y = pnlForm.Height / 2 - state.Height / 2
                };
                this.pnlForm.Controls.Add(state);
                state.BringToFront();
                state.Show();
                state.Focus();
                isState = true;
            }
            else
            {
                if (CheckOpened("State"))
                {
                    state.BringToFront();
                    state.Location = new Point()
                    {
                        X = pnlForm.Width / 2 - state.Width / 2,
                        Y = pnlForm.Height / 2 - state.Height / 2
                    };                    
                    state.Show();
                    state.Focus();
                    isState = true;
                }
            }
        }        

        private void btnSubscription_Click(object sender, EventArgs e)
        {
            if (!isCustomer)
            {
                customer = new frmCustomer() { TopLevel = false };
                customer.Location = new Point()
                {
                    X = pnlForm.Width / 2 - customer.Width / 2,
                    Y = pnlForm.Height / 2 - customer.Height / 2
                };
                this.pnlForm.Controls.Add(customer);
                customer.BringToFront();
                customer.Show();
                customer.Focus();
                isCustomer = true;
            }
            else
            {
                if (CheckOpened("Customer"))
                {
                    customer.BringToFront();
                    customer.Location = new Point()
                    {
                        X = pnlForm.Width / 2 - customer.Width / 2,
                        Y = pnlForm.Height / 2 - customer.Height / 2
                    };                    
                    customer.Show();
                    customer.Focus();
                    isCustomer = true;
                }
            }
        }

        private void btnDistrict_Click(object sender, EventArgs e)
        {
            if (!isDistrict)
            {
                district = new frmDistrict() { TopLevel = false };
                district.Location = new Point()
                {
                    X = pnlForm.Width / 2 - district.Width / 2,
                    Y = pnlForm.Height / 2 - district.Height / 2
                };
                this.pnlForm.Controls.Add(district);
                district.BringToFront();
                district.Show();
                district.Focus();
                isDistrict = true;
            }
            else
            {
                if (CheckOpened("District"))
                {
                    district.BringToFront();
                    district.Location = new Point()
                    {
                        X = pnlForm.Width / 2 - district.Width / 2,
                        Y = pnlForm.Height / 2 - district.Height / 2
                    };
                    district.Show();
                    district.Focus();
                    isDistrict = true;
                }
            }
        }
    }
}
