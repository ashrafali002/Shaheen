﻿using Shaheen.BLL;
using Shaheen.IshraqEntities;
using System;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmEditPayment : BaseForm
    {
        public int PaymentId { get; set; }
        public decimal PendingAmount { get; set; }
        public decimal oldPaidAmount { get; set; }

        private PaymentBLL paymentBll;
        private SubscriptionBLL subscriptionBll;

        dynamic subscription = new Subscription();
        dynamic payment = new Payment();
        public frmEditPayment()
        {
            InitializeComponent();
            paymentBll = new PaymentBLL();
            subscriptionBll = new SubscriptionBLL();
        }

        private void frmEditPayment_Load(object sender, EventArgs e)
        {
            cmbPaymentType.DataSource = Enum.GetValues(typeof(PaymentType));

            payment = paymentBll.GetPaymentById(PaymentId);
            cmbPaymentType.SelectedItem = payment.paymentType;            
            if (payment.paymentDate != null)
                dtpPaymentDate.Value = payment.paymentDate;
            txtPaidAmout.Text = Convert.ToString(payment.amountPaid);
            oldPaidAmount = payment.amountPaid;
            txtChequeNo.Text = Convert.ToString(payment.chequeNo);
            if (payment.chequeDate != null)
                dtpChequeDate.Value = payment.chequeDate;
            txtBankName.Text = payment.bankName;
            txtReceiptNo.Text = payment.receiptNo;

            subscription = subscriptionBll.GetSubscriptionById(payment.subscriptionId);
            PendingAmount = subscription.pendingAmount;

        }    

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private bool isValid()
        {
            bool isRes = true;
            if (string.IsNullOrEmpty(txtPaidAmout.Text))
            {
                MessageBox.Show("Amount paid is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPaidAmout.Focus();
                isRes = false;
            }
            else if (string.IsNullOrEmpty(txtReceiptNo.Text))
            {
                MessageBox.Show("Receipt no is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtReceiptNo.Focus();
                isRes = false;
            }
            else if (Convert.ToString(cmbPaymentType.SelectedValue) != PaymentType.Cash.ToString())
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

        public int UpdateSubscriptionPendingAmount(int subscriptionId)
        {
            subscription.pendingAmount = (PendingAmount + oldPaidAmount) - Convert.ToDecimal(txtPaidAmout.Text);
            subscriptionBll.SaveSubscription(subscription);
            return subscriptionId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isValid())
            {
                return;
            }
            else
            {
                UpdateSubscriptionPendingAmount(payment.subscriptionId);
                payment.paymentType = cmbPaymentType.SelectedItem.ToString();

                if (Convert.ToString(cmbPaymentType.SelectedValue) == PaymentType.Cash.ToString())
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
                int res = paymentBll.SavePayment(payment);
                if (res > 0)
                {
                    MessageBox.Show("Record saved successfully", "Shaheen Weekly", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.OK;
                }
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
                label25.Enabled = false;
            }
            else
            {
                txtChequeNo.Enabled = true;
                lblChequeNo.Enabled = true;
                dtpChequeDate.Enabled = true;
                lblChequeDate.Enabled = true;
                txtBankName.Enabled = true;
                label25.Enabled = true;
            }
        }
    }
}
