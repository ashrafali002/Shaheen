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
        public CountryBLL countryBll;
        private int country_id = 0;
        public frmCountry()
        {
            InitializeComponent();
            FillDataGridView();
            countryBll = new CountryBLL();
        }

        public void ClearField()
        {
            country_id = 0;
            txtCountry.Text = string.Empty;
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
        public bool isValidated()
        {
            bool isSuccess = true;
            if (string.IsNullOrEmpty(txtCountry.Text))
            {
                MessageBox.Show("Country name is required", "Shaheen Weekly", MessageBoxButtons.OK);
                txtCountry.Focus();
                isSuccess = false;
            }
            else if (countryBll.IsDuplicateCountryName(country_id, txtCountry.Text))
            {
                MessageBox.Show("Duplicate record found", "Shaheen Weekly", MessageBoxButtons.OK);
                txtCountry.Focus();
                isSuccess = false;
            }
            else
            {
                isSuccess = true;
            }

            return isSuccess;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!isValidated())
            {
                return;
            }
            else
            {
                var country = new Country();
                country.countryId = country_id;
                country.countryName = txtCountry.Text;
                int res = countryBll.SaveCountry(country);
                if (res > 0)
                {
                    FillDataGridView();
                    MessageBox.Show("Record saved successfully", "Shaheen Weekly", MessageBoxButtons.OK);                    
                    ClearField();
                }

            }
        }

        private void dgvCountry_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow grdRow = dgvCountry.Rows[rowIndex];
            country_id= Convert.ToInt32(grdRow.Cells["countryId"].Value);
            txtCountry.Text = Convert.ToString(grdRow.Cells["colCountryName"].Value);
        }

        private void dgvCountry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            if (dgvCountry.Columns[columnIndex] is DataGridViewButtonColumn && rowIndex >= 0)
            { 
                
            }
        }

    }
}
