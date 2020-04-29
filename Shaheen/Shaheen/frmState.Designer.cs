﻿namespace Shaheen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCountryName = new System.Windows.Forms.ComboBox();
            this.lblStateName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvState = new System.Windows.Forms.DataGridView();
            this.colStateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvState)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtState);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.cmbCountryName);
            this.groupBox1.Controls.Add(this.lblStateName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 337);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add / Edit State";
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.Color.SkyBlue;
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtState.Location = new System.Drawing.Point(19, 61);
            this.txtState.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(245, 16);
            this.txtState.TabIndex = 19;
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
            // cmbCountryName
            // 
            this.cmbCountryName.BackColor = System.Drawing.Color.SkyBlue;
            this.cmbCountryName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCountryName.IntegralHeight = false;
            this.cmbCountryName.Location = new System.Drawing.Point(19, 120);
            this.cmbCountryName.Margin = new System.Windows.Forms.Padding(0);
            this.cmbCountryName.MinimumSize = new System.Drawing.Size(250, 0);
            this.cmbCountryName.Name = "cmbCountryName";
            this.cmbCountryName.Size = new System.Drawing.Size(250, 23);
            this.cmbCountryName.TabIndex = 5;
            // 
            // lblStateName
            // 
            this.lblStateName.AutoSize = true;
            this.lblStateName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStateName.Location = new System.Drawing.Point(18, 41);
            this.lblStateName.Margin = new System.Windows.Forms.Padding(0);
            this.lblStateName.Name = "lblStateName";
            this.lblStateName.Size = new System.Drawing.Size(83, 15);
            this.lblStateName.TabIndex = 20;
            this.lblStateName.Text = "State Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Country :";
            // 
            // dgvState
            // 
            this.dgvState.AllowUserToAddRows = false;
            this.dgvState.AllowUserToDeleteRows = false;
            this.dgvState.AllowUserToOrderColumns = true;
            this.dgvState.AllowUserToResizeColumns = false;
            this.dgvState.AllowUserToResizeRows = false;
            this.dgvState.BackgroundColor = System.Drawing.Color.White;
            this.dgvState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvState.ColumnHeadersHeight = 35;
            this.dgvState.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStateName,
            this.colCountryName,
            this.stateId,
            this.countryId,
            this.colDelete});
            this.dgvState.EnableHeadersVisualStyles = false;
            this.dgvState.Location = new System.Drawing.Point(298, 11);
            this.dgvState.MultiSelect = false;
            this.dgvState.Name = "dgvState";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvState.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvState.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvState.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvState.Size = new System.Drawing.Size(478, 339);
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
            this.colStateName.Width = 190;
            // 
            // colCountryName
            // 
            this.colCountryName.DataPropertyName = "countryName";
            this.colCountryName.HeaderText = "Country";
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.ReadOnly = true;
            this.colCountryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCountryName.Width = 145;
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
            // frmState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(786, 360);
            this.Controls.Add(this.dgvState);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State";
            this.Load += new System.EventHandler(this.frmState_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvState;
        private System.Windows.Forms.ComboBox cmbCountryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblStateName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryId;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}