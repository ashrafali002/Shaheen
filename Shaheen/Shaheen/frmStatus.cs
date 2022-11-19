using Shaheen.BLL;
using Shaheen.IshtiraqEntities;
using System;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmStatus : BaseForm
    {
        public int SubscriptionId { get; set; }
        private SubscriptionBLL subscriptionBll;
        Subscription subscription = new Subscription();

        public frmStatus()
        {
            InitializeComponent();
            subscriptionBll = new SubscriptionBLL();
        }

        private void frmStatus_Load(object sender, EventArgs e)
        {
            cmbStatus.DataSource = Enum.GetValues(typeof(SubscriptionStatus));
            subscription = subscriptionBll.GetSubscriptionById(SubscriptionId);
            cmbStatus.SelectedItem = Enum.GetName(typeof(SubscriptionStatus), subscription.status);
            //cmbStatus.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedIndex >= 0)
            {
                subscription.status = (int)Enum.Parse(typeof(SubscriptionStatus), Convert.ToString(cmbStatus.SelectedItem));
                subscriptionBll.SaveSubscription(subscription);
                MessageBox.Show("Suscription status updated successfully.", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Select status", MessageText.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
