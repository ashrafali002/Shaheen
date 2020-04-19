using System;
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
            this.txtUsername.MinimumSize = new System.Drawing.Size(226, 30);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }
        private bool isValidation()
        {
            bool isValided = true;
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Username is required");
                isValided = false;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password is required");
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
    }
}
