using Shaheen.BLL;
using Shaheen.ShaheenDB;
using System;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmState : BaseForm
    {
        public StateBLL stateBll;
        private int state_id = 0;
        public frmState()
        {
            InitializeComponent();            
            stateBll = new StateBLL();
        }

        private void frmState_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            BindDropdownLists();
            DisableEnableControls(false);
            btnNew.Text = "New";
            btnClose.Text = "Close";
            btnNew.Enabled = true;
            btnSave.Enabled = false;
        }

        public void ClearControls()
        {
            state_id = 0;
            txtState.Text = string.Empty;
            cmbCountryName.SelectedIndex = 0;
        }

        private void BindDropdownLists()
        {
            var countryBll = new CountryBLL();
            var countryList = countryBll.CountryList();
            countryList.Insert(0, new Country { countryId = 0, countryName = "--- Select Country ---" });
            cmbCountryName.DataSource = countryList;
            cmbCountryName.DisplayMember = "countryName";
            cmbCountryName.ValueMember = "countryId";
        }

        public void DisableEnableControls(bool isEnable)
        {
            txtState.Enabled = isEnable;
            cmbCountryName.Enabled = isEnable;
        }

        private void FillDataGridView()
        {
            dgvState.AutoGenerateColumns = false;
            stateBll = new StateBLL();
            dgvState.DataSource = stateBll.StateCountryList();            
        }

        public bool isValidated()
        {
            bool isSuccess = true;
            if (string.IsNullOrEmpty(txtState.Text))
            {
                MessageBox.Show("State name is required", "Shaheen Weekly", MessageBoxButtons.OK);
                txtState.Focus();
                isSuccess = false;
            }
            else if (stateBll.IsDuplicateStateName(state_id, txtState.Text))
            {
                MessageBox.Show("Duplicate record found", "Shaheen Weekly", MessageBoxButtons.OK);
                txtState.Focus();
                isSuccess = false;
            }
            else if (cmbCountryName.SelectedIndex <= 0)
            {
                MessageBox.Show("Select country", "Shaheen Weekly", MessageBoxButtons.OK);
                cmbCountryName.Focus();
                isSuccess = false;
            }
            else
            {
                isSuccess = true;
            }

            return isSuccess;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DisableEnableControls(true);
            btnClose.Text = "Cancel";
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            dgvState.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isValidated())
            {
                return;
            }
            else
            {
                var state = new State();
                state.stateId = state_id;
                state.stateName = txtState.Text;
                state.countryId = Convert.ToInt32(cmbCountryName.SelectedValue);
                int res = stateBll.SaveState(state);
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
                    dgvState.Enabled = true;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "Close")
            {
                this.Close();
                MDIMain.isState = false;
                frmMain.isState = false;
            }
            else
            {
                DisableEnableControls(false);
                btnClose.Text = "Close";
                ClearControls();
                btnNew.Enabled = true;
                btnSave.Enabled = false;
                btnNew.Text = "New";
                dgvState.Enabled = true;
            }
        }

        private void dgvState_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow grdRow = dgvState.Rows[rowIndex];
            state_id = Convert.ToInt32(grdRow.Cells["stateId"].Value);
            cmbCountryName.SelectedValue = grdRow.Cells["countryId"].Value;
            txtState.Text = Convert.ToString(grdRow.Cells["colStateName"].Value);
            btnNew.Text = "Edit";
            btnClose.Text = "Cancel";
        }

        private void dgvState_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            if (dgvState.Columns[columnIndex] is DataGridViewButtonColumn && rowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure want to delete ?", "Ishtiraq - Shaheen Weekly", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    state_id = Convert.ToInt32(dgvState.Rows[rowIndex].Cells["stateId"].Value);
                    stateBll.DeleteState(state_id);
                    FillDataGridView();
                    ClearControls();
                }
            }
        }
    }
}
