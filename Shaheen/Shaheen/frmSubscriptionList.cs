﻿using Shaheen.BLL;
using System;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.IO;
using System.Security.Authentication.ExtendedProtection;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmSubscriptionList : BaseForm
    {
        public string SearchString { get; set; }

        public SubscriptionBLL subscriptionBll;
        private int gridRowIndex { get; set; }
        public frmSubscriptionList()
        {
            InitializeComponent();
            subscriptionBll = new SubscriptionBLL();
        }

        private void frmSubscriptionList_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            rdoCode.Focus();
            btnSearch.TabStop = false;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.FlatAppearance.BorderSize = 0;
        }

        private void FillDataGridView()
        {
            foreach (DataGridViewColumn aColumn in dgvSubscriptionList.Columns)
            {
                aColumn.HeaderCell.Style.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            dgvSubscriptionList.AutoGenerateColumns = false;
            dgvSubscriptionList.DataSource = subscriptionBll.SubscriptionListWhole(SearchString);
            dgvSubscriptionList.Columns["subscriptionDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvSubscriptionList.Columns["subscriptionStartDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvSubscriptionList.Columns["subscriptionEndDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvSubscriptionList.Columns["pendingAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSubscriptionList.Columns["pendingAmount"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dgvSubscriptionList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.Button == MouseButtons.Right)
            {
                gridRowIndex = e.RowIndex;
                dgvSubscriptionList.Rows[gridRowIndex].Selected = true;
                this.mnuContext.Show(this.dgvSubscriptionList, e.Location);
                mnuContext.Show(Cursor.Position);
            }
        }

        private void ctxmEditPerson_Click(object sender, EventArgs e)
        {
            frmEditPerson editPerson = new frmEditPerson();
            this.Opacity = 10;
            editPerson.PersonId = Convert.ToInt32(dgvSubscriptionList.Rows[gridRowIndex].Cells["personId"].Value);
            editPerson.SubscriptionId = Convert.ToInt32(dgvSubscriptionList.Rows[gridRowIndex].Cells["subscriptionId"].Value);
            if (editPerson.ShowDialog() == DialogResult.OK)
            {
                FillDataGridView();
                dgvSubscriptionList.Rows[gridRowIndex].Selected = true;
            }
        }


        private void ctxmSubscriptionDetails_Click(object sender, EventArgs e)
        {
            frmEditSubscription editSubscription = new frmEditSubscription();
            editSubscription.PersonId = Convert.ToInt32(dgvSubscriptionList.Rows[gridRowIndex].Cells["personId"].Value);
            editSubscription.SubscriptionId = Convert.ToInt32(dgvSubscriptionList.Rows[gridRowIndex].Cells["subscriptionId"].Value);
            editSubscription.SubscriptionDetailId = Convert.ToInt32(dgvSubscriptionList.Rows[gridRowIndex].Cells["subscriptionDetailId"].Value);
            //editSubscription.AgentName = Convert.ToString(dgvSubscriptionList.Rows[rowIndex].Cells["agentName"].Value);
            if (editSubscription.ShowDialog() == DialogResult.OK)
            {
                FillDataGridView();
                dgvSubscriptionList.Rows[gridRowIndex].Selected = true;
            }
        }

        private void ctxmRenewSubscription_Click(object sender, EventArgs e)
        {
            frmRenew renew = new frmRenew();
            renew.PersonId = Convert.ToInt32(dgvSubscriptionList.Rows[gridRowIndex].Cells["personId"].Value);
            renew.SubscriptionId = Convert.ToInt32(dgvSubscriptionList.Rows[gridRowIndex].Cells["subscriptionId"].Value);
            renew.SubscriptionDetailId = Convert.ToInt32(dgvSubscriptionList.Rows[gridRowIndex].Cells["subscriptionDetailId"].Value);
            renew.AgentName = Convert.ToString(dgvSubscriptionList.Rows[gridRowIndex].Cells["agentName"].Value);
            if (renew.ShowDialog() == DialogResult.OK)
            {
                FillDataGridView();
                dgvSubscriptionList.Rows[gridRowIndex].Selected = true;
            }
        }

        private void ctxmPayment_Click(object sender, EventArgs e)
        {
            frmPayment payment = new frmPayment();
            payment.PersonId = Convert.ToInt32(dgvSubscriptionList.Rows[gridRowIndex].Cells["personId"].Value);
            payment.SubscriptionId = Convert.ToInt32(dgvSubscriptionList.Rows[gridRowIndex].Cells["subscriptionId"].Value);
            payment.AgentName = Convert.ToString(dgvSubscriptionList.Rows[gridRowIndex].Cells["agentName"].Value);
            if (payment.ShowDialog() == DialogResult.OK)
            {
                FillDataGridView();
                dgvSubscriptionList.Rows[gridRowIndex].Selected = true;
            }
        }

        private void ctmxUpdateStatus_Click(object sender, EventArgs e)
        {
            frmStatus status = new frmStatus();
            status.SubscriptionId = Convert.ToInt32(dgvSubscriptionList.Rows[gridRowIndex].Cells["subscriptionId"].Value);
            if (status.ShowDialog() == DialogResult.OK)
            {
                FillDataGridView();
                dgvSubscriptionList.Rows[gridRowIndex].Selected = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                string strSearch = string.Empty;
                if (rdoCode.Checked)
                {
                    strSearch = " AND SUB.subscriptionCode = '" + txtSearch.Text + "'";
                }
                else if (rdoPerson.Checked)
                {
                    strSearch = " AND p.personName like '%" + txtSearch.Text + "%'";
                }
                else
                {
                    strSearch = string.Empty;
                }
                SearchString = strSearch;
                FillDataGridView();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            SearchString = string.Empty;
            rdoCode.Checked = true;
            FillDataGridView();
        }

        private void dgvSubscriptionList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow aRow in dgvSubscriptionList.Rows)
            {
                aRow.Height = 30;
                aRow.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                if (aRow.Cells["status"].Value.ToString() == "2")
                {
                    aRow.DefaultCellStyle.BackColor = Color.LightCoral;
                }
                if (aRow.Cells["status"].Value.ToString() == "3")
                {
                    aRow.DefaultCellStyle.BackColor = Color.Turquoise;
                }
                if (Convert.ToDateTime(aRow.Cells["subscriptionEndDate"].Value) < DateTime.Now && aRow.Cells["status"].Value.ToString() == "1")
                {
                    aRow.DefaultCellStyle.BackColor = Color.Red;
                    aRow.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
