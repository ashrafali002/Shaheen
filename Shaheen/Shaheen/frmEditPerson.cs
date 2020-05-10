using Shaheen.BLL;
using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmEditPerson : BaseForm
    {
        private int _personId;
        private int _subscriptionId;

        private PersonBLL personBll;
        private SubscriptionBLL subscriptionBll;

        dynamic subscription = new Subscription();
        dynamic person = new Person();

        public int PersonId
        {
            get { return _personId; }
            set { _personId = value; }
        }
        public int SubscriptionId
        {
            get { return _subscriptionId; }
            set { _subscriptionId = value; }
        }

        public frmEditPerson()
        {
            InitializeComponent();
            personBll = new PersonBLL();
            subscriptionBll = new SubscriptionBLL();
        }

        private void Dropdownlists()
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

            var countryBll = new CountryBLL();
            var countryList = countryBll.CountryList();
            countryList.Insert(0, new Country { countryId = 0, countryName = "---Select Country---" });
            cmbCountry.DataSource = countryList;
            cmbCountry.DisplayMember = "countryName";
            cmbCountry.ValueMember = "countryId";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmEditPerson_Load(object sender, EventArgs e)
        {
            Dropdownlists();
            person = personBll.GetPersonById(_personId);
            txtName.Text = person.personName;
            txtAddress.Text = person.personAddress;
            cmbCountry.SelectedValue = person.countryId;
            cmbState.SelectedValue = person.stateId;
            cmbDistrict.SelectedValue = person.districtId;
            cmbCity.SelectedValue = person.cityId;
            cmbArea.SelectedValue = person.areaId;
            txtPIN.Text = person.pin;
            txtPhone.Text = person.phone;
            txtMobile.Text = person.mobile;
            txtEmail.Text = person.email;

            subscription = subscriptionBll.GetSubscriptionById(_subscriptionId);
            txtCode.Text = subscription.subscriptionCode;
            cmbAgent.SelectedValue = subscription.agentId;
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
            else if (string.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("Customer Code is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCode.Focus();
                isRes = false;
            }
            else if (subscriptionBll.IsDuplicateSubscriptionCode(_subscriptionId, txtCode.Text))
            {
                MessageBox.Show("Duplicate customer code found.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
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
            else if (!CommonFunctions.checkEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid email format.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                isRes = false;
            }
            else if (cmbAgent.SelectedIndex <= 0)
            {
                MessageBox.Show("Agent is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbAgent.Focus();
                isRes = false;
            }            
            else
            {
                isRes = true;
            }
            return isRes;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isValid()) return;            
            person.personId = _personId;
            person.personName = txtName.Text;
            person.personAddress = txtAddress.Text;
            person.countryId = Convert.ToInt32(cmbCountry.SelectedValue);
            person.stateId = Convert.ToInt32(cmbState.SelectedValue);
            person.districtId = Convert.ToInt32(cmbDistrict.SelectedValue);
            person.cityId = Convert.ToInt32(cmbCity.SelectedValue);
            person.areaId = Convert.ToInt32(cmbArea.SelectedValue);
            person.pin = txtPIN.Text;
            person.phone = txtPhone.Text;
            person.mobile = txtMobile.Text;
            person.email = txtEmail.Text;
            personBll.SavePerson(person);
            
            subscription.subscriptionId = _subscriptionId;
            subscription.agentId = Convert.ToInt32(cmbAgent.SelectedValue);
            subscription.subscriptionCode = txtCode.Text;
            subscription.personId = _personId;
            subscriptionBll.SaveSubscription(subscription);
            MessageBox.Show("Person details updated successfully.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }
    }
}
