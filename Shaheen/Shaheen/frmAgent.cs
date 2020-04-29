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
    public partial class frmAgent : BaseForm
    {
        public AgentBLL agentBll;
        public int agent_id = 0;
        public frmAgent()
        {
            InitializeComponent();
            agentBll = new AgentBLL();
        }

        private void frmAgent_Load(object sender, EventArgs e)
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
            agent_id = 0;
            foreach (Control c in grpAgent.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = 0;
                }
                else
                {
                    //Contingency Plan
                }
            }
        }

        private void BindDropdownLists()
        {
            var areaBll = new AreaBLL();
            var areaList = areaBll.AreaList();
            areaList.Insert(0, new Area { areaId = 0, areaName = "---Select Area---", cityId = 0 });
            cmbArea.DataSource = areaList;
            cmbArea.DisplayMember = "areaName";
            cmbArea.ValueMember = "areaId";

            var cityBll = new CityBLL();
            var cityList = cityBll.CityList();
            cityList.Insert(0, new City { cityId = 0, cityName = "---Select City---", districtId = 0 });
            cmbCity.DataSource = cityList;
            cmbCity.DisplayMember = "cityName";
            cmbCity.ValueMember = "cityId";

            var districtBll = new DistrictBLL();
            var districtList = districtBll.DistrictList();
            districtList.Insert(0, new District { districtId = 0, districtName = "---Select District---", stateId = 0 });
            cmbDistrict.DataSource = districtList;
            cmbDistrict.DisplayMember = "districtName";
            cmbDistrict.ValueMember = "districtId";

            var stateBll = new StateBLL();
            var stateList = stateBll.StateList();
            stateList.Insert(0, new State { stateId = 0, stateName = "---Select State---", countryId = 0 });
            cmbState.DataSource = stateList;
            cmbState.DisplayMember = "stateName";
            cmbState.ValueMember = "stateId";

            var countryBll = new CountryBLL();
            var countryList = countryBll.CountryList();
            countryList.Insert(0, new Country { countryId = 0, countryName = "---Select Country---" });
            cmbCountry.DataSource = countryList;
            cmbCountry.DisplayMember = "countryName";
            cmbCountry.ValueMember = "countryId";
        }

        public void DisableEnableControls(bool isEnable)
        {
            grpAgent.Enabled = isEnable;
            dgvAgent.Enabled = !isEnable;
        }
        private void FillDataGridView()
        {
            dgvAgent.AutoGenerateColumns = false;
            dgvAgent.DataSource = agentBll.AgentFullList();
        }

        private bool isValid()
        {
            bool isRes = true;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                isRes = false;
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Address is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                isRes = false;
            }
            else if (cmbCountry.SelectedIndex <= 0)
            {
                MessageBox.Show("Country is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCountry.Focus();
                isRes = false;
            }
            else if (cmbState.SelectedIndex <= 0)
            {
                MessageBox.Show("State is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbState.Focus();
                isRes = false;
            }
            else if (cmbDistrict.SelectedIndex <= 0)
            {
                MessageBox.Show("District is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbDistrict.Focus();
                isRes = false;
            }
            else if (cmbCity.SelectedIndex <= 0)
            {
                MessageBox.Show("City is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCity.Focus();
                isRes = false;
            }
            else if (cmbArea.SelectedIndex <= 0)
            {
                MessageBox.Show("Area is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbArea.Focus();
                isRes = false;
            }
            else if (string.IsNullOrEmpty(txtPIN.Text))
            {
                MessageBox.Show("PIN is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPIN.Focus();
                isRes = false;
            }
            else if (string.IsNullOrEmpty(txtMobile.Text))
            {
                MessageBox.Show("Mobile is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMobile.Focus();
                isRes = false;
            }
            else if (!CommonFunctions.checkEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid email format.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                isRes = false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                isRes = false;
            }
            else
            {
                isRes = true;
            }
            return isRes;
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
            if (!isValid())
            {
                return;
            }
            else
            {
                var agent = new Agent();
                agent.agentId = agent_id;
                agent.agentName = txtName.Text;
                agent.agentAddress = txtAddress.Text;
                agent.countryId = Convert.ToInt32(cmbCountry.SelectedValue);
                agent.stateId = Convert.ToInt32(cmbState.SelectedValue);
                agent.districtId = Convert.ToInt32(cmbDistrict.SelectedValue);
                agent.cityId = Convert.ToInt32(cmbCity.SelectedValue);
                agent.areaId = Convert.ToInt32(cmbArea.SelectedValue);
                agent.pin = txtPIN.Text;
                agent.phone = txtPhone.Text;
                agent.mobile = txtMobile.Text;
                agent.email = txtEmail.Text;
                int res = agentBll.SaveAgent(agent);
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

        private void dgvAgent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            if (dgvAgent.Columns[columnIndex] is DataGridViewButtonColumn && rowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure want to delete ?", "Ishtiraq - Shaheen Weekly", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    agent_id = Convert.ToInt32(dgvAgent.Rows[rowIndex].Cells["agentId"].Value);
                    agentBll.DeleteAgent(agent_id);
                    FillDataGridView();
                    ClearControls();
                }
            }
        }

        private void dgvAgent_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow grdRow = dgvAgent.Rows[rowIndex];
            agent_id = Convert.ToInt32(grdRow.Cells["agentId"].Value);
            txtName.Text = Convert.ToString(grdRow.Cells["colAgentName"].Value);
            txtAddress.Text = Convert.ToString(grdRow.Cells["colAgentAddress"].Value);
            cmbCountry.SelectedValue = Convert.ToInt32(grdRow.Cells["countryId"].Value);
            cmbState.SelectedValue = Convert.ToInt32(grdRow.Cells["stateId"].Value);
            cmbDistrict.SelectedValue = Convert.ToInt32(grdRow.Cells["districtId"].Value);
            cmbCity.SelectedValue = Convert.ToInt32(grdRow.Cells["cityId"].Value);
            cmbArea.SelectedValue = Convert.ToInt32(grdRow.Cells["areaId"].Value);
            txtPIN.Text = Convert.ToString(grdRow.Cells["PIN"].Value);
            txtPhone.Text = Convert.ToString(grdRow.Cells["phone"].Value);
            txtMobile.Text = Convert.ToString(grdRow.Cells["mobile"].Value);
            txtEmail.Text = Convert.ToString(grdRow.Cells["email"].Value);
            btnNew.Text = "Edit";
            btnClose.Text = "Cancel";
        }
    }
}
