namespace Shaheen
{
    partial class frmState
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ddlCountry = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.dgvState = new System.Windows.Forms.DataGridView();
            this.colStateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvState)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(317, 125);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(404, 127);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ddlCountry);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtState);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 109);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add / Edit State";
            // 
            // ddlCountry
            // 
            this.ddlCountry.FormattingEnabled = true;
            this.ddlCountry.IntegralHeight = false;
            this.ddlCountry.Location = new System.Drawing.Point(142, 60);
            this.ddlCountry.Name = "ddlCountry";
            this.ddlCountry.Size = new System.Drawing.Size(267, 24);
            this.ddlCountry.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Country :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "State Name :";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(142, 34);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(267, 23);
            this.txtState.TabIndex = 2;
            // 
            // dgvState
            // 
            this.dgvState.AllowUserToAddRows = false;
            this.dgvState.AllowUserToDeleteRows = false;
            this.dgvState.AllowUserToOrderColumns = true;
            this.dgvState.AllowUserToResizeColumns = false;
            this.dgvState.AllowUserToResizeRows = false;
            this.dgvState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvState.ColumnHeadersHeight = 35;
            this.dgvState.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStateName,
            this.colCountryName,
            this.stateId,
            this.countryId,
            this.colDelete});
            this.dgvState.Location = new System.Drawing.Point(12, 170);
            this.dgvState.MultiSelect = false;
            this.dgvState.Name = "dgvState";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvState.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvState.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvState.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvState.Size = new System.Drawing.Size(476, 318);
            this.dgvState.TabIndex = 5;
            this.dgvState.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvState_CellContentClick);
            this.dgvState.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvState_RowHeaderMouseDoubleClick);
            // 
            // colStateName
            // 
            this.colStateName.DataPropertyName = "stateName";
            this.colStateName.HeaderText = "State";
            this.colStateName.Name = "colStateName";
            this.colStateName.ReadOnly = true;
            this.colStateName.Width = 185;
            // 
            // colCountryName
            // 
            this.colCountryName.DataPropertyName = "countryName";
            this.colCountryName.HeaderText = "Country";
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.ReadOnly = true;
            this.colCountryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCountryName.Width = 150;
            // 
            // stateId
            // 
            this.stateId.DataPropertyName = "stateId";
            this.stateId.HeaderText = "stateId";
            this.stateId.Name = "stateId";
            this.stateId.Visible = false;
            // 
            // countryId
            // 
            this.countryId.DataPropertyName = "countryId";
            this.countryId.HeaderText = "countryId";
            this.countryId.Name = "countryId";
            this.countryId.Visible = false;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Name = "colDelete";
            this.colDelete.Text = "Delete";
            this.colDelete.ToolTipText = "Delete";
            this.colDelete.UseColumnTextForButtonValue = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(230, 125);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(84, 35);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvState);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Name = "frmState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCountry";
            this.Load += new System.EventHandler(this.frmState_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox ddlCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryId;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}