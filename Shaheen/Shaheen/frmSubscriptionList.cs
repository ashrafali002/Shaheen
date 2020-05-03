﻿using Shaheen.BLL;
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
    public partial class frmSubscriptionList : BaseForm
    {
        public SubscriptionBLL subscriptionBll;
        public frmSubscriptionList()
        {
            InitializeComponent();
            subscriptionBll = new SubscriptionBLL();
        }

        private void frmSubscriptionList_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            dgvSubscriptionList.AutoGenerateColumns = false;
            dgvSubscriptionList.DataSource = subscriptionBll.SubscriptionListWhole();
            dgvSubscriptionList.Columns["subscriptionDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvSubscriptionList.Columns["subscriptionStartDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvSubscriptionList.Columns["subscriptionEndDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvSubscriptionList.Columns["pendingAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private int rowIndex = 0;
        private void dgvSubscriptionList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                rowIndex = e.RowIndex;
                dgvSubscriptionList.Rows[rowIndex].Selected = true;
                this.mnuContext.Show(this.dgvSubscriptionList, e.Location);
                mnuContext.Show(Cursor.Position);
            }
        }

        private void ctxmEditPerson_Click(object sender, EventArgs e)
        {
            frmEditPerson editPerson = new frmEditPerson();
            editPerson.PersonId  = Convert.ToInt32(dgvSubscriptionList.Rows[rowIndex].Cells["personId"].Value);
            editPerson.SubscriptionCode = Convert.ToString(dgvSubscriptionList.Rows[rowIndex].Cells["subscriptionCode"].Value);
            if (editPerson.ShowDialog() == DialogResult.OK)
            {
                FillDataGridView();
            }
        }
    }
}
