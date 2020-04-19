namespace Shaheen
{
    partial class frmDistrict
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDistrictName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ddlState = new System.Windows.Forms.ComboBox();
            this.lblStateName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDistrict = new System.Windows.Forms.DataGridView();
            this.colDistrictName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistrict)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDistrictName);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.ddlState);
            this.groupBox1.Controls.Add(this.lblStateName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 337);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add / Edit District";
            // 
            // txtDistrictName
            // 
            this.txtDistrictName.BackColor = System.Drawing.Color.SkyBlue;
            this.txtDistrictName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDistrictName.Location = new System.Drawing.Point(19, 61);
            this.txtDistrictName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDistrictName.Name = "txtDistrictName";
            this.txtDistrictName.Size = new System.Drawing.Size(245, 16);
            this.txtDistrictName.TabIndex = 19;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(182, 292);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Location = new System.Drawing.Point(26, 292);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 30);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(104, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(19, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 1);
            this.panel1.TabIndex = 21;
            // 
            // ddlState
            // 
            this.ddlState.BackColor = System.Drawing.Color.SkyBlue;
            this.ddlState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlState.IntegralHeight = false;
            this.ddlState.Location = new System.Drawing.Point(19, 120);
            this.ddlState.Margin = new System.Windows.Forms.Padding(0);
            this.ddlState.MinimumSize = new System.Drawing.Size(250, 0);
            this.ddlState.Name = "ddlState";
            this.ddlState.Size = new System.Drawing.Size(250, 23);
            this.ddlState.TabIndex = 5;
            // 
            // lblStateName
            // 
            this.lblStateName.AutoSize = true;
            this.lblStateName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStateName.Location = new System.Drawing.Point(18, 41);
            this.lblStateName.Margin = new System.Windows.Forms.Padding(0);
            this.lblStateName.Name = "lblStateName";
            this.lblStateName.Size = new System.Drawing.Size(94, 15);
            this.lblStateName.TabIndex = 20;
            this.lblStateName.Text = "District Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "State :";
            // 
            // dgvDistrict
            // 
            this.dgvDistrict.AllowUserToAddRows = false;
            this.dgvDistrict.AllowUserToDeleteRows = false;
            this.dgvDistrict.AllowUserToOrderColumns = true;
            this.dgvDistrict.AllowUserToResizeColumns = false;
            this.dgvDistrict.AllowUserToResizeRows = false;
            this.dgvDistrict.BackgroundColor = System.Drawing.Color.White;
            this.dgvDistrict.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDistrict.ColumnHeadersHeight = 35;
            this.dgvDistrict.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDistrictName,
            this.colStateName,
            this.stateId,
            this.districtId,
            this.colDelete});
            this.dgvDistrict.EnableHeadersVisualStyles = false;
            this.dgvDistrict.Location = new System.Drawing.Point(298, 11);
            this.dgvDistrict.MultiSelect = false;
            this.dgvDistrict.Name = "dgvDistrict";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDistrict.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDistrict.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDistrict.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDistrict.Size = new System.Drawing.Size(478, 339);
            this.dgvDistrict.TabIndex = 5;
            this.dgvDistrict.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDistrict_CellContentClick);
            this.dgvDistrict.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDistrict_RowHeaderMouseDoubleClick);
            // 
            // colDistrictName
            // 
            this.colDistrictName.DataPropertyName = "districtName";
            this.colDistrictName.HeaderText = "District";
            this.colDistrictName.Name = "colDistrictName";
            this.colDistrictName.ReadOnly = true;
            this.colDistrictName.Width = 190;
            // 
            // colStateName
            // 
            this.colStateName.DataPropertyName = "stateName";
            this.colStateName.HeaderText = "State";
            this.colStateName.Name = "colStateName";
            this.colStateName.ReadOnly = true;
            this.colStateName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colStateName.Width = 145;
            // 
            // stateId
            // 
            this.stateId.DataPropertyName = "stateId";
            this.stateId.HeaderText = "stateId";
            this.stateId.Name = "stateId";
            this.stateId.Visible = false;
            // 
            // districtId
            // 
            this.districtId.DataPropertyName = "districtId";
            this.districtId.HeaderText = "districtId";
            this.districtId.Name = "districtId";
            this.districtId.Visible = false;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Name = "colDelete";
            this.colDelete.Text = "Delete";
            this.colDelete.ToolTipText = "Delete";
            this.colDelete.UseColumnTextForButtonValue = true;
            // 
            // frmDistrict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(786, 360);
            this.Controls.Add(this.dgvDistrict);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDistrict";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State";
            this.Load += new System.EventHandler(this.frmDistrict_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistrict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDistrict;
        private System.Windows.Forms.ComboBox ddlState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDistrictName;
        private System.Windows.Forms.Label lblStateName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDistrictName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtId;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}