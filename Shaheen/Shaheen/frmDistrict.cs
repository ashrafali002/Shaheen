﻿using Shaheen.BLL;
using Shaheen.IshraqEntities;
using System;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmDistrict : BaseForm
    {
        public DistrictBLL districtBll;
        private int district_id = 0;
        public int gridRowIndex { get; set; }
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
            btnNew.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
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
            foreach (DataGridViewColumn aColumn in dgvDistrict.Columns)
            {
                aColumn.HeaderCell.Style.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            dgvDistrict.AutoGenerateColumns = false;
            dgvDistrict.DataSource = districtBll.DistrictStateList();
        }

        public bool isValidated()
        {
            bool isSuccess = true;
            if (string.IsNullOrEmpty(txtDistrictName.Text))
            {
                MessageBox.Show("District name is required", MessageText.MessageBoxCaption, MessageBoxButtons.OK);
                txtDistrictName.Focus();
                isSuccess = false;
            }
            else if (districtBll.IsDuplicateDistrictName(district_id, txtDistrictName.Text))
            {
                MessageBox.Show("Duplicate record found", MessageText.MessageBoxCaption, MessageBoxButtons.OK);
                txtDistrictName.Focus();
                isSuccess = false;
            }
            else if (cmbStateName.SelectedIndex <= 0)
            {
                MessageBox.Show("Select state", MessageText.MessageBoxCaption, MessageBoxButtons.OK);
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
                    if (gridRowIndex > 0)
                    {
                        dgvDistrict.Rows[gridRowIndex].Selected = true;
                    }
                    MessageBox.Show(MessageText.SaveMessage, MessageText.MessageBoxCaption, MessageBoxButtons.OK);
                    ClearControls();
                    DisableEnableControls(false);
                    btnNew.Text = "New";
                    btnNew.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
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
                btnNew.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            }
        }

        private void dgvDistrict_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gridRowIndex = e.RowIndex;
            DataGridViewRow grdRow = dgvDistrict.Rows[gridRowIndex];
            district_id = Convert.ToInt32(grdRow.Cells["districtId"].Value);
            cmbStateName.SelectedValue = grdRow.Cells["stateId"].Value;
            txtDistrictName.Text = Convert.ToString(grdRow.Cells["colDistrictName"].Value);
            btnNew.Text = "Edit";
            btnNew.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnClose.Text = "Cancel";
        }

        private void dgvDistrict_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            if (dgvDistrict.Columns[columnIndex] is DataGridViewImageColumn && rowIndex >= 0)
            {
                if (MessageBox.Show(MessageText.ConfirmDelete, MessageText.MessageBoxCaption, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    district_id = Convert.ToInt32(dgvDistrict.Rows[rowIndex].Cells["districtId"].Value);
                    districtBll.DeleteDistrict(district_id);
                    FillDataGridView();
                    ClearControls();
                }
            }
        }

        private void dgvDistrict_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow aRow in dgvDistrict.Rows)
            {
                aRow.Height = 30;
                aRow.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
    }
}
