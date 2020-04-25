using Shaheen.DAL;
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
    public partial class frmSubscription : BaseForm
    {
        public frmSubscription()
        {
            InitializeComponent();
        }

        private void frmSubscription_Load(object sender, EventArgs e)
        {
            Dropdownlists();
            rdoCash.Checked = true;
            dtpChequeDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;            
            dtpPaymentDate.Value = DateTime.Now;
            dtpStartDate.Value = DateTime.Now;
            dtpSubscriptionDate.Value = DateTime.Now;
        }

        private void Dropdownlists()
        {
            var agentDAL = new AgentDAL();
            var agentList = agentDAL.AgentList();
            agentList.Insert(0, new Agent { agentId = 0, agentName = "---Select Agent---" });
            cmbAgent.DataSource = agentList;
            cmbAgent.DisplayMember = "agentName";
            cmbAgent.ValueMember = "agentId";

            var areaDAL = new AreaDAL();
            var areaList = areaDAL.AreaList();
            areaList.Insert(0, new Area { areaId = 0, areaName = "---Select Area---", cityId = 0 });
            cmbArea.DataSource = areaList;
            cmbArea.DisplayMember = "areaName";
            cmbArea.ValueMember = "areaId";

            var cityDAL = new CityDAL();
            var cityList = cityDAL.CityList();
            cityList.Insert(0, new City { cityId = 0, cityName = "---Select City---", districtId = 0 });
            cmbCity.DataSource = cityList;
            cmbCity.DisplayMember = "cityName";
            cmbCity.ValueMember = "cityId";

            var districtDAL = new DistrictDAL();
            var districtList = districtDAL.DistrictList();
            districtList.Insert(0, new District { districtId = 0, districtName = "---Select District---", stateId = 0 });
            cmbDistrict.DataSource = districtList;
            cmbDistrict.DisplayMember = "districtName";
            cmbDistrict.ValueMember = "districtId";

            var stateDAL = new StateDAL();
            var stateList = stateDAL.StateList();
            stateList.Insert(0, new State { stateId = 0, stateName = "---Select State---", countryId = 0 });
            cmbState.DataSource = stateList;
            cmbState.DisplayMember = "stateName";
            cmbState.ValueMember = "stateId";

            var countryDAL = new CountryDAL();
            var countryList = countryDAL.CountryList();
            countryList.Insert(0, new Country { countryId = 0, countryName = "---Select Country---" });
            cmbCountry.DataSource = countryList;
            cmbCountry.DisplayMember = "countryName";
            cmbCountry.ValueMember = "countryId";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMain.isSubscription = false;
            ClearControls();
        }
        public void ClearControls()
        {            
            foreach (Control c in grpPerson.Controls)
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
            foreach (Control c in grpSubscription.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
                else if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).Value = DateTime.Now;
                }
                else
                {
                    //Contingency Plan
                }
            }
            foreach (Control c in grpPayment.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
                else if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).Value = DateTime.Now;
                }
                else
                {
                    //Contingency Plan
                }
            }
        }

    }
}
