﻿using Shaheen.BLL;
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
        public SubscriptionBLL subscriptionBll;
        public frmSubscription()
        {
            InitializeComponent();
            subscriptionBll = new SubscriptionBLL();
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
            this.Close();
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
            else if (subscriptionBll.IsDuplicateSubscriptionCode(0, txtCode.Text))
            {
                MessageBox.Show("Duplicate customer code found.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if (string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Amount is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Focus();
                isRes = false;
            }
            else if (string.IsNullOrEmpty(txtDuration.Text))
            {
                MessageBox.Show("Duration is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDuration.Focus();
                isRes = false;
            }
            else if (string.IsNullOrEmpty(txtPaidAmout.Text))
            {
                MessageBox.Show("Paid Amount is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPaidAmout.Focus();
                isRes = false;
            }
            else if (string.IsNullOrEmpty(txtReceiptNo.Text))
            {
                MessageBox.Show("Receipt no is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtReceiptNo.Focus();
                isRes = false;
            }
            else if (dtpStartDate.Value >= dtpEndDate.Value)
            {
                MessageBox.Show("Enddate should be greater than Startdate.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpStartDate.Focus();
                isRes = false;
            }
            else if (rdoDD.Checked || rdoCheque.Checked || rdoMO.Checked)
            {

                if (string.IsNullOrEmpty(txtChequeNo.Text))
                {
                    MessageBox.Show("DD/Cheque/MO number is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtChequeNo.Focus();
                    isRes = false;
                }
                else if (string.IsNullOrEmpty(txtBankName.Text))
                {
                    MessageBox.Show("Bank name is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBankName.Focus();
                    isRes = false;
                }
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
                            MessageBox.Show("Record saved successfully", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearControls();
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
            person.countryId = Convert.ToInt32(cmbCountry.SelectedValue);
            person.stateId = Convert.ToInt32(cmbState.SelectedValue);
            person.districtId = Convert.ToInt32(cmbDistrict.SelectedValue);
            person.cityId = Convert.ToInt32(cmbCity.SelectedValue);
            person.areaId = Convert.ToInt32(cmbArea.SelectedValue);
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
            subscription.status = Convert.ToInt32(SubscriptionStatus.Active);
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
            subscriptionDetail.status = true;
            var res = context.SubscriptionDetails.Add(subscriptionDetail);
            context.SaveChanges();
            return res.subscriptionId;
        }
        private int SavePayment(int subscriptionId, ShaheenEntities context)
        {
            var payment = new Payment();
            payment.subscriptionId = subscriptionId;

            if (rdoCash.Checked)
            {
                payment.paymentType = PaymentType.Cash.ToString();
            }
            else if (rdoCheque.Checked)
            {
                payment.paymentType = PaymentType.Cheque.ToString();
            }
            else if (rdoDD.Checked)
            {
                payment.paymentType = PaymentType.DD.ToString();
            }
            else if (rdoMO.Checked)
            {
                payment.paymentType = PaymentType.MO.ToString();
            }

            if (rdoCash.Checked)
            {
                payment.chequeDate = null;
                payment.chequeNo = string.Empty;
            }
            else
            {
                payment.chequeDate = dtpChequeDate.Value;
                payment.chequeNo = txtChequeNo.Text;
            }
            payment.receiptNo = txtReceiptNo.Text;
            payment.amountPaid = Convert.ToDecimal(txtPaidAmout.Text);
            payment.bankName = txtBankName.Text;
            payment.paymentDate = dtpPaymentDate.Value;
            var res = context.Payments.Add(payment);
            context.SaveChanges();
            return res.paymentId;
        }

        private void txtPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        private void txtPaidAmout_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        private void txtDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        private void rdoCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCash.Checked)
            {
                txtChequeNo.Enabled = false;
                dtpChequeDate.Enabled = false;
                txtBankName.Enabled = false;
            }
            else
            {
                txtChequeNo.Enabled = true;
                dtpChequeDate.Enabled = true;
                txtBankName.Enabled = true;
            }
        }
    }
}