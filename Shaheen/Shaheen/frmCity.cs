using Shaheen.BLL;
using Shaheen.IshtiraqEntities;
using System;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmCity : BaseForm
    {
        public CityBLL cityBll;
        private int city_id = 0;
        public int gridRowIndex { get; set; }

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
            btnNew.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            btnClose.Text = "Close";
            btnNew.Enabled = true;
            btnSave.Enabled = false;
        }

        public void ClearControls()
        {
            city_id = 0;
            txtCityName.Text = string.Empty;
            cmbDistrictName.SelectedIndex = 0;
        }

        private void BindDropdownLists()
        {
            var districtBll = new DistrictBLL();
            var districtList = districtBll.DistrictList();
            districtList.Insert(0, new District { districtId = 0, districtName = "--- Select District ---" });
            cmbDistrictName.DataSource = districtList;
            cmbDistrictName.DisplayMember = "districtName";
            cmbDistrictName.ValueMember = "districtId";
        }

        public void DisableEnableControls(bool isEnable)
        {
            txtCityName.Enabled = isEnable;
            cmbDistrictName.Enabled = isEnable;
            dgvCity.Enabled = !isEnable;
        }
        private void FillDataGridView()
        {
            foreach (DataGridViewColumn aColumn in dgvCity.Columns)
            {
                aColumn.HeaderCell.Style.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            dgvCity.AutoGenerateColumns = false;
            dgvCity.DataSource = cityBll.CityDistrictList();
        }

        public bool isValidated()
        {
            bool isSuccess = true;
            if (string.IsNullOrEmpty(txtCityName.Text))
            {
                MessageBox.Show("City name is required", MessageText.MessageBoxCaption, MessageBoxButtons.OK);
                txtCityName.Focus();
                isSuccess = false;
            }
            else if (cityBll.IsDuplicateCityName(city_id, txtCityName.Text))
            {
                MessageBox.Show("Duplicate record found", MessageText.MessageBoxCaption, MessageBoxButtons.OK);
                txtCityName.Focus();
                isSuccess = false;
            }
            else if (cmbDistrictName.SelectedIndex <= 0)
            {
                MessageBox.Show("Select district", MessageText.MessageBoxCaption, MessageBoxButtons.OK);
                cmbDistrictName.Focus();
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
                city.cityName= txtCityName.Text;
                city.districtId= Convert.ToInt32(cmbDistrictName.SelectedValue);
                int res = cityBll.SaveCity(city);
                if (res > 0)
                {
                    FillDataGridView();
                    if (gridRowIndex > 0)
                    {
                        dgvCity.Rows[gridRowIndex].Selected = true;
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

        private void dgvCity_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gridRowIndex = e.RowIndex;
            DataGridViewRow grdRow = dgvCity.Rows[gridRowIndex];
            city_id = Convert.ToInt32(grdRow.Cells["cityId"].Value);
            cmbDistrictName.SelectedValue = grdRow.Cells["districtId"].Value;
            txtCityName.Text = Convert.ToString(grdRow.Cells["colCityName"].Value);
            btnNew.Text = "Edit";
            btnNew.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnClose.Text = "Cancel";
        }

        private void dgvCity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            if (dgvCity.Columns[columnIndex] is DataGridViewImageColumn && rowIndex >= 0)
            {
                if (MessageBox.Show(MessageText.ConfirmDelete, MessageText.MessageBoxCaption, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    city_id = Convert.ToInt32(dgvCity.Rows[rowIndex].Cells["cityId"].Value);
                    cityBll.DeleteCity(city_id);
                    FillDataGridView();
                    ClearControls();
                }
            }
        }

        private void dgvCity_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow aRow in dgvCity.Rows)
            {
                aRow.Height = 30;
                aRow.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
    }
}
