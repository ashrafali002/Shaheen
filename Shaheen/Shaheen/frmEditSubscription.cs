using Shaheen.BLL;
using Shaheen.IshraqEntities;
using Shaheen.Models;
using System;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmEditSubscription : BaseForm
    {
        private SubscriptionBLL subscriptionBll;
        private SubscriptionDetailBLL subscriptionDetailBll;
        private PersonBLL personBll;

        dynamic subscription = new Subscription();
        dynamic subscriptionDetail = new SubscriptionDetail();
        dynamic personModel = new PersonModel();

        public int PersonId { get; set; }
        public int SubscriptionId { get; set; }
        public int SubscriptionDetailId { get; set; }
        public decimal PendingAmount { get; set; }
        public decimal OldAmount { get; set; }

        public frmEditSubscription()
        {
            InitializeComponent();
            subscriptionBll = new SubscriptionBLL();
            subscriptionDetailBll = new SubscriptionDetailBLL();
            personBll = new PersonBLL();
        }

        private void BindDropdownlists()
        {
            cmbSubscriptionType.DataSource = Enum.GetValues(typeof(SubscriptionType));

            var agentBll = new AgentBLL();
            var agentList = agentBll.AgentList();
            agentList.Insert(0, new Agent { agentId = 0, agentName = "---Select Agent---" });
            cmbAgent.DataSource = agentList;
            cmbAgent.DisplayMember = "agentName";
            cmbAgent.ValueMember = "agentId";
        }
        private void frmEditSubscription_Load(object sender, EventArgs e)
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
            lblEmail.Text = personModel.email;
            #endregion

            subscription = subscriptionBll.GetSubscriptionById(SubscriptionId);
            dtpSubscriptionDate.Value = subscription.subscriptionDate;
            lblCode.Text = subscription.subscriptionCode + " - " + personModel.personName;
            cmbAgent.SelectedValue = subscription.agentId;
            cmbSubscriptionType.SelectedItem = (SubscriptionType)subscription.subscriptionType;
            PendingAmount = subscription.pendingAmount;

            subscriptionDetail = subscriptionDetailBll.GetSubscriptionDetailById(SubscriptionDetailId);
            txtDuration.Text = subscriptionDetail.subscriptionDuration;
            dtpStartDate.Value = subscriptionDetail.subscriptionStartDate;
            dtpEndDate.Value = subscriptionDetail.subscriptionEndDate;
            txtAmount.Text = Convert.ToString(subscriptionDetail.subscriptionAmount);
            OldAmount = Convert.ToDecimal(subscriptionDetail.subscriptionAmount);
            txtNote.Text = subscriptionDetail.note;
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
            else if (cmbAgent.SelectedIndex <= 0)
            {
                MessageBox.Show("Select agent first.", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbAgent.Focus();
                isRes = false;
            }
            else if (dtpStartDate.Value >= dtpEndDate.Value)
            {
                MessageBox.Show("Enddate should be greater than Startdate.", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpStartDate.Focus();
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
                subscription.subscriptionDate = dtpSubscriptionDate.Value;
                subscription.pendingAmount = (Convert.ToDecimal(txtAmount.Text) - OldAmount) + PendingAmount;
                subscription.agentId = Convert.ToInt32(cmbAgent.SelectedValue);
                subscription.subscriptionType = Convert.ToInt32(cmbSubscriptionType.SelectedItem);
                subscriptionBll.SaveSubscription(subscription);

                subscriptionDetail.subscriptionDuration = txtDuration.Text;
                subscriptionDetail.subscriptionEndDate = dtpEndDate.Value;
                subscriptionDetail.subscriptionStartDate = dtpStartDate.Value;
                subscriptionDetail.subscriptionAmount = Convert.ToDecimal(txtAmount.Text);
                subscriptionDetail.note = txtNote.Text;
                subscriptionDetailBll.SaveSubscriptionDetail(subscriptionDetail);
                MessageBox.Show("Subscription details updated successfully.", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; 
            }

        }
    }
}
