using Shaheen.ShaheenDB;
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

        public frmCustomer customer = null;
        public frmCountry country = null;
        public frmState state = null;
        public frmDistrict district = null;
        public frmCity city = null;
        public frmArea area = null;
        public frmSubscription subscription = null;
        public frmAgent agent = null;
        public frmSubscriptionList subscriptionList = null;
        public frmPaymentList paymentList = null;

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

        private void CloseAllOpenForm()
        {
            FormCollection fc = Application.OpenForms;
            for (int i = 0; i < fc.Count; i++)
            {
                string formName = fc[i].Text;
                if (formName != "Main")
                {
                    fc[i].Close();
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private void btnCountry_Click(object sender, EventArgs e)
        {
            CloseAllOpenForm();
            country = new frmCountry() { TopLevel = false };
            country.Location = new Point()
            {
                X = pnlForm.Width / 2 - country.Width / 2,
                Y = pnlForm.Height / 2 - country.Height / 2
            };
            //subscriptionList.Location = new Point(0, 0);
            this.pnlForm.Controls.Add(country);
            country.BringToFront();
            country.Show();
            country.Focus();

            //if (!isCountry)
            //{
            //    country = new frmCountry() { TopLevel = false };
            //    country.Location = new Point()
            //    {
            //        X = pnlForm.Width / 2 - country.Width / 2,
            //        Y = pnlForm.Height / 2 - country.Height / 2
            //    };
            //    this.pnlForm.Controls.Add(country);
            //    country.BringToFront();
            //    country.Show();
            //    country.Focus();
            //    isCountry = true;
            //}
            //else
            //{
            //    if (CheckOpened("Country"))
            //    {
            //        country.BringToFront();
            //        country.Location = new Point()
            //        {
            //            X = pnlForm.Width / 2 - country.Width / 2,
            //            Y = pnlForm.Height / 2 - country.Height / 2
            //        };
            //        country.Show();
            //        country.Focus();
            //        isCountry = true;
            //    }
            //}
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            CloseAllOpenForm();
            state = new frmState() { TopLevel = false };
            state.Location = new Point()
            {
                X = pnlForm.Width / 2 - state.Width / 2,
                Y = pnlForm.Height / 2 - state.Height / 2
            };
            //subscriptionList.Location = new Point(0, 0);
            this.pnlForm.Controls.Add(state);
            state.BringToFront();
            state.Show();
            state.Focus();
        }

        private void btnSubscription_Click(object sender, EventArgs e)
        {
            CloseAllOpenForm();

            subscription = new frmSubscription() { TopLevel = false };
            subscription.Location = new Point()
            {
                X = pnlForm.Width / 2 - subscription.Width / 2,
                Y = pnlForm.Height / 2 - subscription.Height / 2
            };
            //subscription.Location = new Point(0, 0);
            this.pnlForm.Controls.Add(subscription);
            subscription.BringToFront();
            subscription.Show();
            subscription.Focus();
        }

        private void btnDistrict_Click(object sender, EventArgs e)
        {
            CloseAllOpenForm();
            district = new frmDistrict() { TopLevel = false };
            district.Location = new Point()
            {
                X = pnlForm.Width / 2 - district.Width / 2,
                Y = pnlForm.Height / 2 - district.Height / 2
            };
            //subscriptionList.Location = new Point(0, 0);
            this.pnlForm.Controls.Add(district);
            district.BringToFront();
            district.Show();
            district.Focus();
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            CloseAllOpenForm();
            city = new frmCity() { TopLevel = false };
            city.Location = new Point()
            {
                X = pnlForm.Width / 2 - city.Width / 2,
                Y = pnlForm.Height / 2 - city.Height / 2
            };
            //subscriptionList.Location = new Point(0, 0);
            this.pnlForm.Controls.Add(city);
            city.BringToFront();
            city.Show();
            city.Focus();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            CloseAllOpenForm();
            area = new frmArea() { TopLevel = false };
            area.Location = new Point()
            {
                X = pnlForm.Width / 2 - area.Width / 2,
                Y = pnlForm.Height / 2 - area.Height / 2
            };
            //subscriptionList.Location = new Point(0, 0);
            this.pnlForm.Controls.Add(area);
            area.BringToFront();
            area.Show();
            area.Focus();
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            CloseAllOpenForm();
            agent = new frmAgent() { TopLevel = false };
            agent.Location = new Point()
            {
                X = pnlForm.Width / 2 - agent.Width / 2,
                Y = pnlForm.Height / 2 - agent.Height / 2
            };
            //subscriptionList.Location = new Point(0, 0);
            this.pnlForm.Controls.Add(agent);
            agent.BringToFront();
            agent.Show();
            agent.Focus();
        }

        private void btnSubscriptionList_Click(object sender, EventArgs e)
        {
            CloseAllOpenForm();
            subscriptionList = new frmSubscriptionList() { TopLevel = false };
            subscriptionList.Location = new Point()
            {
                X = pnlForm.Width / 2 - subscriptionList.Width / 2,
                Y = pnlForm.Height / 2 - subscriptionList.Height / 2
            };
            //subscriptionList.Location = new Point(0, 0);
            this.pnlForm.Controls.Add(subscriptionList);
            subscriptionList.BringToFront();
            subscriptionList.Show();
            subscriptionList.Focus();
        }

        private void btnPaymentList_Click(object sender, EventArgs e)
        {
            CloseAllOpenForm();
            paymentList = new frmPaymentList() { TopLevel = false };
            paymentList.Location = new Point()
            {
                X = pnlForm.Width / 2 - paymentList.Width / 2,
                Y = pnlForm.Height / 2 - paymentList.Height / 2
            };
            //subscriptionList.Location = new Point(0, 0);
            this.pnlForm.Controls.Add(paymentList);
            paymentList.BringToFront();
            paymentList.Show();
            paymentList.Focus();
        }

        private void btnLabelPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
