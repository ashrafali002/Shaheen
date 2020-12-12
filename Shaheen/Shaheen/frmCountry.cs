using Shaheen.BLL;
using Shaheen.IshtiraqEntities;
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
            btnNew.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            btnClose.Text = "Close";
            btnNew.Enabled = true;
            btnSave.Enabled = false;
        }

        public void ClearControls()
        {
            country_id = 0;
            txtCountryName.Text = string.Empty;
        }
        public void DisableEnableControls(bool isEnable)
        {
            txtCountryName.Enabled = isEnable;
        }

        private void FillDataGridView()
        {
            foreach (DataGridViewColumn aColumn in dgvCountry.Columns)
            {
                aColumn.HeaderCell.Style.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            var countryBll = new CountryBLL();
            dgvCountry.DataSource = countryBll.CountryList();
            dgvCountry.Columns["countryId"].Visible = false;            
        }

        private void btnClose_Click(object sender, EventArgs e)
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
                btnNew.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
                dgvCountry.Enabled = true;
            }
        }
        public bool isValidated()
        {
            bool isSuccess = true;
            if (string.IsNullOrEmpty(txtCountryName.Text))
            {
                MessageBox.Show("Country name is required", MessageText.MessageBoxCaption, MessageBoxButtons.OK);
                txtCountryName.Focus();
                isSuccess = false;
            }
            else if (countryBll.IsDuplicateCountryName(country_id, txtCountryName.Text))
            {
                MessageBox.Show("Duplicate record found", MessageText.MessageBoxCaption, MessageBoxButtons.OK);
                txtCountryName.Focus();
                isSuccess = false;
            }
            else
            {
                isSuccess = true;
            }

            return isSuccess;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isValidated())
            {
                return;
            }
            else
            {
                var country = new Country();
                country.countryId = country_id;
                country.countryName = txtCountryName.Text;
                int res = countryBll.SaveCountry(country);
                if (res > 0)
                {
                    FillDataGridView();
                    MessageBox.Show(MessageText.SaveMessage, MessageText.MessageBoxCaption, MessageBoxButtons.OK);
                    ClearControls();
                    DisableEnableControls(false);
                    btnNew.Text = "New";
                    btnNew.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
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
            txtCountryName.Text = Convert.ToString(grdRow.Cells["colCountryName"].Value);
            btnNew.Text = "Edit";
            btnNew.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnClose.Text = "Cancel";
        }

        private void dgvCountry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            if (dgvCountry.Columns[columnIndex] is DataGridViewImageColumn && rowIndex >= 0)
            {
                if (MessageBox.Show(MessageText.ConfirmDelete, MessageText.MessageBoxCaption, MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        private void dgvCountry_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow aRow in dgvCountry.Rows)
            {
                aRow.Height = 30;
                aRow.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            }
        }        
    }
}
