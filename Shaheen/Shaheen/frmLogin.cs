using Shaheen.BLL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmLogin : BaseForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            ClearControls();
        }

        private void ClearControls()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            lblError.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {            
            if (isValidation())
            {
                var loginBll = new LoginBLL();
                DataRow[] drArray = loginBll.LoginTable(txtUsername.Text, txtPassword.Text);
                if (drArray.Length > 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    lblError.Text = "Invalid username or password";
                }
            }
        }
        private bool isValidation()
        {
            bool isValided = true;
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                lblError.Text = "Username is required";
                pnlUsername.BackColor = Color.Red;
                txtUsername.Focus();
                isValided = false;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblError.Text = "Password is required";
                pnlPassword.BackColor = Color.Red;
                txtPassword.Focus();
                isValided = false;
            }
            else
            {
                isValided = true;
            }
            return isValided;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                pnlUsername.BackColor = Color.Red;
            }
            else
            {
                pnlUsername.BackColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            pnlUsername.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                pnlUsername.BackColor = Color.Red;
            }
            else
            {
                pnlUsername.BackColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            pnlPassword.BackColor = Color.FromArgb(64, 64, 64);
        }
    }
}
