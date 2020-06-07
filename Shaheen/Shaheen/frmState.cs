using Shaheen.BLL;
using Shaheen.IshraqEntities;
using System;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmState : BaseForm
    {
        public StateBLL stateBll;
        private int state_id = 0;
        private int gridRowIndex = 0;
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
            btnNew.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            btnClose.Text = "Close";
            btnNew.Enabled = true;
            btnSave.Enabled = false;
        }

        public void ClearControls()
        {
            state_id = 0;
            txtStateName.Text = string.Empty;
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
            txtStateName.Enabled = isEnable;
            cmbCountryName.Enabled = isEnable;
        }

        private void FillDataGridView()
        {
            foreach (DataGridViewColumn aColumn in dgvState.Columns)
            {
                aColumn.HeaderCell.Style.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            dgvState.AutoGenerateColumns = false;            
            dgvState.DataSource = stateBll.StateCountryList();            
        }

        public bool isValidated()
        {
            bool isSuccess = true;
            if (string.IsNullOrEmpty(txtStateName.Text))
            {
                MessageBox.Show("State name is required", MessageText.MessageBoxCaption, MessageBoxButtons.OK);
                txtStateName.Focus();
                isSuccess = false;
            }
            else if (stateBll.IsDuplicateStateName(state_id, txtStateName.Text))
            {
                MessageBox.Show("Duplicate record found", MessageText.MessageBoxCaption, MessageBoxButtons.OK);
                txtStateName.Focus();
                isSuccess = false;
            }
            else if (cmbCountryName.SelectedIndex <= 0)
            {
                MessageBox.Show("Select country", MessageText.MessageBoxCaption, MessageBoxButtons.OK);
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
                state.stateName = txtStateName.Text;
                state.countryId = Convert.ToInt32(cmbCountryName.SelectedValue);
                int res = stateBll.SaveState(state);
                if (res > 0)
                {
                    FillDataGridView();
                    if (gridRowIndex > 0)
                    {
                        dgvState.Rows[gridRowIndex].Selected = true;
                    }
                    MessageBox.Show(MessageText.SaveMessage, MessageText.MessageBoxCaption, MessageBoxButtons.OK);
                    ClearControls();
                    DisableEnableControls(false);
                    btnNew.Text = "New";
                    btnNew.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
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
                dgvState.Enabled = true;
            }
        }

        private void dgvState_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gridRowIndex = e.RowIndex;
            DataGridViewRow grdRow = dgvState.Rows[gridRowIndex];
            state_id = Convert.ToInt32(grdRow.Cells["stateId"].Value);
            cmbCountryName.SelectedValue = grdRow.Cells["countryId"].Value;
            txtStateName.Text = Convert.ToString(grdRow.Cells["colStateName"].Value);
            btnNew.Text = "Edit";
            btnNew.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnClose.Text = "Cancel";
        }

        private void dgvState_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            if (dgvState.Columns[columnIndex] is DataGridViewImageColumn && rowIndex >= 0)
            {
                if (MessageBox.Show(MessageText.ConfirmDelete, MessageText.MessageBoxCaption, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    state_id = Convert.ToInt32(dgvState.Rows[rowIndex].Cells["stateId"].Value);
                    stateBll.DeleteState(state_id);
                    FillDataGridView();
                    ClearControls();
                }
            }
        }

        private void dgvState_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow aRow in dgvState.Rows)
            {
                aRow.Height = 30;
                aRow.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            }
        }
    }
}
