using Shaheen.BLL;
using Shaheen.Models;
using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmRenew : BaseForm
    {
        private int _subscriptionId;
        private int _subscriptionDetailId;
        private int _personId;
        private string _agentName;
        private decimal _pendingAmount;

        private SubscriptionBLL subscriptionBll;
        private SubscriptionDetailBLL subscriptionDetailBll;
        private PersonBLL personBll;

        dynamic subscription = new Subscription();
        dynamic subscriptionDetail = new SubscriptionDetail();
        dynamic personModel = new PersonModel();

        public int PersonId
        {
            get { return _personId; }
            set { _personId = value; }
        }
        public string AgentName
        {
            get { return _agentName; }
            set { _agentName = value; }
        }
        public int SubscriptionId
        {
            get { return _subscriptionId; }
            set { _subscriptionId = value; }
        }
        public int SubscriptionDetailId
        {
            get { return _subscriptionDetailId; }
            set { _subscriptionDetailId = value; }
        }

        public decimal PendingAmount
        {
            get { return _pendingAmount; }
            set { _pendingAmount = value; }
        }
        public frmRenew()
        {
            InitializeComponent();
            subscriptionBll = new SubscriptionBLL();
            subscriptionDetailBll = new SubscriptionDetailBLL();
            personBll = new PersonBLL();
        }



        private void frmRenew_Load(object sender, EventArgs e)
        {
            #region Display
            personModel = personBll.GetPersonModelById(_personId);

            lblAddress.Text = personModel.personAddress;
            lblCountry.Text = personModel.countryName;
            lblState.Text = personModel.stateName;
            lblDistrict.Text = personModel.districtName;
            lblCity.Text = personModel.cityName;
            lblArea.Text = personModel.areaName;
            lblPin.Text = personModel.pin;

            string contact = string.IsNullOrEmpty(personModel.phone) ? string.Empty : personModel.phone + " - ";
            lblContact.Text = contact + personModel.mobile;
            lblAgent.Text = AgentName;
            lblEmail.Text = personModel.email;
            #endregion

            subscription = subscriptionBll.GetSubscriptionById(_subscriptionId);
            lblSubscriptionDate.Text = Convert.ToDateTime(subscription.subscriptionDate).ToShortDateString();
            lblCode.Text = subscription.subscriptionCode + " - " + personModel.personName;
            PendingAmount = subscription.pendingAmount;

            subscriptionDetail = subscriptionDetailBll.GetSubscriptionDetailById(_subscriptionDetailId);
            txtDuration.Focus();
            dtpStartDate.Value = subscriptionDetail.subscriptionEndDate;
            
            rdoCash.Checked = true;
            dtpChequeDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            dtpPaymentDate.Value = DateTime.Now;            
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
                            int subscriptionId = UpdateSubscriptionPendingAmount(_subscriptionId, context);
                            int oldSubscriptionDetailId = UpdateCurrentSubscriptionDetailStatus(_subscriptionDetailId, context);
                            int subscriptionDetailId = SaveSubscriptionDetail(_subscriptionId, context);
                            int paymentId = SavePayment(_subscriptionId, context);
                            transaction.Commit();
                            MessageBox.Show("Record saved successfully", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearControls();
                            this.DialogResult = DialogResult.OK;
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
        public int UpdateSubscriptionPendingAmount(int subscriptionId, ShaheenEntities context)
        {
            subscription.pendingAmount = (PendingAmount + Convert.ToDecimal(txtAmount.Text)) - Convert.ToDecimal(txtPaidAmout.Text);
            context.Entry(subscription).State = EntityState.Modified;
            context.SaveChanges();
            return subscriptionId;
        }
        public int UpdateCurrentSubscriptionDetailStatus(int subscriptionDetailId, ShaheenEntities context)
        {
            var subscriptionDetail = new SubscriptionDetail();
            subscriptionDetail = subscriptionDetailBll.GetSubscriptionDetailById(subscriptionDetailId);
            subscriptionDetail.status = false;
            context.Entry(subscriptionDetail).State = EntityState.Modified;
            context.SaveChanges();
            return subscriptionDetailId;

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
