using Shaheen.BLL;
using Shaheen.Models;
using Shaheen.ShaheenDB;
using System;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmPayment : BaseForm
    {

        private int _subscriptionId;
        private int _personId;
        private string _agentName;
        private decimal _pendingAmount;

        private SubscriptionBLL subscriptionBll;
        private PersonBLL personBll;
        private PaymentBLL paymentBll;

        dynamic subscription = new Subscription();
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
        public decimal PendingAmount
        {
            get { return _pendingAmount; }
            set { _pendingAmount = value; }
        }
        public frmPayment()
        {
            InitializeComponent();
            subscriptionBll = new SubscriptionBLL();
            personBll = new PersonBLL();
            paymentBll = new PaymentBLL();
        }

        private void frmPayment_Load(object sender, EventArgs e)
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
            lblCode.Text = subscription.subscriptionCode + " - " + personModel.personName;
            PendingAmount = subscription.pendingAmount;

            rdoCash.Checked = true;
            dtpChequeDate.Value = DateTime.Now;
            dtpPaymentDate.Value = DateTime.Now;
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
            subscription.pendingAmount = PendingAmount - Convert.ToDecimal(txtPaidAmout.Text);
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
                UpdateSubscriptionPendingAmount(_subscriptionId);
                var payment = new Payment();
                payment.subscriptionId = _subscriptionId;

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
                int res = paymentBll.SavePayment(payment);
                if (res > 0)
                {
                    MessageBox.Show("Record saved successfully", "Shaheen Weekly", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void txtPaidAmout_KeyPress(object sender, KeyPressEventArgs e)
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