using Shaheen.BLL;
using Shaheen.DAL;
using Shaheen.Models;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmPaymentList : BaseForm
    {
        private int SubscriptionId { get; set; }
        private int PersonId { get; set; }

        public PaymentBLL paymentBll;

        public frmPaymentList()
        {
            InitializeComponent();
            paymentBll = new PaymentBLL();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FillDataGridView()
        {
            foreach (DataGridViewColumn aColumn in dgvPayment.Columns)
            {
                aColumn.HeaderCell.Style.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            dgvPayment.AutoGenerateColumns = false;
            dgvPayment.DataSource = paymentBll.GetPaymentBySubscriptionId(SubscriptionId).ToList();
            dgvPayment.Columns["paymentDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvPayment.Columns["chequeDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvPayment.Columns["amountPaid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                LoadSearchResult();
            }
        }

        private void LoadSearchResult()
        {
            if (!string.IsNullOrEmpty(txtCode.Text))
            {
                var subscriptionBll = new SubscriptionBLL();
                var subscriptionModel = new SubscriptionModel();
                subscriptionModel = subscriptionBll.GetSubscriptionWholeByCode(txtCode.Text);
                if (subscriptionModel != null)
                {
                    SubscriptionId = subscriptionModel.subscriptionId;
                    FillDataGridView();
                    lblAgent.Text = subscriptionModel.agentName;
                    lblName.Text = subscriptionModel.personName;
                    PersonId = subscriptionModel.personId;
                    lblPendingAmount.Text = subscriptionModel.pendingAmount.ToString("C", CultureInfo.CurrentCulture);
                }
                else
                {
                    MessageBox.Show("Invalid code", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvPayment_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmEditPayment editPayment = new frmEditPayment();
            editPayment.PaymentId = Convert.ToInt32(dgvPayment.Rows[e.RowIndex].Cells["paymentId"].Value);

            if (editPayment.ShowDialog() == DialogResult.OK)
            {
                LoadSearchResult();
            }
        }

        private void frmPaymentList_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            txtCode.Text = string.Empty;
            lblName.Text = string.Empty;
            txtCode.Focus();
        }

        private void dgvPayment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow aRow in dgvPayment.Rows)
            {
                aRow.Height = 30;
                aRow.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (PersonId == 0)
            {
                MessageBox.Show("Select Customer", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCode.Focus();
            }
            else
            {
                frmPayment payment = new frmPayment();
                payment.PersonId = PersonId;
                payment.SubscriptionId = SubscriptionId;
                payment.AgentName = lblAgent.Text;
                if (payment.ShowDialog() == DialogResult.OK)
                {
                    LoadSearchResult();
                }
            }
        }
    }
}
