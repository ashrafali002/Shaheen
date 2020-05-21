using Shaheen.BLL;
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
            payment = paymentBll.GetPaymentById(PaymentId);
            if (payment.paymentType == PaymentType.Cash.ToString())
            {
                rdoCash.Checked = true;
                rdoCheque.Checked = false;
                rdoDD.Checked = false;
                rdoMO.Checked = false;
            }
            else if (payment.paymentType == PaymentType.Cheque.ToString())
            {
                rdoCash.Checked = false;
                rdoCheque.Checked = true;
                rdoDD.Checked = false;
                rdoMO.Checked = false;
            }
            else if (payment.paymentType == PaymentType.DD.ToString())
            {
                rdoCash.Checked = false;
                rdoCheque.Checked = false;
                rdoDD.Checked = true;
                rdoMO.Checked = false;
            }
            else if (payment.paymentType == PaymentType.MO.ToString())
            {
                rdoCash.Checked = false;
                rdoCheque.Checked = false;
                rdoDD.Checked = false;
                rdoMO.Checked = true;
            }
            else
            {
                //Contingency plan
            }
            if (payment.paymentDate != null)
                dtpPaymentDate.Value = payment.paymentDate;
            txtAmountPaid.Text = Convert.ToString(payment.amountPaid);
            oldPaidAmount = payment.amountPaid;
            txtChequeNo.Text = Convert.ToString(payment.chequeNo);
            if (payment.chequeDate != null)
                dtpChequeDate.Value = payment.chequeDate;
            txtBankName.Text = payment.bankName;
            txtReceiptNo.Text = payment.receiptNo;

            subscription = subscriptionBll.GetSubscriptionById(payment.subscriptionId);
            PendingAmount = subscription.pendingAmount;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private bool isValid()
        {
            bool isRes = true;
            if (string.IsNullOrEmpty(txtAmountPaid.Text))
            {
                MessageBox.Show("Amount paid is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmountPaid.Focus();
                isRes = false;
            }
            else if (string.IsNullOrEmpty(txtReceiptNo.Text))
            {
                MessageBox.Show("Receipt no is required.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtReceiptNo.Focus();
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

        public int UpdateSubscriptionPendingAmount(int subscriptionId)
        {
            subscription.pendingAmount = (PendingAmount + oldPaidAmount) - Convert.ToDecimal(txtAmountPaid.Text);
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
                payment.amountPaid = Convert.ToDecimal(txtAmountPaid.Text);
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
    }
}
