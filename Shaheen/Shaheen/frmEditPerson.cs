using Shaheen.BLL;
using Shaheen.IshraqEntities;
using System;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmEditPerson : BaseForm
    {
        private PersonBLL personBll;
        private SubscriptionBLL subscriptionBll;

        dynamic subscription = new Subscription();
        dynamic person = new Person();

        public int PersonId { get; set; }
        public int SubscriptionId { get; set; }

        public frmEditPerson()
        {
            InitializeComponent();
            personBll = new PersonBLL();
            subscriptionBll = new SubscriptionBLL();
        }

        private void Dropdownlists()
        {
            var countryBll = new CountryBLL();
            var countryList = countryBll.CountryList();
            countryList.Insert(0, new Country { countryId = 0, countryName = "---Select Country---" });
            cmbCountry.DataSource = countryList;
            cmbCountry.DisplayMember = "countryName";
            cmbCountry.ValueMember = "countryId";
        }

        private void BindStateByCountryId(int countryId)
        {
            var stateBll = new StateBLL();
            var stateList = stateBll.StateByCountryId(countryId);
            stateList.Insert(0, new State { stateId = 0, stateName = "---Select State---", countryId = 0 });
            cmbState.DataSource = stateList;
            cmbState.DisplayMember = "stateName";
            cmbState.ValueMember = "stateId";
        }

        private void BindDistrictByStateId(int stateId)
        {
            var districtBll = new DistrictBLL();
            var districtList = districtBll.DistrictByStateId(stateId);
            districtList.Insert(0, new District { districtId = 0, districtName = "---Select District---", stateId = 0 });
            cmbDistrict.DataSource = districtList;
            cmbDistrict.DisplayMember = "districtName";
            cmbDistrict.ValueMember = "districtId";
        }

        private void BindCityByDistrictId(int districtId)
        {
            var cityBll = new CityBLL();
            var cityList = cityBll.CityByDistrictId(districtId);
            cityList.Insert(0, new City { cityId = 0, cityName = "---Select City---", districtId = 0 });
            cmbCity.DataSource = cityList;
            cmbCity.DisplayMember = "cityName";
            cmbCity.ValueMember = "cityId";
        }

        private void BindAreaByCityId(int cityId)
        {
            var areaBll = new AreaBLL();
            var areaList = areaBll.AreaByCityId(cityId);
            areaList.Insert(0, new Area { areaId = 0, areaName = "---Select Area---", cityId = 0 });
            cmbArea.DataSource = areaList;
            cmbArea.DisplayMember = "areaName";
            cmbArea.ValueMember = "areaId";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmEditPerson_Load(object sender, EventArgs e)
        {
            Dropdownlists();
            person = personBll.GetPersonById(PersonId);
            txtName.Text = person.personName;
            txtAddress.Text = person.personAddress;
            cmbCountry.SelectedValue = person.countryId;
            BindStateByCountryId(person.countryId);
            cmbState.SelectedValue = person.stateId;
            BindDistrictByStateId(person.stateId);
            cmbDistrict.SelectedValue = person.districtId;
            BindCityByDistrictId(person.districtId);
            cmbCity.SelectedValue = person.cityId;
            BindAreaByCityId(person.cityId);
            if (person.areaId == null)
                cmbArea.SelectedIndex = 0;
            else
                cmbArea.SelectedValue = person.areaId;
            txtPIN.Text = person.pin;
            txtPhone.Text = person.phone;
            txtMobile.Text = person.mobile;
            txtEmail.Text = person.email;

            subscription = subscriptionBll.GetSubscriptionById(SubscriptionId);
            txtCode.Text = subscription.subscriptionCode;
        }

        private bool isValid()
        {
            bool isRes = true;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name is required.", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                isRes = false;
            }
            else if (string.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("Customer Code is required.", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCode.Focus();
                isRes = false;
            }
            else if (subscriptionBll.IsDuplicateSubscriptionCode(SubscriptionId, txtCode.Text))
            {
                MessageBox.Show("Duplicate customer code found.", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                isRes = false;
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Address is required.", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                isRes = false;
            }
            else if (cmbCountry.SelectedIndex <= 0)
            {
                MessageBox.Show("Country is required.", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCountry.Focus();
                isRes = false;
            }
            else if (cmbState.SelectedIndex <= 0)
            {
                MessageBox.Show("State is required.", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbState.Focus();
                isRes = false;
            }
            else if (cmbDistrict.SelectedIndex <= 0)
            {
                MessageBox.Show("District is required.", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbDistrict.Focus();
                isRes = false;
            }
            else if (cmbCity.SelectedIndex <= 0)
            {
                MessageBox.Show("City is required.", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCity.Focus();
                isRes = false;
            }
            else if (!CommonFunctions.checkEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid email format.", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
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
            if (MessageBox.Show(MessageText.ConfirmEdit, MessageText.MessageBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!isValid()) return;
                person.personId = PersonId;
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

                subscription.subscriptionId = SubscriptionId;
                subscription.subscriptionCode = txtCode.Text;
                subscription.personId = PersonId;
                subscriptionBll.SaveSubscription(subscription);
                MessageBox.Show("Person details updated successfully.", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void cmbCountry_Leave(object sender, EventArgs e)
        {
            BindStateByCountryId(Convert.ToInt32(cmbCountry.SelectedValue));
        }

        private void cmbState_Leave(object sender, EventArgs e)
        {
            BindDistrictByStateId(Convert.ToInt32(cmbState.SelectedValue));
        }

        private void cmbDistrict_Leave(object sender, EventArgs e)
        {
            BindCityByDistrictId(Convert.ToInt32(cmbDistrict.SelectedValue));
        }

        private void cmbCity_Leave(object sender, EventArgs e)
        {
            BindAreaByCityId(Convert.ToInt32(cmbCity.SelectedValue));
        }
    }
}
