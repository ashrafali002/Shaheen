using FontAwesome.Sharp;
using Shaheen.BLL;
using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private IconButton iconButton;

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
        public frmCustomReport customReport = null;
        public frmHome home = null;
        public frmAdmin admin = null;



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
                string formName = fc[i].Name;
                if (formName != "frmMain")
                {
                    fc[i].Close();
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ActiveButton(btnHome);
            LoadHomePage();
            if (GlobalVariables.userType != 1)
            {
                btnAdmin.Visible = false;
            }
        }

        private void LoadHomePage()
        {
            CloseAllOpenForm();
            home = new frmHome() { TopLevel = false };
            home.Location = new Point()
            {
                X = pnlForm.Width / 2 - home.Width / 2,
                Y = pnlForm.Height / 2 - home.Height / 2
            };
            //home.Location = new Point(0, 0);
            this.pnlForm.Controls.Add(home);
            home.BringToFront();
            home.Show();
            home.Focus();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            LoadHomePage();
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
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
            ActiveButton(sender);
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
            ActiveButton(sender);
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
            ActiveButton(sender);
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
            ActiveButton(sender);
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
            ActiveButton(sender);
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
            ActiveButton(sender);
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
            ActiveButton(sender);
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

        private void btnLabelPrint_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            CloseAllOpenForm();
            DataTable dt = new DataTable();
            var reportBll = new ReportBLL();
            dt = reportBll.GetPersonForLablePrint();
            if (dt.Rows.Count > 0)
            {
                using (SaveFileDialog sdf = new SaveFileDialog() { Filter = "PDF File|*.pdf", ValidateNames = true })
                {
                    if (sdf.ShowDialog() == DialogResult.OK)
                    {
                        bool isGenerated = PDFGeneration.GenerateAddressLabelPDF(sdf.FileName, dt);
                        if (isGenerated)
                        {
                            MessageBox.Show("Address PDF Successfully generated", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Address PDF not generated", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            CloseAllOpenForm();
            customReport = new frmCustomReport() { TopLevel = false };
            customReport.Location = new Point()
            {
                X = pnlForm.Width / 2 - customReport.Width / 2,
                Y = pnlForm.Height / 2 - customReport.Height / 2
            };
            this.pnlForm.Controls.Add(customReport);
            customReport.BringToFront();
            customReport.Show();
            customReport.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit", "Shahee Weekly", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }


        private void btnPaymentList_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
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

        private void ActiveButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                UnActiveButton();
                iconButton = (IconButton)senderBtn;
                iconButton.BackColor = Color.FromArgb(229, 126, 49);
                iconButton.ForeColor = Color.Black;
                iconButton.IconColor = Color.Black;
            }
        }

        private void UnActiveButton()
        {
            if (iconButton != null)
            {
                iconButton.BackColor = Color.FromArgb(41, 53, 65);
                iconButton.ForeColor = Color.Gainsboro;
                iconButton.IconColor = Color.Gainsboro;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            CloseAllOpenForm();
            admin = new frmAdmin() { TopLevel = false };
            admin.Location = new Point()
            {
                X = pnlForm.Width / 2 - admin.Width / 2,
                Y = pnlForm.Height / 2 - admin.Height / 2
            };
            //subscriptionList.Location = new Point(0, 0);
            this.pnlForm.Controls.Add(admin);
            admin.BringToFront();
            admin.Show();
            admin.Focus();
        }
    }
}
