using Shaheen.BLL;
using Shaheen.ShaheenDB;
using System;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmDistrict : BaseForm
    {
        public DistrictBLL districtBll;
        private int district_id = 0;
        public frmDistrict()
        {
            InitializeComponent();
            districtBll = new DistrictBLL();
        }

        private void frmDistrict_Load(object sender, EventArgs e)
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
            district_id = 0;
            txtDistrictName.Text = string.Empty;
            cmbStateName.SelectedIndex = 0;
        }

        private void BindDropdownLists()
        {
            var stateBll = new StateBLL();
            var stateList = stateBll.StateList();
            stateList.Insert(0, new State { stateId = 0, stateName = "--- Select State ---" });
            cmbStateName.DataSource = stateList;
            cmbStateName.DisplayMember = "stateName";
            cmbStateName.ValueMember = "stateId";
        }
        public void DisableEnableControls(bool isEnable)
        {
            txtDistrictName.Enabled = isEnable;
            cmbStateName.Enabled = isEnable;
            dgvDistrict.Enabled = !isEnable;
        }
        private void FillDataGridView()
        {
            dgvDistrict.AutoGenerateColumns = false;
            dgvDistrict.DataSource = districtBll.DistrictStateList();
        }

        public bool isValidated()
        {
            bool isSuccess = true;
            if (string.IsNullOrEmpty(txtDistrictName.Text))
            {
                MessageBox.Show("District name is required", "Shaheen Weekly", MessageBoxButtons.OK);
                txtDistrictName.Focus();
                isSuccess = false;
            }
            else if (districtBll.IsDuplicateDistrictName(district_id, txtDistrictName.Text))
            {
                MessageBox.Show("Duplicate record found", "Shaheen Weekly", MessageBoxButtons.OK);
                txtDistrictName.Focus();
                isSuccess = false;
            }
            else if (cmbStateName.SelectedIndex <= 0)
            {
                MessageBox.Show("Select state", "Shaheen Weekly", MessageBoxButtons.OK);
                cmbStateName.Focus();
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isValidated())
            {
                return;
            }
            else
            {
                var district = new District();
                district.districtId = district_id;
                district.districtName = txtDistrictName.Text;
                district.stateId = Convert.ToInt32(cmbStateName.SelectedValue);
                int res = districtBll.SaveDistrict(district);
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
                }
            }
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
            }
        }

        private void dgvDistrict_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow grdRow = dgvDistrict.Rows[rowIndex];
            district_id = Convert.ToInt32(grdRow.Cells["districtId"].Value);
            cmbStateName.SelectedValue = grdRow.Cells["stateId"].Value;
            txtDistrictName.Text = Convert.ToString(grdRow.Cells["colDistrictName"].Value);
            btnNew.Text = "Edit";
            btnClose.Text = "Cancel";
        }

        private void dgvDistrict_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            if (dgvDistrict.Columns[columnIndex] is DataGridViewButtonColumn && rowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure want to delete ?", "Ishtiraq - Shaheen Weekly", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    district_id = Convert.ToInt32(dgvDistrict.Rows[rowIndex].Cells["districtId"].Value);
                    districtBll.DeleteDistrict(district_id);
                    FillDataGridView();
                    ClearControls();
                }
            }
        }
    }
}
