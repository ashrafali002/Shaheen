using Shaheen.BLL;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaheen
{
    public partial class frmHome : BaseForm
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            lblActiveSubscription.Text = string.Empty;
            BindAgentWiseStatusCountGrid();
            GetStatusWiseCount();
        }
        public void BindAgentWiseStatusCountGrid()
        {
            foreach (DataGridViewColumn aColumn in dgvAgentWiseStatusCount.Columns)
            {
                aColumn.HeaderCell.Style.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            dgvAgentWiseStatusCount.AutoGenerateColumns = false;
            var reportBll = new ReportBLL();
            dgvAgentWiseStatusCount.DataSource = reportBll.GetAgentWiseStatusCount();
        }

        private void dgvAgentWiseStatusCount_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow aRow in dgvAgentWiseStatusCount.Rows)
            {
                aRow.Height = 30;
                aRow.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        public void GetStatusWiseCount()
        {
            var reportBll = new ReportBLL();
            DataTable dt = reportBll.GetStatusWiseCount();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (Convert.ToInt32(dr["status"]) == 1)
                    {
                        lblActiveSubscription.Text = Convert.ToString(dr["totalCount"]);
                        //lblActiveSubscription.Text = "99999";
                    }
                    else
                    {
                        lblActiveSubscription.Text = "0";
                    }
                    if (Convert.ToInt32(dr["status"]) == 2)
                    {
                        lblClosedSubscription.Text = Convert.ToString(dr["totalCount"]);
                        //lblClosedSubscription.Text = "99999";
                    }
                    else
                    {
                        lblClosedSubscription.Text = "0";
                    }
                    if (Convert.ToInt32(dr["status"]) == 3)
                    {
                        lblContinueSubscription.Text = Convert.ToString(dr["totalCount"]);
                        //lblContinueSubscription.Text = "99999";
                    }
                    else
                    {
                        lblContinueSubscription.Text = "0";
                    }
                }
            }
        }
    }
}
