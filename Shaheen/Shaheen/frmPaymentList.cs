using Shaheen.BLL;
using Shaheen.Models;
using Shaheen.ShaheenDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmPaymentList : BaseForm
    {
        private int SubscriptionId { get; set; }

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
                        lblPendingAmount.Text = subscriptionModel.pendingAmount.ToString("C", CultureInfo.CurrentCulture);
                    }
                    else
                    {
                        MessageBox.Show("Invalid code", "Shaheen Weekly", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvPayment_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmEditPayment editPayment = new frmEditPayment();
            editPayment.PaymentId = Convert.ToInt32(dgvPayment.Rows[e.RowIndex].Cells["paymentId"].Value);
            
            if (editPayment.ShowDialog() == DialogResult.OK)
            {
                FillDataGridView();
            }
        }

        private void frmPaymentList_Load(object sender, EventArgs e)
        {
            txtCode.Focus();
        }
    }
}
