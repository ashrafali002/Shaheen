using Shaheen.BLL;
using Shaheen.IshtiraqEntities;
using Shaheen.Models;
using System;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmPayment : BaseForm
    {
        private SubscriptionBLL subscriptionBll;
        private PersonBLL personBll;
        private PaymentBLL paymentBll;

        dynamic subscription = new Subscription();
        dynamic personModel = new PersonModel();

        public int PersonId { get; set; }
        public string AgentName { get; set; }
        public int SubscriptionId { get; set; }
        public decimal PendingAmount { get; set; }
        public frmPayment()
        {
            InitializeComponent();
            subscriptionBll = new SubscriptionBLL();
            personBll = new PersonBLL();
            paymentBll = new PaymentBLL();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            cmbPaymentType.DataSource = Enum.GetValues(typeof(PaymentType));
            #region Display
            personModel = personBll.GetPersonModelById(PersonId);

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

            subscription = subscriptionBll.GetSubscriptionById(SubscriptionId);
            lblCode.Text = subscription.subscriptionCode + " - " + personModel.personName;
            PendingAmount = subscription.pendingAmount;

            cmbPaymentType.SelectedItem = PaymentType.Cash;
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
                UpdateSubscriptionPendingAmount(SubscriptionId);
                var payment = new Payment();
                payment.subscriptionId = SubscriptionId;

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
                payment.paymentDate = dtpPaymentDate.Value;
                int res = paymentBll.SavePayment(payment);
                if (res > 0)
                {
                    MessageBox.Show(MessageText.SaveMessage, MessageText.MessageBoxCaption, MessageBoxButtons.OK);
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
    }
}