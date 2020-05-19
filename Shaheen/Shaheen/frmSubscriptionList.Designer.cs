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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxmEditPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmSubscriptionDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmRenewSubscription = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdoPerson = new System.Windows.Forms.RadioButton();
            this.rdoCode = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscriptionList)).BeginInit();
            this.mnuContext.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSubscriptionList
            // 
            this.dgvSubscriptionList.AllowUserToAddRows = false;
            this.dgvSubscriptionList.AllowUserToDeleteRows = false;
            this.dgvSubscriptionList.AllowUserToResizeColumns = false;
            this.dgvSubscriptionList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(210)))), ((int)(((byte)(248)))));
            this.dgvSubscriptionList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubscriptionList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSubscriptionList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubscriptionList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
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
            this.subscriptionDetailId,
            this.status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubscriptionList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSubscriptionList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSubscriptionList.EnableHeadersVisualStyles = false;
            this.dgvSubscriptionList.Location = new System.Drawing.Point(0, 48);
            this.dgvSubscriptionList.MultiSelect = false;
            this.dgvSubscriptionList.Name = "dgvSubscriptionList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubscriptionList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSubscriptionList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSubscriptionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubscriptionList.Size = new System.Drawing.Size(1200, 652);
            this.dgvSubscriptionList.TabIndex = 7;
            this.dgvSubscriptionList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSubscriptionList_CellFormatting);
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
            this.subscriptionCode.Width = 51;
            // 
            // personName
            // 
            this.personName.DataPropertyName = "personName";
            this.personName.FillWeight = 207.4462F;
            this.personName.HeaderText = "Customer";
            this.personName.Name = "personName";
            this.personName.ReadOnly = true;
            this.personName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.personName.Width = 214;
            // 
            // subscriptionDate
            // 
            this.subscriptionDate.DataPropertyName = "subscriptionDate";
            this.subscriptionDate.FillWeight = 94.12218F;
            this.subscriptionDate.HeaderText = "Subscription Date";
            this.subscriptionDate.Name = "subscriptionDate";
            this.subscriptionDate.ReadOnly = true;
            this.subscriptionDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.subscriptionDate.Width = 98;
            // 
            // subscriptionStartDate
            // 
            this.subscriptionStartDate.DataPropertyName = "subscriptionStartDate";
            this.subscriptionStartDate.FillWeight = 71.04799F;
            this.subscriptionStartDate.HeaderText = "Start Date";
            this.subscriptionStartDate.Name = "subscriptionStartDate";
            this.subscriptionStartDate.ReadOnly = true;
            this.subscriptionStartDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.subscriptionStartDate.Width = 90;
            // 
            // subscriptionEndDate
            // 
            this.subscriptionEndDate.DataPropertyName = "subscriptionEndDate";
            this.subscriptionEndDate.FillWeight = 73.06339F;
            this.subscriptionEndDate.HeaderText = "End Date";
            this.subscriptionEndDate.Name = "subscriptionEndDate";
            this.subscriptionEndDate.ReadOnly = true;
            this.subscriptionEndDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.subscriptionEndDate.Width = 90;
            // 
            // pendingAmount
            // 
            this.pendingAmount.DataPropertyName = "pendingAmount";
            this.pendingAmount.FillWeight = 74.94263F;
            this.pendingAmount.HeaderText = "Pending Amount";
            this.pendingAmount.Name = "pendingAmount";
            this.pendingAmount.ReadOnly = true;
            this.pendingAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pendingAmount.Width = 78;
            // 
            // AreaName
            // 
            this.AreaName.DataPropertyName = "AreaName";
            this.AreaName.FillWeight = 92.03385F;
            this.AreaName.HeaderText = "Area";
            this.AreaName.Name = "AreaName";
            this.AreaName.ReadOnly = true;
            this.AreaName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AreaName.Width = 95;
            // 
            // cityName
            // 
            this.cityName.DataPropertyName = "cityName";
            this.cityName.FillWeight = 92.75078F;
            this.cityName.HeaderText = "City";
            this.cityName.Name = "cityName";
            this.cityName.ReadOnly = true;
            this.cityName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cityName.Width = 96;
            // 
            // districtName
            // 
            this.districtName.DataPropertyName = "districtName";
            this.districtName.FillWeight = 93.40959F;
            this.districtName.HeaderText = "District";
            this.districtName.Name = "districtName";
            this.districtName.ReadOnly = true;
            this.districtName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.districtName.Width = 96;
            // 
            // stateName
            // 
            this.stateName.DataPropertyName = "stateName";
            this.stateName.FillWeight = 94.01498F;
            this.stateName.HeaderText = "State";
            this.stateName.Name = "stateName";
            this.stateName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stateName.Width = 97;
            // 
            // agentName
            // 
            this.agentName.DataPropertyName = "agentName";
            this.agentName.FillWeight = 157.6188F;
            this.agentName.HeaderText = "Agent";
            this.agentName.Name = "agentName";
            this.agentName.ReadOnly = true;
            this.agentName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.agentName.Width = 163;
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
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "status";
            this.status.Name = "status";
            this.status.Visible = false;
            // 
            // mnuContext
            // 
            this.mnuContext.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxmEditPerson,
            this.ctxmSubscriptionDetails,
            this.ctxmRenewSubscription,
            this.ctxmPayment});
            this.mnuContext.Name = "mnuContext";
            this.mnuContext.Size = new System.Drawing.Size(248, 140);
            // 
            // ctxmEditPerson
            // 
            this.ctxmEditPerson.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ctxmEditPerson.Name = "ctxmEditPerson";
            this.ctxmEditPerson.Size = new System.Drawing.Size(247, 24);
            this.ctxmEditPerson.Text = "Edit Person";
            this.ctxmEditPerson.Click += new System.EventHandler(this.ctxmEditPerson_Click);
            // 
            // ctxmSubscriptionDetails
            // 
            this.ctxmSubscriptionDetails.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ctxmSubscriptionDetails.Name = "ctxmSubscriptionDetails";
            this.ctxmSubscriptionDetails.Size = new System.Drawing.Size(247, 24);
            this.ctxmSubscriptionDetails.Text = "Edit SubscriptionDetails";
            this.ctxmSubscriptionDetails.Click += new System.EventHandler(this.ctxmSubscriptionDetails_Click);
            // 
            // ctxmRenewSubscription
            // 
            this.ctxmRenewSubscription.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ctxmRenewSubscription.Name = "ctxmRenewSubscription";
            this.ctxmRenewSubscription.Size = new System.Drawing.Size(247, 24);
            this.ctxmRenewSubscription.Text = "Renew Subscription";
            this.ctxmRenewSubscription.Click += new System.EventHandler(this.ctxmRenewSubscription_Click);
            // 
            // ctxmPayment
            // 
            this.ctxmPayment.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ctxmPayment.Name = "ctxmPayment";
            this.ctxmPayment.Size = new System.Drawing.Size(247, 24);
            this.ctxmPayment.Text = "Payment";
            this.ctxmPayment.Click += new System.EventHandler(this.ctxmPayment_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Navy;
            this.txtSearch.Location = new System.Drawing.Point(408, 14);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(523, 20);
            this.txtSearch.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(408, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 1);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.rdoPerson);
            this.panel2.Controls.Add(this.rdoCode);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 48);
            this.panel2.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(54, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Search :";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(1047, 9);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 30);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(966, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdoPerson
            // 
            this.rdoPerson.AutoSize = true;
            this.rdoPerson.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPerson.ForeColor = System.Drawing.Color.Navy;
            this.rdoPerson.Location = new System.Drawing.Point(245, 13);
            this.rdoPerson.Name = "rdoPerson";
            this.rdoPerson.Size = new System.Drawing.Size(141, 23);
            this.rdoPerson.TabIndex = 26;
            this.rdoPerson.TabStop = true;
            this.rdoPerson.Text = "Customer Name";
            this.rdoPerson.UseVisualStyleBackColor = true;
            // 
            // rdoCode
            // 
            this.rdoCode.AutoSize = true;
            this.rdoCode.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCode.ForeColor = System.Drawing.Color.Navy;
            this.rdoCode.Location = new System.Drawing.Point(159, 13);
            this.rdoCode.Name = "rdoCode";
            this.rdoCode.Size = new System.Drawing.Size(63, 23);
            this.rdoCode.TabIndex = 25;
            this.rdoCode.TabStop = true;
            this.rdoCode.Text = "Code";
            this.rdoCode.UseVisualStyleBackColor = true;
            // 
            // frmSubscriptionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvSubscriptionList);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmSubscriptionList";
            this.Text = "SubscriptionList";
            this.Load += new System.EventHandler(this.frmSubscriptionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscriptionList)).EndInit();
            this.mnuContext.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubscriptionList;
        private System.Windows.Forms.ContextMenuStrip mnuContext;
        private System.Windows.Forms.ToolStripMenuItem ctxmEditPerson;
        private System.Windows.Forms.ToolStripMenuItem ctxmSubscriptionDetails;
        private System.Windows.Forms.ToolStripMenuItem ctxmRenewSubscription;
        private System.Windows.Forms.ToolStripMenuItem ctxmPayment;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoPerson;
        private System.Windows.Forms.RadioButton rdoCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}