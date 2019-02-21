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
    public partial class frmCustomer : BaseForm
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            Dropdownlists();
        }

        private void Dropdownlists()
        {
            var areaList = AreaBLL.AreaList();
            areaList.Insert(0, new Area { areaId = 0, areaName = "---Select Area---", cityId = 0 });
            cmbArea.DataSource = areaList;
            cmbArea.DisplayMember = "areaName";
            cmbArea.ValueMember = "areaId";

            var cityList = CityBLL.CityList();
            cityList.Insert(0, new City { cityId = 0, cityName = "---Select City---", districtId = 0 });
            cmbCity.DataSource = cityList;
            cmbCity.DisplayMember = "cityName";
            cmbCity.ValueMember = "cityId";

            var districtList = DistrictBLL.DistrictList();
            districtList.Insert(0, new District { districtId = 0, districtName = "---Select District---", stateId = 0 });
            cmbDistrict.DataSource = districtList;
            cmbDistrict.DisplayMember = "districtName";
            cmbDistrict.ValueMember = "districtId";

            var stateList = StateBLL.StateList();
            stateList.Insert(0, new State { stateId = 0, stateName = "---Select State---", countryId = 0 });
            cmbState.DataSource = stateList;
            cmbState.DisplayMember = "stateName";
            cmbState.ValueMember = "stateId";

            var countryList = CountryBLL.CountryList();
            countryList.Insert(0, new Country { countryId = 0, countryName = "---Select Country---" });
            cmbCountry.DataSource = countryList;
            cmbCountry.DisplayMember = "countryName";
            cmbCountry.ValueMember = "countryId";

            var agentList = AgentBLL.AgentList();
            agentList.Insert(0, new Agent { agentId = 0, agentCode = "---Select Agent---" });
            cmbAgent.DataSource = agentList;
            cmbAgent.DisplayMember = "agentCode";
            cmbAgent.ValueMember = "agentId";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MDIMain.isCustomer = false;
            this.Close();
        }

        private bool isValid()
        {
            bool isRes = true;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Shaheen Weekly");
                txtName.Focus();
                isRes = false;
            }
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("Customer Code is required.", "Shaheen Weekly");
                txtCode.Focus();
                isRes = false;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Address is required.", "Shaheen Weekly");
                txtAddress.Focus();
                isRes = false;
            }
            if (cmbCountry.SelectedIndex > 0)
            {
                MessageBox.Show("Country is required.", "Shaheen Weekly");
                cmbCountry.Focus();
                isRes = false;
            }
            if (cmbState.SelectedIndex > 0)
            {
                MessageBox.Show("State is required.", "Shaheen Weekly");
                cmbState.Focus();
                isRes = false;
            }
            if (cmbDistrict.SelectedIndex > 0)
            {
                MessageBox.Show("District is required.", "Shaheen Weekly");
                cmbDistrict.Focus();
                isRes = false;
            }
            if (cmbCity.SelectedIndex > 0)
            {
                MessageBox.Show("City is required.", "Shaheen Weekly");
                cmbCity.Focus();
                isRes = false;
            }
            if (cmbArea.SelectedIndex > 0)
            {
                MessageBox.Show("Area is required.", "Shaheen Weekly");
                cmbArea.Focus();
                isRes = false;
            }
            if (string.IsNullOrEmpty(txtPIN.Text))
            {
                MessageBox.Show("PIN is required.", "Shaheen Weekly");
                txtPIN.Focus();
                isRes = false;
            }
            if (string.IsNullOrEmpty(txtMobile.Text))
            {
                MessageBox.Show("Mobile is required.", "Shaheen Weekly");
                txtMobile.Focus();
                isRes = false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Shaheen Weekly");
                txtEmail.Focus();
                isRes = false;
            }
            if (cmbAgent.SelectedIndex > 0)
            {
                MessageBox.Show("Agent is required.", "Shaheen Weekly");
                cmbAgent.Focus();
                isRes = false;
            }
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Amount is required.", "Shaheen Weekly");
                txtAmount.Focus();
                isRes = false;
            }

            if (string.IsNullOrEmpty(txtAmountPaid.Text))
            {
                MessageBox.Show("Paid Amount is required.", "Shaheen Weekly");
                txtAmountPaid.Focus();
                isRes = false;
            }

            if (string.IsNullOrEmpty(txtReceiptNo.Text))
            {
                MessageBox.Show("Receipt no is required.", "Shaheen Weekly");
                txtReceiptNo.Focus();
                isRes = false;
            }
            return isRes;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                int personId = SavePerson();
                int subscriptionId = SaveSubscription(personId);
                int subscriptionDetailId = SaveSubscriptionDetail(subscriptionId);
            }
        }

        public void SaveCustomer()
        {

        }

        public int SavePerson()
        {
            var person = new Person();
            person.personName = txtName.Text;
            person.personAddress = txtAddress.Text;
            person.areaId = Convert.ToInt32(cmbCountry.SelectedValue);
            person.cityId = Convert.ToInt32(cmbState.SelectedValue);
            person.districtId = Convert.ToInt32(cmbDistrict.SelectedValue);
            person.stateId = Convert.ToInt32(cmbCity.SelectedValue);
            person.countryId = Convert.ToInt32(cmbArea.SelectedValue);
            person.pin = txtPIN.Text;
            person.phone = txtPhone.Text;
            person.mobile = txtMobile.Text;
            person.email = txtEmail.Text;
            PersonBLL personBll = new PersonBLL();
            person.personId = personBll.SavePerson(person);
            return person.personId;
        }
        public int SaveSubscription(int personId)
        {
            var subscription = new Subscription();
            subscription.agentId = Convert.ToInt32(cmbAgent.SelectedValue);
            subscription.subscriptionDate = dtpSubscriptionDate.Value;
            subscription.subscriptionCode = txtCode.Text;
            subscription.personId = personId;
            SubscriptionBLL subsBll = new SubscriptionBLL();
            subsBll.SaveSubscription(subscription);
            return subscription.subscriptionId;
        }

        public int SaveSubscriptionDetail(int subscriptionId)
        {
            var subscriptionDetail = new SubscriptionDetail();
            subscriptionDetail.subscriptionId = subscriptionId;
            subscriptionDetail.note = txtNote.Text;
            subscriptionDetail.subscriptionAmount = Convert.ToDecimal(txtAmount.Text);
            subscriptionDetail.subscriptionDuration = txtDuration.Text;
            subscriptionDetail.subscriptionEndDate = dtpEndDate.Value;
            subscriptionDetail.subscriptionStartDate = dtpStartDate.Value;
            SubscriptionDetailBLL subsDetailBll = new SubscriptionDetailBLL();
            subsDetailBll.SaveSubscriptionDetail(subscriptionDetail);
            return subscriptionDetail.subscriptionId;
        }
        private int SavePayment()
        {
            var payment = new Payment();
            payment.amountPaid = Convert.ToDecimal(txtAmountPaid.Text);
            payment.bankName = txtBankname.Text;
            payment.chequeDate = dtpChequeDate.Value;
            payment.chequeNo = txtChequeNo.Text;
            payment.moDate = dtpMO.Value;
            payment.paymentDate = dtpPaymentDate.Value;
            
            return payment.paymentId;
        }
    }
}
