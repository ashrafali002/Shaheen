namespace Shaheen
{
    partial class frmArea
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAreaName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCityName = new System.Windows.Forms.ComboBox();
            this.lblAreaName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvArea = new System.Windows.Forms.DataGridView();
            this.colAreaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAreaName);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.cmbCityName);
            this.groupBox1.Controls.Add(this.lblAreaName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 340);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add / Edit Area";
            // 
            // txtAreaName
            // 
            this.txtAreaName.BackColor = System.Drawing.Color.SkyBlue;
            this.txtAreaName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAreaName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaName.Location = new System.Drawing.Point(19, 61);
            this.txtAreaName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.Size = new System.Drawing.Size(245, 20);
            this.txtAreaName.TabIndex = 19;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(182, 304);
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
            this.btnNew.Location = new System.Drawing.Point(26, 304);
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
            this.btnSave.Location = new System.Drawing.Point(104, 304);
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
            this.panel1.Location = new System.Drawing.Point(19, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 1);
            this.panel1.TabIndex = 21;
            // 
            // cmbCityName
            // 
            this.cmbCityName.BackColor = System.Drawing.Color.SkyBlue;
            this.cmbCityName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCityName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCityName.IntegralHeight = false;
            this.cmbCityName.Location = new System.Drawing.Point(19, 120);
            this.cmbCityName.Margin = new System.Windows.Forms.Padding(0);
            this.cmbCityName.MinimumSize = new System.Drawing.Size(250, 0);
            this.cmbCityName.Name = "cmbCityName";
            this.cmbCityName.Size = new System.Drawing.Size(250, 27);
            this.cmbCityName.TabIndex = 5;
            // 
            // lblAreaName
            // 
            this.lblAreaName.AutoSize = true;
            this.lblAreaName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAreaName.Location = new System.Drawing.Point(19, 40);
            this.lblAreaName.Margin = new System.Windows.Forms.Padding(0);
            this.lblAreaName.Name = "lblAreaName";
            this.lblAreaName.Size = new System.Drawing.Size(79, 15);
            this.lblAreaName.TabIndex = 20;
            this.lblAreaName.Text = "Area Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(19, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "City :";
            // 
            // dgvArea
            // 
            this.dgvArea.AllowUserToAddRows = false;
            this.dgvArea.AllowUserToDeleteRows = false;
            this.dgvArea.AllowUserToOrderColumns = true;
            this.dgvArea.AllowUserToResizeColumns = false;
            this.dgvArea.AllowUserToResizeRows = false;
            this.dgvArea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArea.BackgroundColor = System.Drawing.Color.White;
            this.dgvArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArea.ColumnHeadersHeight = 35;
            this.dgvArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAreaName,
            this.colCityName,
            this.areaId,
            this.cityId,
            this.colDelete});
            this.dgvArea.EnableHeadersVisualStyles = false;
            this.dgvArea.Location = new System.Drawing.Point(298, 44);
            this.dgvArea.MultiSelect = false;
            this.dgvArea.Name = "dgvArea";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArea.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvArea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArea.Size = new System.Drawing.Size(478, 339);
            this.dgvArea.TabIndex = 5;
            this.dgvArea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArea_CellContentClick);
            this.dgvArea.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvArea_RowHeaderMouseDoubleClick);
            // 
            // colAreaName
            // 
            this.colAreaName.DataPropertyName = "areaName";
            this.colAreaName.FillWeight = 130.4348F;
            this.colAreaName.HeaderText = "Area";
            this.colAreaName.Name = "colAreaName";
            this.colAreaName.ReadOnly = true;
            // 
            // colCityName
            // 
            this.colCityName.DataPropertyName = "cityName";
            this.colCityName.FillWeight = 96.89352F;
            this.colCityName.HeaderText = "City";
            this.colCityName.Name = "colCityName";
            this.colCityName.ReadOnly = true;
            this.colCityName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCityName.ToolTipText = "City";
            // 
            // areaId
            // 
            this.areaId.DataPropertyName = "areaId";
            this.areaId.HeaderText = "areaId";
            this.areaId.Name = "areaId";
            this.areaId.Visible = false;
            // 
            // cityId
            // 
            this.cityId.DataPropertyName = "cityId";
            this.cityId.HeaderText = "cityId";
            this.cityId.Name = "cityId";
            this.cityId.Visible = false;
            // 
            // colDelete
            // 
            this.colDelete.FillWeight = 72.67169F;
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Name = "colDelete";
            this.colDelete.Text = "Delete";
            this.colDelete.ToolTipText = "Delete";
            this.colDelete.UseColumnTextForButtonValue = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 37);
            this.panel2.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Area";
            // 
            // frmArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(786, 392);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvArea);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area";
            this.Load += new System.EventHandler(this.frmArea_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvArea;
        private System.Windows.Forms.ComboBox cmbCityName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAreaName;
        private System.Windows.Forms.Label lblAreaName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAreaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityId;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}