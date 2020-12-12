using Shaheen.BLL;
using Shaheen.IshtiraqEntities;
using System;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmArea : BaseForm
    {
        public AreaBLL areaBll;
        public int area_id = 0;
        public int gridRowIndex { get; set; }
        public frmArea()
        {
            InitializeComponent();
            areaBll = new AreaBLL();
        }

        private void frmArea_Load(object sender, EventArgs e)
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
            area_id = 0;
            txtAreaName.Text = string.Empty;
            cmbCityName.SelectedIndex = 0;
        }

        private void BindDropdownLists()
        {
            var cityBll = new CityBLL();
            var cityList = cityBll.CityList();
            cityList.Insert(0, new City { cityId = 0, cityName = "--- Select City ---" });
            cmbCityName.DataSource = cityList;
            cmbCityName.DisplayMember = "cityName";
            cmbCityName.ValueMember = "cityId";
        }
        public void DisableEnableControls(bool isEnable)
        {
            txtAreaName.Enabled = isEnable;
            cmbCityName.Enabled = isEnable;
            dgvArea.Enabled = !isEnable;
        }
        private void FillDataGridView()
        {
            foreach (DataGridViewColumn aColumn in dgvArea.Columns)
            {
                aColumn.HeaderCell.Style.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            dgvArea.AutoGenerateColumns = false;
            dgvArea.DataSource = areaBll.AreaCityList();
        }

        public bool isValidated()
        {
            bool isSuccess = true;
            if (string.IsNullOrEmpty(txtAreaName.Text))
            {
                MessageBox.Show("Area name is required", MessageText.MessageBoxCaption, MessageBoxButtons.OK);
                txtAreaName.Focus();
                isSuccess = false;
            }
            else if (areaBll.IsDuplicateAreaName(area_id, txtAreaName.Text))
            {
                MessageBox.Show("Duplicate record found", MessageText.MessageBoxCaption, MessageBoxButtons.OK);
                txtAreaName.Focus();
                isSuccess = false;
            }
            else if (cmbCityName.SelectedIndex <= 0)
            {
                MessageBox.Show("Select city", MessageText.MessageBoxCaption, MessageBoxButtons.OK);
                cmbCityName.Focus();
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
                var area = new Area();
                area.areaId = area_id;
                area.areaName = txtAreaName.Text;
                area.cityId = Convert.ToInt32(cmbCityName.SelectedValue);
                int res = areaBll.SaveArea(area);
                if (res > 0)
                {
                    FillDataGridView();
                    if (gridRowIndex > 0)
                    {
                        dgvArea.Rows[gridRowIndex].Selected = true;
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

        private void dgvArea_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gridRowIndex = e.RowIndex;
            DataGridViewRow grdRow = dgvArea.Rows[gridRowIndex];
            area_id = Convert.ToInt32(grdRow.Cells["areaId"].Value);
            cmbCityName.SelectedValue = grdRow.Cells["cityId"].Value;
            txtAreaName.Text = Convert.ToString(grdRow.Cells["colAreaName"].Value);
            btnNew.Text = "Edit";
            btnNew.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnClose.Text = "Cancel";
        }

        private void dgvArea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            if (dgvArea.Columns[columnIndex] is DataGridViewImageColumn && rowIndex >= 0)
            {
                if (MessageBox.Show(MessageText.ConfirmDelete, MessageText.MessageBoxCaption, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    area_id = Convert.ToInt32(dgvArea.Rows[rowIndex].Cells["areaId"].Value);
                    areaBll.DeleteArea(area_id);
                    FillDataGridView();
                    ClearControls();
                }
            }
        }

        private void dgvArea_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow aRow in dgvArea.Rows)
            {
                aRow.Height = 30;
                aRow.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
    }
}
