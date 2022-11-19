﻿namespace Shaheen
{
    partial class frmCustomReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbAgent = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.cmbDistrict = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.lblRecordCountValue = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.chkExpired = new System.Windows.Forms.CheckBox();
            this.btnExport = new FontAwesome.Sharp.IconButton();
            this.panel17 = new System.Windows.Forms.Panel();
            this.iconAgentWise = new FontAwesome.Sharp.IconPictureBox();
            this.label27 = new System.Windows.Forms.Label();
            this.dgvCustomReport = new System.Windows.Forms.DataGridView();
            this.subscriptionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriptionEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriptionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriptionDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAgentWise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomReport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.groupBox1.Location = new System.Drawing.Point(9, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custom Report";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.DarkBlue;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 32;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(838, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 39);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnReset.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.IconSize = 32;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(838, 76);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 39);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbAgent, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbArea, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbDistrict, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbCity, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbCountry, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbState, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRecordCountValue, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblRecordCount, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkExpired, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(824, 97);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label13.Location = new System.Drawing.Point(3, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Agent :";
            // 
            // cmbAgent
            // 
            this.cmbAgent.BackColor = System.Drawing.Color.SkyBlue;
            this.cmbAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAgent.IntegralHeight = false;
            this.cmbAgent.Location = new System.Drawing.Point(57, 3);
            this.cmbAgent.Name = "cmbAgent";
            this.cmbAgent.Size = new System.Drawing.Size(199, 24);
            this.cmbAgent.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label8.Location = new System.Drawing.Point(262, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "District :";
            // 
            // cmbArea
            // 
            this.cmbArea.BackColor = System.Drawing.Color.SkyBlue;
            this.cmbArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArea.IntegralHeight = false;
            this.cmbArea.Location = new System.Drawing.Point(590, 33);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(199, 24);
            this.cmbArea.TabIndex = 11;
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.BackColor = System.Drawing.Color.SkyBlue;
            this.cmbDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDistrict.IntegralHeight = false;
            this.cmbDistrict.Location = new System.Drawing.Point(321, 3);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Size = new System.Drawing.Size(199, 24);
            this.cmbDistrict.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label9.Location = new System.Drawing.Point(526, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Area :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label5.Location = new System.Drawing.Point(526, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Country :";
            // 
            // cmbCity
            // 
            this.cmbCity.BackColor = System.Drawing.Color.SkyBlue;
            this.cmbCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCity.IntegralHeight = false;
            this.cmbCity.Location = new System.Drawing.Point(321, 33);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(199, 24);
            this.cmbCity.TabIndex = 9;
            // 
            // cmbCountry
            // 
            this.cmbCountry.BackColor = System.Drawing.Color.SkyBlue;
            this.cmbCountry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCountry.IntegralHeight = false;
            this.cmbCountry.Location = new System.Drawing.Point(590, 3);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(199, 24);
            this.cmbCountry.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label7.Location = new System.Drawing.Point(262, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "City :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label6.Location = new System.Drawing.Point(3, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "State :";
            // 
            // cmbState
            // 
            this.cmbState.BackColor = System.Drawing.Color.SkyBlue;
            this.cmbState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbState.Location = new System.Drawing.Point(57, 33);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(199, 24);
            this.cmbState.TabIndex = 5;
            // 
            // lblRecordCountValue
            // 
            this.lblRecordCountValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecordCountValue.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblRecordCountValue, 2);
            this.lblRecordCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCountValue.ForeColor = System.Drawing.Color.Red;
            this.lblRecordCountValue.Location = new System.Drawing.Point(526, 65);
            this.lblRecordCountValue.Name = "lblRecordCountValue";
            this.lblRecordCountValue.Size = new System.Drawing.Size(263, 20);
            this.lblRecordCountValue.TabIndex = 17;
            this.lblRecordCountValue.Text = "Record";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecordCount.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblRecordCount, 2);
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.lblRecordCount.Location = new System.Drawing.Point(262, 65);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(258, 20);
            this.lblRecordCount.TabIndex = 16;
            this.lblRecordCount.Text = "Record Count :";
            // 
            // chkExpired
            // 
            this.chkExpired.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkExpired.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkExpired, 2);
            this.chkExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExpired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.chkExpired.Location = new System.Drawing.Point(3, 63);
            this.chkExpired.Name = "chkExpired";
            this.chkExpired.Size = new System.Drawing.Size(253, 24);
            this.chkExpired.TabIndex = 12;
            this.chkExpired.Text = "Expired List";
            this.chkExpired.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExport.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExport.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnExport.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExport.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnExport.IconSize = 32;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(713, 554);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(134, 39);
            this.btnExport.TabIndex = 34;
            this.btnExport.Text = "Print PDF";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Navy;
            this.panel17.Controls.Add(this.iconAgentWise);
            this.panel17.Controls.Add(this.label27);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(965, 39);
            this.panel17.TabIndex = 0;
            // 
            // iconAgentWise
            // 
            this.iconAgentWise.BackColor = System.Drawing.Color.Navy;
            this.iconAgentWise.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconAgentWise.IconColor = System.Drawing.Color.White;
            this.iconAgentWise.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAgentWise.IconSize = 34;
            this.iconAgentWise.Location = new System.Drawing.Point(11, 6);
            this.iconAgentWise.Name = "iconAgentWise";
            this.iconAgentWise.Size = new System.Drawing.Size(37, 34);
            this.iconAgentWise.TabIndex = 5;
            this.iconAgentWise.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(55, 6);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(188, 25);
            this.label27.TabIndex = 0;
            this.label27.Text = "Agent-wise Report";
            // 
            // dgvCustomReport
            // 
            this.dgvCustomReport.AllowUserToAddRows = false;
            this.dgvCustomReport.AllowUserToDeleteRows = false;
            this.dgvCustomReport.AllowUserToResizeColumns = false;
            this.dgvCustomReport.AllowUserToResizeRows = false;
            this.dgvCustomReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCustomReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.dgvCustomReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomReport.ColumnHeadersHeight = 50;
            this.dgvCustomReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subscriptionCode,
            this.personName,
            this.personAddress,
            this.subscriptionEndDate,
            this.pendingAmount,
            this.mobil,
            this.personId,
            this.subscriptionId,
            this.subscriptionDetailId,
            this.status});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomReport.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustomReport.EnableHeadersVisualStyles = false;
            this.dgvCustomReport.GridColor = System.Drawing.Color.Black;
            this.dgvCustomReport.Location = new System.Drawing.Point(9, 182);
            this.dgvCustomReport.MultiSelect = false;
            this.dgvCustomReport.Name = "dgvCustomReport";
            this.dgvCustomReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCustomReport.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCustomReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomReport.Size = new System.Drawing.Size(947, 364);
            this.dgvCustomReport.TabIndex = 2;
            this.dgvCustomReport.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCustomReport_DataBindingComplete);
            // 
            // subscriptionCode
            // 
            this.subscriptionCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.personName.DefaultCellStyle = dataGridViewCellStyle2;
            this.personName.FillWeight = 207.4462F;
            this.personName.HeaderText = "Customer";
            this.personName.Name = "personName";
            this.personName.ReadOnly = true;
            this.personName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.personName.Width = 175;
            // 
            // personAddress
            // 
            this.personAddress.DataPropertyName = "personAddress";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.personAddress.DefaultCellStyle = dataGridViewCellStyle3;
            this.personAddress.FillWeight = 94.12218F;
            this.personAddress.HeaderText = "Address";
            this.personAddress.Name = "personAddress";
            this.personAddress.ReadOnly = true;
            this.personAddress.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.personAddress.Width = 250;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.pendingAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.pendingAmount.FillWeight = 74.94263F;
            this.pendingAmount.HeaderText = "Pending Amount";
            this.pendingAmount.Name = "pendingAmount";
            this.pendingAmount.ReadOnly = true;
            this.pendingAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // mobil
            // 
            this.mobil.DataPropertyName = "mobile";
            this.mobil.HeaderText = "Contact";
            this.mobil.Name = "mobil";
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
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Maroon;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btnClose.IconColor = System.Drawing.Color.Maroon;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnClose.IconSize = 32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(854, 554);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 39);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCustomReport
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(965, 599);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvCustomReport);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExport);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmCustomReport";
            this.Text = "CustomReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAgentWise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDistrict;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAgent;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkExpired;
        private System.Windows.Forms.DataGridView dgvCustomReport;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label lblRecordCountValue;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnReset;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnExport;
        private FontAwesome.Sharp.IconPictureBox iconAgentWise;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn personName;
        private System.Windows.Forms.DataGridViewTextBoxColumn personAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendingAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobil;
        private System.Windows.Forms.DataGridViewTextBoxColumn personId;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}