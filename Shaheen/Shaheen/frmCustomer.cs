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
            rdoCash.Checked = true;
            dtpChequeDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            dtpMO.Value = DateTime.Now;
            dtpPaymentDate.Value = DateTime.Now;
            dtpStartDate.Value = DateTime.Now;
            dtpSubscriptionDate.Value = DateTime.Now;
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
            MDIMain.isCustomer = false;
            this.Close();
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
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                isRes = false;
            }
            else if (cmbAgent.SelectedIndex <= 0)
            {
                MessageBox.Show("Agent is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbAgent.Focus();
                isRes = false;
            }
            else if (string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Amount is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Focus();
                isRes = false;
            }

            else if (string.IsNullOrEmpty(txtAmountPaid.Text))
            {
                MessageBox.Show("Paid Amount is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmountPaid.Focus();
                isRes = false;
            }

            else if (string.IsNullOrEmpty(txtReceiptNo.Text))
            {
                MessageBox.Show("Receipt no is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtReceiptNo.Focus();
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
            if (isValid())
            {
                using (ShaheenEntities context = new ShaheenEntities())
                {
                    using (var transaction = context.Database.BeginTransaction())
                    {
                        try
                        {
                            int personId = SavePerson(context);
                            int subscriptionId = SaveSubscription(personId, context);
                            int subscriptionDetailId = SaveSubscriptionDetail(subscriptionId, context);
                            int paymentId = SavePayment(subscriptionId, context);
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }

            }
        }

        public int SavePerson(ShaheenEntities context)
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
            context.People.Add(person);
            context.SaveChanges();
            return person.personId;
        }
        public int SaveSubscription(int personId, ShaheenEntities context)
        {
            var subscription = new Subscription();
            subscription.agentId = Convert.ToInt32(cmbAgent.SelectedValue);
            subscription.subscriptionDate = dtpSubscriptionDate.Value;
            subscription.subscriptionCode = txtCode.Text;
            subscription.personId = personId;
            var res = context.Subscriptions.Add(subscription);
            context.SaveChanges();
            return res.subscriptionId;
        }

        public int SaveSubscriptionDetail(int subscriptionId, ShaheenEntities context)
        {
            var subscriptionDetail = new SubscriptionDetail();
            subscriptionDetail.subscriptionId = subscriptionId;
            subscriptionDetail.note = txtNote.Text;
            subscriptionDetail.subscriptionAmount = Convert.ToDecimal(txtAmount.Text);
            subscriptionDetail.subscriptionDuration = txtDuration.Text;
            subscriptionDetail.subscriptionEndDate = dtpEndDate.Value;
            subscriptionDetail.subscriptionStartDate = dtpStartDate.Value;
            var res = context.SubscriptionDetails.Add(subscriptionDetail);
            context.SaveChanges();
            return res.subscriptionId;
        }

        private int SavePayment(int subscriptionId, ShaheenEntities context)
        {
            var payment = new Payment();
            payment.subscriptionId = subscriptionId;

            if (rdoCash.Checked)
                payment.paymentType = PaymentType.Cash.ToString();
            else if (rdoCheque.Checked)
                payment.paymentType = PaymentType.Cheque.ToString();
            else if (rdoDD.Checked)
                payment.paymentType = PaymentType.DD.ToString();
            else if (rdoMO.Checked)
                payment.paymentType = PaymentType.MO.ToString();
            payment.receiptNo = txtReceiptNo.Text;
            payment.amountPaid = Convert.ToDecimal(txtAmountPaid.Text);
            payment.bankName = txtBankname.Text;
            payment.chequeDate = dtpChequeDate.Value;
            payment.chequeNo = txtChequeNo.Text;
            payment.moDate = dtpMO.Value;
            payment.paymentDate = dtpPaymentDate.Value;
            var res = context.Payments.Add(payment);
            context.SaveChanges();
            return res.paymentId;
        }

        private void rdoCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCash.Checked)
            {
                dtpPaymentDate.Enabled = true;
                dtpMO.Enabled = false;
                txtChequeNo.ReadOnly = true;
                dtpChequeDate.Enabled = false;
                txtBankname.ReadOnly = true;
            }
        }

        private void rdoDD_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDD.Checked)
            {
                dtpPaymentDate.Enabled = true;
                dtpMO.Enabled = false;
                txtChequeNo.ReadOnly = false;
                dtpChequeDate.Enabled = true;
                txtBankname.ReadOnly = false;
            }
        }

        private void rdoCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCheque.Checked)
            {
                dtpPaymentDate.Enabled = true;
                dtpMO.Enabled = false;
                txtChequeNo.ReadOnly = false;
                dtpChequeDate.Enabled = true;
                txtBankname.ReadOnly = false;
            }
        }

        private void rdoMO_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMO.Checked)
            {
                dtpPaymentDate.Enabled = true;
                dtpMO.Enabled = true;
                txtChequeNo.ReadOnly = true;
                dtpChequeDate.Enabled = false;
                txtBankname.ReadOnly = true;
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        private void txtAmountPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }

        }

        private void txtPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }
    }
}
