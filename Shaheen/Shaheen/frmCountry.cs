using Shaheen.BLL;
using Shaheen.ShaheenDB;
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
    public partial class frmCountry : BaseForm
    {
        public frmCountry()
        {
            InitializeComponent();
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            var countryBll = new CountryBLL();
            dgvCountry.DataSource = countryBll.CountryList();
            dgvCountry.Columns["countryId"].Visible = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            MDIMain.isCountry = false;
        }
                
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCountry.Text))
            {
                MessageBox.Show("Enter country name", "Shaheen Weekly", MessageBoxButtons.OK);
                txtCountry.Focus();
            }
            else
            {
                var country = new Country();
                country.countryName = txtCountry.Text;
                
            }
        }
    }


}
