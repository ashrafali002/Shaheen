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
    public partial class frmArea : BaseForm
    {
        public AreaBLL areaBll;
        public int area_id = 0;
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
            dgvArea.AutoGenerateColumns = false;
            dgvArea.DataSource = areaBll.AreaCityList();
        }

        public bool isValidated()
        {
            bool isSuccess = true;
            if (string.IsNullOrEmpty(txtAreaName.Text))
            {
                MessageBox.Show("Area name is required", "Shaheen Weekly", MessageBoxButtons.OK);
                txtAreaName.Focus();
                isSuccess = false;
            }
            else if (areaBll.IsDuplicateAreaName(area_id, txtAreaName.Text))
            {
                MessageBox.Show("Duplicate record found", "Shaheen Weekly", MessageBoxButtons.OK);
                txtAreaName.Focus();
                isSuccess = false;
            }
            else if (cmbCityName.SelectedIndex <= 0)
            {
                MessageBox.Show("Select city", "Shaheen Weekly", MessageBoxButtons.OK);
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
                area.areaName= txtAreaName.Text;
                area.cityId= Convert.ToInt32(cmbCityName.SelectedValue);
                int res = areaBll.SaveArea(area);
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
                frmMain.isArea = false;
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

        private void dgvArea_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow grdRow = dgvArea.Rows[rowIndex];
            area_id = Convert.ToInt32(grdRow.Cells["areaId"].Value);
            cmbCityName.SelectedValue = grdRow.Cells["cityId"].Value;
            txtAreaName.Text = Convert.ToString(grdRow.Cells["colAreaName"].Value);
            btnNew.Text = "Edit";
            btnClose.Text = "Cancel";
        }

        private void dgvArea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            if (dgvArea.Columns[columnIndex] is DataGridViewButtonColumn && rowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure want to delete ?", "Ishtiraq - Shaheen Weekly", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    area_id= Convert.ToInt32(dgvArea.Rows[rowIndex].Cells["areaId"].Value);
                    areaBll.DeleteArea(area_id);
                    FillDataGridView();
                    ClearControls();
                }
            }
        }
    }
}
