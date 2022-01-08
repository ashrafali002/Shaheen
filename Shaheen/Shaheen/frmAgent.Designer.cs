namespace Shaheen
{
    partial class frmAgent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpAgent = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDistrict = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAgent = new System.Windows.Forms.DataGridView();
            this.colAgentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAgentAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.agentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconAgent = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNew = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.grpAgent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgent)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAgent)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAgent
            // 
            this.grpAgent.Controls.Add(this.label2);
            this.grpAgent.Controls.Add(this.txtEmail);
            this.grpAgent.Controls.Add(this.panel8);
            this.grpAgent.Controls.Add(this.txtMobile);
            this.grpAgent.Controls.Add(this.label11);
            this.grpAgent.Controls.Add(this.panel6);
            this.grpAgent.Controls.Add(this.txtPhone);
            this.grpAgent.Controls.Add(this.panel7);
            this.grpAgent.Controls.Add(this.label12);
            this.grpAgent.Controls.Add(this.txtPIN);
            this.grpAgent.Controls.Add(this.panel5);
            this.grpAgent.Controls.Add(this.label10);
            this.grpAgent.Controls.Add(this.cmbArea);
            this.grpAgent.Controls.Add(this.label9);
            this.grpAgent.Controls.Add(this.cmbCity);
            this.grpAgent.Controls.Add(this.label7);
            this.grpAgent.Controls.Add(this.cmbDistrict);
            this.grpAgent.Controls.Add(this.label8);
            this.grpAgent.Controls.Add(this.cmbState);
            this.grpAgent.Controls.Add(this.label6);
            this.grpAgent.Controls.Add(this.cmbCountry);
            this.grpAgent.Controls.Add(this.label5);
            this.grpAgent.Controls.Add(this.label4);
            this.grpAgent.Controls.Add(this.txtAddress);
            this.grpAgent.Controls.Add(this.panel4);
            this.grpAgent.Controls.Add(this.txtName);
            this.grpAgent.Controls.Add(this.panel2);
            this.grpAgent.Controls.Add(this.label1);
            this.grpAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.grpAgent.Location = new System.Drawing.Point(10, 43);
            this.grpAgent.Name = "grpAgent";
            this.grpAgent.Size = new System.Drawing.Size(457, 408);
            this.grpAgent.TabIndex = 1;
            this.grpAgent.TabStop = false;
            this.grpAgent.Text = "Add / Edit Agent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(14, 352);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.SkyBlue;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(14, 372);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(428, 20);
            this.txtEmail.TabIndex = 26;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SkyBlue;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel8.Location = new System.Drawing.Point(14, 395);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(428, 1);
            this.panel8.TabIndex = 27;
            // 
            // txtMobile
            // 
            this.txtMobile.BackColor = System.Drawing.Color.SkyBlue;
            this.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMobile.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(242, 319);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(200, 20);
            this.txtMobile.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label11.Location = new System.Drawing.Point(14, 299);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Phone :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SkyBlue;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Location = new System.Drawing.Point(242, 342);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 1);
            this.panel6.TabIndex = 24;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.SkyBlue;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(14, 319);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 20);
            this.txtPhone.TabIndex = 20;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SkyBlue;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel7.Location = new System.Drawing.Point(14, 342);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 1);
            this.panel7.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label12.Location = new System.Drawing.Point(242, 299);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "Mobile :";
            // 
            // txtPIN
            // 
            this.txtPIN.BackColor = System.Drawing.Color.SkyBlue;
            this.txtPIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPIN.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPIN.Location = new System.Drawing.Point(242, 266);
            this.txtPIN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPIN.MaxLength = 6;
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(200, 20);
            this.txtPIN.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SkyBlue;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Location = new System.Drawing.Point(242, 289);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 1);
            this.panel5.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label10.Location = new System.Drawing.Point(242, 245);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "PIN :";
            // 
            // cmbArea
            // 
            this.cmbArea.BackColor = System.Drawing.Color.SkyBlue;
            this.cmbArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbArea.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArea.IntegralHeight = false;
            this.cmbArea.Location = new System.Drawing.Point(14, 263);
            this.cmbArea.Margin = new System.Windows.Forms.Padding(0);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(200, 27);
            this.cmbArea.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label9.Location = new System.Drawing.Point(14, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Area :";
            // 
            // cmbCity
            // 
            this.cmbCity.BackColor = System.Drawing.Color.SkyBlue;
            this.cmbCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCity.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCity.IntegralHeight = false;
            this.cmbCity.Location = new System.Drawing.Point(242, 208);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(0);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(200, 27);
            this.cmbCity.TabIndex = 13;
            this.cmbCity.Leave += new System.EventHandler(this.cmbCity_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label7.Location = new System.Drawing.Point(242, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "City :";
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.BackColor = System.Drawing.Color.SkyBlue;
            this.cmbDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDistrict.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDistrict.IntegralHeight = false;
            this.cmbDistrict.Location = new System.Drawing.Point(14, 208);
            this.cmbDistrict.Margin = new System.Windows.Forms.Padding(0);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Size = new System.Drawing.Size(200, 27);
            this.cmbDistrict.TabIndex = 11;
            this.cmbDistrict.Leave += new System.EventHandler(this.cmbDistrict_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label8.Location = new System.Drawing.Point(14, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "District :";
            // 
            // cmbState
            // 
            this.cmbState.BackColor = System.Drawing.Color.SkyBlue;
            this.cmbState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbState.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbState.IntegralHeight = false;
            this.cmbState.Location = new System.Drawing.Point(242, 153);
            this.cmbState.Margin = new System.Windows.Forms.Padding(0);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(200, 27);
            this.cmbState.TabIndex = 9;
            this.cmbState.Leave += new System.EventHandler(this.cmbState_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label6.Location = new System.Drawing.Point(242, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "State :";
            // 
            // cmbCountry
            // 
            this.cmbCountry.BackColor = System.Drawing.Color.SkyBlue;
            this.cmbCountry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCountry.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCountry.IntegralHeight = false;
            this.cmbCountry.Location = new System.Drawing.Point(14, 153);
            this.cmbCountry.Margin = new System.Windows.Forms.Padding(0);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(200, 27);
            this.cmbCountry.TabIndex = 7;
            this.cmbCountry.Leave += new System.EventHandler(this.cmbCountry_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label5.Location = new System.Drawing.Point(14, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Country :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label4.Location = new System.Drawing.Point(14, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address :";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.SkyBlue;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(14, 98);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(428, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SkyBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(14, 121);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(428, 1);
            this.panel4.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.SkyBlue;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(17, 43);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(425, 20);
            this.txtName.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(17, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 1);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // dgvAgent
            // 
            this.dgvAgent.AllowUserToAddRows = false;
            this.dgvAgent.AllowUserToDeleteRows = false;
            this.dgvAgent.AllowUserToOrderColumns = true;
            this.dgvAgent.AllowUserToResizeColumns = false;
            this.dgvAgent.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(210)))), ((int)(((byte)(248)))));
            this.dgvAgent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.dgvAgent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAgent.ColumnHeadersHeight = 35;
            this.dgvAgent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAgentName,
            this.colAgentAddress,
            this.colCityName,
            this.colDelete,
            this.agentId,
            this.countryId,
            this.stateId,
            this.districtId,
            this.cityId,
            this.areaId,
            this.PIN,
            this.phone,
            this.mobile,
            this.email});
            this.dgvAgent.EnableHeadersVisualStyles = false;
            this.dgvAgent.GridColor = System.Drawing.Color.Black;
            this.dgvAgent.Location = new System.Drawing.Point(473, 43);
            this.dgvAgent.MultiSelect = false;
            this.dgvAgent.Name = "dgvAgent";
            this.dgvAgent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgent.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAgent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAgent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgent.Size = new System.Drawing.Size(646, 468);
            this.dgvAgent.TabIndex = 6;
            this.dgvAgent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgent_CellContentClick);
            this.dgvAgent.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAgent_CellFormatting);
            this.dgvAgent.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAgent_RowHeaderMouseDoubleClick);
            // 
            // colAgentName
            // 
            this.colAgentName.DataPropertyName = "agentName";
            this.colAgentName.FillWeight = 132.2314F;
            this.colAgentName.HeaderText = "Name";
            this.colAgentName.Name = "colAgentName";
            this.colAgentName.ReadOnly = true;
            this.colAgentName.Width = 225;
            // 
            // colAgentAddress
            // 
            this.colAgentAddress.DataPropertyName = "agentAddress";
            this.colAgentAddress.FillWeight = 129.717F;
            this.colAgentAddress.HeaderText = "Address";
            this.colAgentAddress.Name = "colAgentAddress";
            this.colAgentAddress.ReadOnly = true;
            this.colAgentAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colAgentAddress.ToolTipText = "Address";
            this.colAgentAddress.Width = 200;
            // 
            // colCityName
            // 
            this.colCityName.DataPropertyName = "cityName";
            this.colCityName.FillWeight = 64.01687F;
            this.colCityName.HeaderText = "City";
            this.colCityName.Name = "colCityName";
            this.colCityName.ReadOnly = true;
            this.colCityName.ToolTipText = "City";
            this.colCityName.Width = 105;
            // 
            // colDelete
            // 
            this.colDelete.FillWeight = 74.03477F;
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Image = global::Shaheen.Properties.Resources.delete;
            this.colDelete.Name = "colDelete";
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDelete.ToolTipText = "Delete";
            this.colDelete.Width = 75;
            // 
            // agentId
            // 
            this.agentId.DataPropertyName = "agentId";
            this.agentId.HeaderText = "agentId";
            this.agentId.Name = "agentId";
            this.agentId.Visible = false;
            // 
            // countryId
            // 
            this.countryId.DataPropertyName = "countryId";
            this.countryId.HeaderText = "countryId";
            this.countryId.Name = "countryId";
            this.countryId.Visible = false;
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
            // cityId
            // 
            this.cityId.DataPropertyName = "cityId";
            this.cityId.HeaderText = "cityId";
            this.cityId.Name = "cityId";
            this.cityId.Visible = false;
            // 
            // areaId
            // 
            this.areaId.DataPropertyName = "areaId";
            this.areaId.HeaderText = "areaId";
            this.areaId.Name = "areaId";
            this.areaId.Visible = false;
            // 
            // PIN
            // 
            this.PIN.DataPropertyName = "pin";
            this.PIN.HeaderText = "PIN";
            this.PIN.Name = "PIN";
            this.PIN.Visible = false;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "phone";
            this.phone.Name = "phone";
            this.phone.Visible = false;
            // 
            // mobile
            // 
            this.mobile.DataPropertyName = "mobile";
            this.mobile.HeaderText = "mobile";
            this.mobile.Name = "mobile";
            this.mobile.Visible = false;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.iconAgent);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 37);
            this.panel1.TabIndex = 0;
            // 
            // iconAgent
            // 
            this.iconAgent.BackColor = System.Drawing.Color.Navy;
            this.iconAgent.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconAgent.IconColor = System.Drawing.Color.White;
            this.iconAgent.Location = new System.Drawing.Point(10, 6);
            this.iconAgent.Name = "iconAgent";
            this.iconAgent.Size = new System.Drawing.Size(32, 32);
            this.iconAgent.TabIndex = 1;
            this.iconAgent.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Agent";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Location = new System.Drawing.Point(10, 451);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 60);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNew.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNew.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnNew.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnNew.IconColor = System.Drawing.Color.DarkBlue;
            this.btnNew.IconSize = 32;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(160, 15);
            this.btnNew.Name = "btnNew";
            this.btnNew.Rotation = 0D;
            this.btnNew.Size = new System.Drawing.Size(90, 37);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSave.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.DarkBlue;
            this.btnSave.IconSize = 32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(256, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(90, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnClose.IconColor = System.Drawing.Color.Maroon;
            this.btnClose.IconSize = 32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(352, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0D;
            this.btnClose.Size = new System.Drawing.Size(90, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvAgent);
            this.Controls.Add(this.grpAgent);
            this.Name = "frmAgent";
            this.Text = "Agent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAgent_Load);
            this.grpAgent.ResumeLayout(false);
            this.grpAgent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAgent)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAgent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAgent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAgentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAgentAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCityName;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnNew;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconPictureBox iconAgent;
    }
}