﻿using Shaheen.BLL;
using Shaheen.IshraqEntities;
using Shaheen.Models;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmRenew : BaseForm
    {
        private SubscriptionBLL subscriptionBll;
        private SubscriptionDetailBLL subscriptionDetailBll;
        private PersonBLL personBll;

        dynamic subscription = new Subscription();
        dynamic subscriptionDetail = new SubscriptionDetail();
        dynamic personModel = new PersonModel();

        public int PersonId { get; set; }
        public string AgentName { get; set; }
        public int SubscriptionId { get; set; }
        public int SubscriptionDetailId { get; set; }

        public decimal PendingAmount { get; set; }
        public frmRenew()
        {
            InitializeComponent();
            subscriptionBll = new SubscriptionBLL();
            subscriptionDetailBll = new SubscriptionDetailBLL();
            personBll = new PersonBLL();
        }

        private void BindDropdownlists()
        {
            cmbPaymentType.DataSource = Enum.GetValues(typeof(PaymentType));
        }

        private void frmRenew_Load(object sender, EventArgs e)
        {
            BindDropdownlists();
            #region Display
            personModel = personBll.GetPersonModelById(PersonId);

            string strAddress = string.Empty;
            if (!string.IsNullOrEmpty(personModel.personAddress))
                strAddress += personModel.personAddress + ", "; ;

            if (!string.IsNullOrEmpty(personModel.areaName))
                strAddress += personModel.areaName + ", ";

            if (!string.IsNullOrEmpty(personModel.cityName))
                strAddress += personModel.cityName;

            if (!string.IsNullOrEmpty(personModel.pin))
                strAddress += "-" + personModel.pin + ", "; ;

            if (!string.IsNullOrEmpty(personModel.districtName))
                strAddress += personModel.districtName + ", ";

            if (!string.IsNullOrEmpty(personModel.stateName))
                strAddress += personModel.stateName + ", ";

            if (!string.IsNullOrEmpty(personModel.countryName))
                strAddress += personModel.countryName;

            txtAddress.Text = strAddress;

            string contact = string.IsNullOrEmpty(personModel.phone) ? string.Empty : personModel.phone + " - ";
            lblContact.Text = contact + personModel.mobile;
            lblAgent.Text = AgentName;
            lblEmail.Text = personModel.email;
            #endregion

            subscription = subscriptionBll.GetSubscriptionById(SubscriptionId);
            lblSubscriptionDate.Text = Convert.ToDateTime(subscription.subscriptionDate).ToShortDateString();
            lblCode.Text = subscription.subscriptionCode + " - " + personModel.personName;
            PendingAmount = subscription.pendingAmount;
            lblSubscriptionType.Text = Enum.GetName(typeof(SubscriptionType), subscription.subscriptionType);

            subscriptionDetail = subscriptionDetailBll.GetSubscriptionDetailById(SubscriptionDetailId);
            dtpStartDate.Value = subscriptionDetail.subscriptionEndDate;

            cmbPaymentType.SelectedItem = PaymentType.Cash;
            dtpChequeDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            dtpPaymentDate.Value = DateTime.Now;
            txtDuration.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private bool isValid()
        {
            bool isRes = true;
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Amount is required.", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Focus();
                isRes = false;
            }
            else if (string.IsNullOrEmpty(txtDuration.Text))
            {
                MessageBox.Show("Duration is required.", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDuration.Focus();
                isRes = false;
            }
            else if (string.IsNullOrEmpty(txtPaidAmout.Text))
            {
                MessageBox.Show("Paid Amount is required.", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPaidAmout.Focus();
                isRes = false;
            }
            else if (string.IsNullOrEmpty(txtReceiptNo.Text))
            {
                MessageBox.Show("Receipt no is required.", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtReceiptNo.Focus();
                isRes = false;
            }
            else if (dtpStartDate.Value >= dtpEndDate.Value)
            {
                MessageBox.Show("Enddate should be greater than Startdate.", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpStartDate.Focus();
                isRes = false;
            }
            else if (Convert.ToString(cmbPaymentType.SelectedValue) != PaymentType.Cash.ToString())
            {

                if (string.IsNullOrEmpty(txtChequeNo.Text))
                {
                    MessageBox.Show("DD/Cheque/MO number is required.", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtChequeNo.Focus();
                    isRes = false;
                }
                else if (string.IsNullOrEmpty(txtBankName.Text))
                {
                    MessageBox.Show("Bank name is required.", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                using (IshraqContext context = new IshraqContext())
                {
                    using (var transaction = context.Database.BeginTransaction())
                    {
                        try
                        {
                            int subscriptionId = UpdateSubscriptionPendingAmount(SubscriptionId, context);
                            int oldSubscriptionDetailId = UpdateCurrentSubscriptionDetailStatus(SubscriptionDetailId, context);
                            int subscriptionDetailId = SaveSubscriptionDetail(SubscriptionId, context);
                            int paymentId = SavePayment(SubscriptionId, context);
                            transaction.Commit();
                            MessageBox.Show(MessageText.SaveMessage, MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearControls();
                            this.DialogResult = DialogResult.OK;
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }

            }
        }

        public void ClearControls()
        {
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
        public int UpdateSubscriptionPendingAmount(int subscriptionId, IshraqContext context)
        {
            subscription.pendingAmount = (PendingAmount + Convert.ToDecimal(txtAmount.Text)) - Convert.ToDecimal(txtPaidAmout.Text);
            subscription.status = Convert.ToInt32(SubscriptionStatus.Active);
            context.Entry(subscription).State = EntityState.Modified;
            context.SaveChanges();
            return subscriptionId;
        }

        //Update Status of Previous active subscription details
        public int UpdateCurrentSubscriptionDetailStatus(int subscriptionDetailId, IshraqContext context)
        {
            var subscriptionDetail = new SubscriptionDetail();
            subscriptionDetail = subscriptionDetailBll.GetSubscriptionDetailById(subscriptionDetailId);
            subscriptionDetail.status = false;
            context.Entry(subscriptionDetail).State = EntityState.Modified;
            context.SaveChanges();
            return subscriptionDetailId;

        }
        public int SaveSubscriptionDetail(int subscriptionId, IshraqContext context)
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
        private int SavePayment(int subscriptionId, IshraqContext context)
        {
            var payment = new Payment();
            payment.subscriptionId = subscriptionId;

            payment.paymentType = cmbPaymentType.SelectedItem.ToString();

            if (Convert.ToString(cmbPaymentType.SelectedValue) == PaymentType.Cash.ToString())
            {
                payment.chequeDate = null;
                payment.chequeNo = string.Empty;
                payment.bankName = string.Empty;
            }
            else
            {
                payment.chequeDate = dtpChequeDate.Value;
                payment.chequeNo = txtChequeNo.Text;
                payment.bankName = txtBankName.Text;
            }
            payment.receiptNo = txtReceiptNo.Text;
            payment.amountPaid = Convert.ToDecimal(txtPaidAmout.Text);
            payment.bankName = txtBankName.Text;
            payment.paymentDate = dtpPaymentDate.Value;
            var res = context.Payments.Add(payment);
            context.SaveChanges();
            return res.paymentId;
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
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        private void cmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(cmbPaymentType.SelectedValue) == PaymentType.Cash.ToString())
            {
                txtChequeNo.Enabled = false;
                lblChequeNo.Enabled = false;
                dtpChequeDate.Enabled = false;
                lblChequeDate.Enabled = false;
                txtBankName.Enabled = false;
                lblBankName.Enabled = false;
            }
            else
            {
                txtChequeNo.Enabled = true;
                lblChequeNo.Enabled = true;
                dtpChequeDate.Enabled = true;
                lblChequeDate.Enabled = true;
                txtBankName.Enabled = true;
                lblBankName.Enabled = true;
            }
        }

        private void dtpStartDate_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDuration.Text))
            {
                dtpEndDate.Value = dtpStartDate.Value.AddYears(Convert.ToInt32(txtDuration.Text)).AddDays(-1);
            }
        }
    }
}
