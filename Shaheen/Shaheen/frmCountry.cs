using Shaheen.BLL;
using Shaheen.ShaheenDB;
using System;
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

        private void frmCountry_Load(object sender, EventArgs e)
        {
            DisableEnableControls(false);
            btnNew.Text = "New";
            btnClose.Text = "Close";
            btnNew.Enabled = true;
            btnSave.Enabled = false;
        }

        public void ClearControls()
        {
            country_id = 0;
            txtCountry.Text = string.Empty;
        }
        public void DisableEnableControls(bool isEnable)
        {
            txtCountry.Enabled = isEnable;
        }

        private void FillDataGridView()
        {
            var countryBll = new CountryBLL();
            dgvCountry.DataSource = countryBll.CountryList();
            dgvCountry.Columns["countryId"].Visible = false;
            //dgvCountry.ColumnHeadersDefaultCellStyle.BackColor = "";
            //dgvCountry.EnableHeadersVisualStyles = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "Close")
            {
                this.Close();
            }
            else
            {
                DisableEnableControls(false);
                btnClose.Text = "Close";
                ClearControls();
                btnNew.Enabled = true;
                btnSave.Enabled = false;
                btnNew.Text = "New";
                dgvCountry.Enabled = true;
            }
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
                    ClearControls();
                    DisableEnableControls(false);
                    btnNew.Text = "New";
                    btnSave.Enabled = false;
                    btnNew.Enabled = true;
                    btnClose.Text = "Close";
                    dgvCountry.Enabled = true;
                }
            }
        }

        private void dgvCountry_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow grdRow = dgvCountry.Rows[rowIndex];
            country_id = Convert.ToInt32(grdRow.Cells["countryId"].Value);
            txtCountry.Text = Convert.ToString(grdRow.Cells["colCountryName"].Value);
            btnNew.Text = "Edit";
            btnClose.Text = "Cancel";
        }

        private void dgvCountry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            if (dgvCountry.Columns[columnIndex] is DataGridViewButtonColumn && rowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure want to delete ?", "Ishtiraq - Shaheen Weekly", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    country_id = Convert.ToInt32(dgvCountry.Rows[rowIndex].Cells["countryId"].Value);
                    countryBll.DeleteCountry(country_id);
                    FillDataGridView();
                    ClearControls();
                }
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DisableEnableControls(true);
            btnClose.Text = "Cancel";
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            dgvCountry.Enabled = false;
        }
    }
}
