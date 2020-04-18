﻿namespace Shaheen
{
    partial class frmCountry
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpCountry = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.dgvCountry = new System.Windows.Forms.DataGridView();
            this.colCountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.grpCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(317, 101);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(404, 101);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // grpCountry
            // 
            this.grpCountry.Controls.Add(this.label1);
            this.grpCountry.Controls.Add(this.txtCountry);
            this.grpCountry.Location = new System.Drawing.Point(12, 12);
            this.grpCountry.Name = "grpCountry";
            this.grpCountry.Size = new System.Drawing.Size(476, 83);
            this.grpCountry.TabIndex = 4;
            this.grpCountry.TabStop = false;
            this.grpCountry.Text = "Add / Edit Country";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Country Name :";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(142, 34);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(267, 23);
            this.txtCountry.TabIndex = 2;
            // 
            // dgvCountry
            // 
            this.dgvCountry.AllowUserToAddRows = false;
            this.dgvCountry.AllowUserToDeleteRows = false;
            this.dgvCountry.AllowUserToOrderColumns = true;
            this.dgvCountry.AllowUserToResizeColumns = false;
            this.dgvCountry.AllowUserToResizeRows = false;
            this.dgvCountry.ColumnHeadersHeight = 35;
            this.dgvCountry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCountryName,
            this.colDelete});
            this.dgvCountry.Location = new System.Drawing.Point(12, 142);
            this.dgvCountry.Name = "dgvCountry";
            this.dgvCountry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCountry.Size = new System.Drawing.Size(476, 346);
            this.dgvCountry.TabIndex = 5;
            this.dgvCountry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCountry_CellContentClick);
            this.dgvCountry.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCountry_RowHeaderMouseDoubleClick);
            // 
            // colCountryName
            // 
            this.colCountryName.DataPropertyName = "countryName";
            this.colCountryName.HeaderText = "Country";
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.ReadOnly = true;
            this.colCountryName.Width = 330;
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
            this.btnNew.Location = new System.Drawing.Point(230, 101);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(84, 35);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvCountry);
            this.Controls.Add(this.grpCountry);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Name = "frmCountry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCountry";
            this.Load += new System.EventHandler(this.frmCountry_Load);
            this.grpCountry.ResumeLayout(false);
            this.grpCountry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpCountry;
        private System.Windows.Forms.DataGridView dgvCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountryName;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}