using Microsoft.SqlServer.Server;
using Shaheen.BLL;
using Shaheen.IshtiraqEntities;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmCustomReport : BaseForm
    {
        public frmCustomReport()
        {
            InitializeComponent();
        }

        public DataTable SearchResult { get; set; }

        public void FillDataGridView()
        {
            foreach (DataGridViewColumn aColumn in dgvCustomReport.Columns)
            {
                aColumn.HeaderCell.Style.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            dgvCustomReport.AutoGenerateColumns = false;
            dgvCustomReport.DataSource = SearchResult;
            dgvCustomReport.Columns["subscriptionEndDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvCustomReport.Columns["pendingAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCustomReport.Columns["pendingAmount"].DefaultCellStyle.Format = "C2";
        }

        private void frmCustomReport_Load(object sender, EventArgs e)
        {
            BindDropdownlists();
            ClearControls();
            FillDataGridView();
        }

        private void BindDropdownlists()
        {
            var agentBll = new AgentBLL();
            var agentList = agentBll.AgentList();
            agentList.Insert(0, new Agent { agentId = 0, agentName = "---Select Agent---" });
            cmbAgent.DataSource = agentList;
            cmbAgent.DisplayMember = "agentName";
            cmbAgent.ValueMember = "agentId";

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
            cmbState.ItemHeight = 30;

            var countryBll = new CountryBLL();
            var countryList = countryBll.CountryList();
            countryList.Insert(0, new Country { countryId = 0, countryName = "---Select Country---" });
            cmbCountry.DataSource = countryList;
            cmbCountry.DisplayMember = "countryName";
            cmbCountry.ValueMember = "countryId";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string whereCondition = string.Empty;
            if (cmbAgent.SelectedIndex <= 0)
            {
                MessageBox.Show("Select agent first", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbAgent.Focus();
                return;
            }
            if (cmbCountry.SelectedIndex > 0)
            {
                whereCondition += " AND P.countryId = " + cmbCountry.SelectedValue + "";
            }
            if (cmbState.SelectedIndex > 0)
            {
                whereCondition += " AND P.stateId = " + cmbState.SelectedValue + "";
            }
            if (cmbDistrict.SelectedIndex > 0)
            {
                whereCondition += " AND P.districtId = " + cmbDistrict.SelectedValue + "";
            }
            if (cmbCity.SelectedIndex > 0)
            {
                whereCondition += " AND P.cityId = " + cmbCity.SelectedValue + "";
            }
            if (cmbArea.SelectedIndex > 0)
            {
                whereCondition += " AND P.areaId = " + cmbArea.SelectedValue + "";
            }
            if (cmbAgent.SelectedIndex > 0)
            {
                whereCondition += " AND SUB.agentId = " + cmbAgent.SelectedValue + "";
            }
            if (chkExpired.Checked)
            {
                string todayDate = DateTime.Now.ToShortDateString();
                whereCondition += " AND SUBD.subscriptionEndDate <= '" + todayDate + " 23:59:59'";
            }

            var reportBll = new ReportBLL();
            SearchResult = reportBll.GetCustomizedPersonList(whereCondition);
            lblRecordCountValue.Text = Convert.ToString(SearchResult.Rows.Count);
            FillDataGridView();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        public void ClearControls()
        {
            cmbCountry.SelectedIndex = 0;
            cmbState.SelectedIndex = 0;
            cmbDistrict.SelectedIndex = 0;
            cmbCity.SelectedIndex = 0;
            cmbArea.SelectedIndex = 0;
            cmbAgent.SelectedIndex = 0;
            chkExpired.Checked = false;
            lblRecordCountValue.Text = "0";
            SearchResult = new DataTable();
            FillDataGridView();
            cmbAgent.Focus();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (SearchResult.Rows.Count > 0)
            {
                using (SaveFileDialog sdf = new SaveFileDialog() { Filter = "PDF File|*.pdf", ValidateNames = true })
                {
                    if (sdf.ShowDialog() == DialogResult.OK)
                    {
                        bool isGenerated = PDFGeneration.AddContentToPDF(sdf.FileName, SearchResult);
                        if (isGenerated)
                        {
                            MessageBox.Show("Agent-wise PDF file Successfully generated", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Agent-wise PDF not generated", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void dgvCustomReport_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow aRow in dgvCustomReport.Rows)
            {
                aRow.MinimumHeight = 30;
                aRow.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                if (aRow.Cells["status"].Value.ToString() == "2")
                {
                    aRow.DefaultCellStyle.BackColor = Color.LightCoral;
                }
                if (aRow.Cells["status"].Value.ToString() == "3")
                {
                    aRow.DefaultCellStyle.BackColor = Color.Turquoise;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
