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

                if (CheckOpened("frmCountry"))
                {
                    country.Location = new Point()
                    {
                        X = pnlForm.Width / 2 - country.Width / 2,
                        Y = pnlForm.Height / 2 - country.Height / 2
                    };
                    country.BringToFront();
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
                if (CheckOpened("frmState"))
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
    }
}
