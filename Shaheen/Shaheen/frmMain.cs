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

        public static bool isCity = false;
        public frmCity city = null;

        public static bool isArea = false;
        public frmArea area = null;

        public static bool isSubscription = false;
        public frmSubscription subscription = null;

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
            if (!isSubscription)
            {
                subscription = new frmSubscription() { TopLevel = false };
                subscription.Location = new Point()
                {
                    X = pnlForm.Width / 2 - subscription.Width / 2,
                    Y = pnlForm.Height / 2 - subscription.Height / 2
                };
                this.pnlForm.Controls.Add(subscription);
                subscription.BringToFront();
                subscription.Show();
                subscription.Focus();
                isSubscription = true;
            }
            else
            {
                if (CheckOpened("Subscription"))
                {
                    subscription.BringToFront();
                    subscription.Location = new Point()
                    {
                        X = pnlForm.Width / 2 - subscription.Width / 2,
                        Y = pnlForm.Height / 2 - subscription.Height / 2
                    };
                    subscription.Show();
                    subscription.Focus();
                    isSubscription = true;
                }
            }
            //if (!isCustomer)
            //{
            //    customer = new frmCustomer() { TopLevel = false };
            //    customer.Location = new Point()
            //    {
            //        X = pnlForm.Width / 2 - customer.Width / 2,
            //        Y = pnlForm.Height / 2 - customer.Height / 2
            //    };
            //    this.pnlForm.Controls.Add(customer);
            //    customer.BringToFront();
            //    customer.Show();
            //    customer.Focus();
            //    isCustomer = true;
            //}
            //else
            //{
            //    if (CheckOpened("Customer"))
            //    {
            //        customer.BringToFront();
            //        customer.Location = new Point()
            //        {
            //            X = pnlForm.Width / 2 - customer.Width / 2,
            //            Y = pnlForm.Height / 2 - customer.Height / 2
            //        };
            //        customer.Show();
            //        customer.Focus();
            //        isCustomer = true;
            //    }
            //}
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

        private void btnCity_Click(object sender, EventArgs e)
        {
            if (!isCity)
            {
                city = new frmCity() { TopLevel = false };
                city.Location = new Point()
                {
                    X = pnlForm.Width / 2 - city.Width / 2,
                    Y = pnlForm.Height / 2 - city.Height / 2
                };
                this.pnlForm.Controls.Add(city);
                city.BringToFront();
                city.Show();
                city.Focus();
                isCity = true;
            }
            else
            {
                if (CheckOpened("City"))
                {
                    city.BringToFront();
                    city.Location = new Point()
                    {
                        X = pnlForm.Width / 2 - city.Width / 2,
                        Y = pnlForm.Height / 2 - city.Height / 2
                    };
                    city.Show();
                    city.Focus();
                    isCity = true;
                }
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            if (!isArea)
            {
                area = new frmArea() { TopLevel = false };
                area.Location = new Point()
                {
                    X = pnlForm.Width / 2 - area.Width / 2,
                    Y = pnlForm.Height / 2 - area.Height / 2
                };
                this.pnlForm.Controls.Add(area);
                area.BringToFront();
                area.Show();
                area.Focus();
                isArea = true;
            }
            else
            {
                if (CheckOpened("Area"))
                {
                    area.BringToFront();
                    area.Location = new Point()
                    {
                        X = pnlForm.Width / 2 - area.Width / 2,
                        Y = pnlForm.Height / 2 - area.Height / 2
                    };
                    area.Show();
                    area.Focus();
                    isArea = true;
                }
            }
        }
    }
}
