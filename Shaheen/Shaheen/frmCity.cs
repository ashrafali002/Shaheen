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
    public partial class frmCity : BaseForm
    {
        public CityBLL cityBll;
        private int city_id = 0;

        public frmCity()
        {
            InitializeComponent();
            cityBll = new CityBLL();
        }

        private void frmCity_Load(object sender, EventArgs e)
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
            city_id = 0;
            txtCity.Text = string.Empty;
            ddlDistrict.SelectedIndex = 0;
        }

        private void BindDropdownLists()
        {
            var districtBll = new DistrictBLL();
            var districtList = districtBll.DistrictList();
            districtList.Insert(0, new District { districtId = 0, districtName = "--- Select District ---" });
            ddlDistrict.DataSource = districtList;
            ddlDistrict.DisplayMember = "districtName";
            ddlDistrict.ValueMember = "districtId";
        }

        public void DisableEnableControls(bool isEnable)
        {
            txtCity.Enabled = isEnable;
            ddlDistrict.Enabled = isEnable;
            dgvCity.Enabled = !isEnable;
        }
        private void FillDataGridView()
        {
            dgvCity.AutoGenerateColumns = false;
            dgvCity.DataSource = cityBll.CityDistrictList();
        }

        public bool isValidated()
        {
            bool isSuccess = true;
            if (string.IsNullOrEmpty(txtCity.Text))
            {
                MessageBox.Show("City name is required", "Shaheen Weekly", MessageBoxButtons.OK);
                txtCity.Focus();
                isSuccess = false;
            }
            else if (cityBll.IsDuplicateCityName(city_id, txtCity.Text))
            {
                MessageBox.Show("Duplicate record found", "Shaheen Weekly", MessageBoxButtons.OK);
                txtCity.Focus();
                isSuccess = false;
            }
            else if (ddlDistrict.SelectedIndex <= 0)
            {
                MessageBox.Show("Select district", "Shaheen Weekly", MessageBoxButtons.OK);
                ddlDistrict.Focus();
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
                var city = new City();
                city.cityId= city_id;
                city.cityName= txtCity.Text;
                city.districtId= Convert.ToInt32(ddlDistrict.SelectedValue);
                int res = cityBll.SaveCity(city);
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
                frmMain.isCity = false;
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

        private void dgvCity_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow grdRow = dgvCity.Rows[rowIndex];
            city_id = Convert.ToInt32(grdRow.Cells["cityId"].Value);
            ddlDistrict.SelectedValue = grdRow.Cells["districtId"].Value;
            txtCity.Text = Convert.ToString(grdRow.Cells["colCityName"].Value);
            btnNew.Text = "Edit";
            btnClose.Text = "Cancel";
        }

        private void dgvCity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            if (dgvCity.Columns[columnIndex] is DataGridViewButtonColumn && rowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure want to delete ?", "Ishtiraq - Shaheen Weekly", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    city_id = Convert.ToInt32(dgvCity.Rows[rowIndex].Cells["districtId"].Value);
                    cityBll.DeleteCity(city_id);
                    FillDataGridView();
                    ClearControls();
                }
            }
        }
    }
}
