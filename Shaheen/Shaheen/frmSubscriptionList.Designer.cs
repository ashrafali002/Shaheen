namespace Shaheen
{
    partial class frmSubscriptionList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSubscriptionList = new System.Windows.Forms.DataGridView();
            this.subscriptionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriptionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriptionStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriptionEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriptionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriptionDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxmEditPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmSubscriptionDetails = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscriptionList)).BeginInit();
            this.mnuContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSubscriptionList
            // 
            this.dgvSubscriptionList.AllowUserToAddRows = false;
            this.dgvSubscriptionList.AllowUserToDeleteRows = false;
            this.dgvSubscriptionList.AllowUserToResizeColumns = false;
            this.dgvSubscriptionList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvSubscriptionList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubscriptionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubscriptionList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSubscriptionList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubscriptionList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubscriptionList.ColumnHeadersHeight = 50;
            this.dgvSubscriptionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSubscriptionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subscriptionCode,
            this.personName,
            this.subscriptionDate,
            this.subscriptionStartDate,
            this.subscriptionEndDate,
            this.pendingAmount,
            this.AreaName,
            this.cityName,
            this.districtName,
            this.stateName,
            this.agentName,
            this.personId,
            this.subscriptionId,
            this.subscriptionDetailId});
            this.dgvSubscriptionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubscriptionList.EnableHeadersVisualStyles = false;
            this.dgvSubscriptionList.Location = new System.Drawing.Point(0, 0);
            this.dgvSubscriptionList.MultiSelect = false;
            this.dgvSubscriptionList.Name = "dgvSubscriptionList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubscriptionList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSubscriptionList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSubscriptionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubscriptionList.Size = new System.Drawing.Size(1177, 722);
            this.dgvSubscriptionList.TabIndex = 7;
            this.dgvSubscriptionList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSubscriptionList_CellMouseDown);
            // 
            // subscriptionCode
            // 
            this.subscriptionCode.DataPropertyName = "subscriptionCode";
            this.subscriptionCode.FillWeight = 49.54955F;
            this.subscriptionCode.HeaderText = "Code";
            this.subscriptionCode.Name = "subscriptionCode";
            this.subscriptionCode.ReadOnly = true;
            this.subscriptionCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // personName
            // 
            this.personName.DataPropertyName = "personName";
            this.personName.FillWeight = 207.4462F;
            this.personName.HeaderText = "Customer";
            this.personName.Name = "personName";
            this.personName.ReadOnly = true;
            this.personName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // subscriptionDate
            // 
            this.subscriptionDate.DataPropertyName = "subscriptionDate";
            this.subscriptionDate.FillWeight = 94.12218F;
            this.subscriptionDate.HeaderText = "Subscription Date";
            this.subscriptionDate.Name = "subscriptionDate";
            this.subscriptionDate.ReadOnly = true;
            this.subscriptionDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // subscriptionStartDate
            // 
            this.subscriptionStartDate.DataPropertyName = "subscriptionStartDate";
            this.subscriptionStartDate.FillWeight = 71.04799F;
            this.subscriptionStartDate.HeaderText = "Start Date";
            this.subscriptionStartDate.Name = "subscriptionStartDate";
            this.subscriptionStartDate.ReadOnly = true;
            this.subscriptionStartDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // subscriptionEndDate
            // 
            this.subscriptionEndDate.DataPropertyName = "subscriptionEndDate";
            this.subscriptionEndDate.FillWeight = 73.06339F;
            this.subscriptionEndDate.HeaderText = "End Date";
            this.subscriptionEndDate.Name = "subscriptionEndDate";
            this.subscriptionEndDate.ReadOnly = true;
            this.subscriptionEndDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pendingAmount
            // 
            this.pendingAmount.DataPropertyName = "pendingAmount";
            this.pendingAmount.FillWeight = 74.94263F;
            this.pendingAmount.HeaderText = "Pending Amount";
            this.pendingAmount.Name = "pendingAmount";
            this.pendingAmount.ReadOnly = true;
            this.pendingAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AreaName
            // 
            this.AreaName.DataPropertyName = "AreaName";
            this.AreaName.FillWeight = 92.03385F;
            this.AreaName.HeaderText = "Area";
            this.AreaName.Name = "AreaName";
            this.AreaName.ReadOnly = true;
            this.AreaName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cityName
            // 
            this.cityName.DataPropertyName = "cityName";
            this.cityName.FillWeight = 92.75078F;
            this.cityName.HeaderText = "City";
            this.cityName.Name = "cityName";
            this.cityName.ReadOnly = true;
            this.cityName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // districtName
            // 
            this.districtName.DataPropertyName = "districtName";
            this.districtName.FillWeight = 93.40959F;
            this.districtName.HeaderText = "District";
            this.districtName.Name = "districtName";
            this.districtName.ReadOnly = true;
            this.districtName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // stateName
            // 
            this.stateName.DataPropertyName = "stateName";
            this.stateName.FillWeight = 94.01498F;
            this.stateName.HeaderText = "State";
            this.stateName.Name = "stateName";
            this.stateName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // agentName
            // 
            this.agentName.DataPropertyName = "agentName";
            this.agentName.FillWeight = 157.6188F;
            this.agentName.HeaderText = "Agent";
            this.agentName.Name = "agentName";
            this.agentName.ReadOnly = true;
            this.agentName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // personId
            // 
            this.personId.DataPropertyName = "personId";
            this.personId.HeaderText = "personId";
            this.personId.Name = "personId";
            this.personId.Visible = false;
            // 
            // subscriptionId
            // 
            this.subscriptionId.DataPropertyName = "subscriptionId";
            this.subscriptionId.HeaderText = "subscriptionId";
            this.subscriptionId.Name = "subscriptionId";
            this.subscriptionId.Visible = false;
            // 
            // subscriptionDetailId
            // 
            this.subscriptionDetailId.DataPropertyName = "subscriptionDetailId";
            this.subscriptionDetailId.HeaderText = "subscriptionDetailId";
            this.subscriptionDetailId.Name = "subscriptionDetailId";
            this.subscriptionDetailId.Visible = false;
            // 
            // mnuContext
            // 
            this.mnuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxmEditPerson,
            this.ctxmSubscriptionDetails});
            this.mnuContext.Name = "mnuContext";
            this.mnuContext.Size = new System.Drawing.Size(199, 70);
            // 
            // ctxmEditPerson
            // 
            this.ctxmEditPerson.Name = "ctxmEditPerson";
            this.ctxmEditPerson.Size = new System.Drawing.Size(198, 22);
            this.ctxmEditPerson.Text = "Edit Person";
            this.ctxmEditPerson.Click += new System.EventHandler(this.ctxmEditPerson_Click);
            // 
            // ctxmSubscriptionDetails
            // 
            this.ctxmSubscriptionDetails.Name = "ctxmSubscriptionDetails";
            this.ctxmSubscriptionDetails.Size = new System.Drawing.Size(198, 22);
            this.ctxmSubscriptionDetails.Text = "Edit SubscriptionDetails";
            this.ctxmSubscriptionDetails.Click += new System.EventHandler(this.ctxmSubscriptionDetails_Click);
            // 
            // frmSubscriptionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 722);
            this.Controls.Add(this.dgvSubscriptionList);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmSubscriptionList";
            this.Text = "SubscriptionList";
            this.Load += new System.EventHandler(this.frmSubscriptionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscriptionList)).EndInit();
            this.mnuContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubscriptionList;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn personName;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendingAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn personId;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionDetailId;
        private System.Windows.Forms.ContextMenuStrip mnuContext;
        private System.Windows.Forms.ToolStripMenuItem ctxmEditPerson;
        private System.Windows.Forms.ToolStripMenuItem ctxmSubscriptionDetails;
    }
}