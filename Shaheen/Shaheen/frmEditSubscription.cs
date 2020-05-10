using Shaheen.BLL;
using Shaheen.DAL;
using Shaheen.Models;
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
    public partial class frmEditSubscription : BaseForm
    {
        private int _subscriptionId;
        private int _subscriptionDetailId;
        private int _personId;
        private string _agentName;

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

        public frmEditSubscription()
        {
            InitializeComponent();
            subscriptionBll = new SubscriptionBLL();
            subscriptionDetailBll = new SubscriptionDetailBLL();
            personBll = new PersonBLL();
        }

        private void frmEditSubscription_Load(object sender, EventArgs e)
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
            dtpSubscriptionDate.Value = subscription.subscriptionDate;
            lblCode.Text = subscription.subscriptionCode + " - " + personModel.personName;

            subscriptionDetail = subscriptionDetailBll.GetSubscriptionDetailById(_subscriptionDetailId);
            txtDuration.Text = subscriptionDetail.subscriptionDuration;
            dtpStartDate.Value = subscriptionDetail.subscriptionStartDate;
            dtpEndDate.Value = subscriptionDetail.subscriptionEndDate;
            txtAmount.Text = Convert.ToString(subscriptionDetail.subscriptionAmount);
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

            else if (dtpStartDate.Value >= dtpEndDate.Value)
            {
                MessageBox.Show("Enddate should be greater than Startdate.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            subscription.subscriptionDate = dtpSubscriptionDate.Value;
            subscriptionBll.SaveSubscription(subscription);

            subscriptionDetail.subscriptionDuration = txtDuration.Text;
            subscriptionDetail.subscriptionEndDate = dtpEndDate.Value;
            subscriptionDetail.subscriptionStartDate = dtpStartDate.Value;
            subscriptionDetail.subscriptionAmount = Convert.ToDecimal(txtAmount.Text);
            subscriptionDetail.note = txtNote.Text;
            subscriptionDetailBll.SaveSubscriptionDetail(subscriptionDetail);
            MessageBox.Show("Subscription details updated successfully.", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;

        }
    }
}
