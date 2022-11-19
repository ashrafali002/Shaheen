namespace Shaheen
{
    partial class frmEditSubscription
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
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconEditSubscription = new FontAwesome.Sharp.IconPictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.grpSubscription = new System.Windows.Forms.GroupBox();
            this.cmbSubscriptionType = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbAgent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpSubscriptionDate = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.grpPerson = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grpButtons.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconEditSubscription)).BeginInit();
            this.grpSubscription.SuspendLayout();
            this.grpPerson.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnSave);
            this.grpButtons.Controls.Add(this.btnClose);
            this.grpButtons.Location = new System.Drawing.Point(11, 421);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(599, 64);
            this.grpButtons.TabIndex = 2;
            this.grpButtons.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.DarkBlue;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSave.IconSize = 32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(367, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 39);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btnClose.IconColor = System.Drawing.Color.Maroon;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnClose.IconSize = 32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(477, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 39);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.iconEditSubscription);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 39);
            this.panel2.TabIndex = 0;
            // 
            // iconEditSubscription
            // 
            this.iconEditSubscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.iconEditSubscription.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.iconEditSubscription.IconColor = System.Drawing.Color.White;
            this.iconEditSubscription.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEditSubscription.IconSize = 34;
            this.iconEditSubscription.Location = new System.Drawing.Point(11, 6);
            this.iconEditSubscription.Name = "iconEditSubscription";
            this.iconEditSubscription.Size = new System.Drawing.Size(37, 34);
            this.iconEditSubscription.TabIndex = 8;
            this.iconEditSubscription.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(55, 6);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(246, 25);
            this.label20.TabIndex = 0;
            this.label20.Text = "Edit Subscription Details";
            // 
            // grpSubscription
            // 
            this.grpSubscription.Controls.Add(this.cmbSubscriptionType);
            this.grpSubscription.Controls.Add(this.label22);
            this.grpSubscription.Controls.Add(this.cmbAgent);
            this.grpSubscription.Controls.Add(this.label1);
            this.grpSubscription.Controls.Add(this.label19);
            this.grpSubscription.Controls.Add(this.panel10);
            this.grpSubscription.Controls.Add(this.label18);
            this.grpSubscription.Controls.Add(this.txtAmount);
            this.grpSubscription.Controls.Add(this.panel9);
            this.grpSubscription.Controls.Add(this.label17);
            this.grpSubscription.Controls.Add(this.dtpEndDate);
            this.grpSubscription.Controls.Add(this.label16);
            this.grpSubscription.Controls.Add(this.dtpStartDate);
            this.grpSubscription.Controls.Add(this.label15);
            this.grpSubscription.Controls.Add(this.txtDuration);
            this.grpSubscription.Controls.Add(this.panel1);
            this.grpSubscription.Controls.Add(this.label14);
            this.grpSubscription.Controls.Add(this.dtpSubscriptionDate);
            this.grpSubscription.Controls.Add(this.txtNote);
            this.grpSubscription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.grpSubscription.Location = new System.Drawing.Point(11, 214);
            this.grpSubscription.Name = "grpSubscription";
            this.grpSubscription.Size = new System.Drawing.Size(599, 207);
            this.grpSubscription.TabIndex = 1;
            this.grpSubscription.TabStop = false;
            this.grpSubscription.Text = "Subscription Details";
            // 
            // cmbSubscriptionType
            // 
            this.cmbSubscriptionType.BackColor = System.Drawing.Color.SkyBlue;
            this.cmbSubscriptionType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSubscriptionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubscriptionType.IntegralHeight = false;
            this.cmbSubscriptionType.Location = new System.Drawing.Point(270, 43);
            this.cmbSubscriptionType.Margin = new System.Windows.Forms.Padding(0);
            this.cmbSubscriptionType.Name = "cmbSubscriptionType";
            this.cmbSubscriptionType.Size = new System.Drawing.Size(142, 24);
            this.cmbSubscriptionType.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label22.Location = new System.Drawing.Point(270, 25);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 16);
            this.label22.TabIndex = 2;
            this.label22.Text = "Type :";
            // 
            // cmbAgent
            // 
            this.cmbAgent.BackColor = System.Drawing.Color.SkyBlue;
            this.cmbAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAgent.IntegralHeight = false;
            this.cmbAgent.Location = new System.Drawing.Point(19, 43);
            this.cmbAgent.Margin = new System.Windows.Forms.Padding(0);
            this.cmbAgent.Name = "cmbAgent";
            this.cmbAgent.Size = new System.Drawing.Size(223, 24);
            this.cmbAgent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agent :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label19.Location = new System.Drawing.Point(19, 147);
            this.label19.Margin = new System.Windows.Forms.Padding(0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 16);
            this.label19.TabIndex = 16;
            this.label19.Text = "Note :";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.SkyBlue;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel10.Location = new System.Drawing.Point(19, 188);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(560, 1);
            this.panel10.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label18.Location = new System.Drawing.Point(141, 85);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 16);
            this.label18.TabIndex = 9;
            this.label18.Text = "Amount :";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.SkyBlue;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(141, 108);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAmount.MaxLength = 10;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(103, 15);
            this.txtAmount.TabIndex = 10;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SkyBlue;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel9.Location = new System.Drawing.Point(141, 126);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(105, 1);
            this.panel9.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label17.Location = new System.Drawing.Point(437, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 16);
            this.label17.TabIndex = 14;
            this.label17.Text = "End Date :";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEndDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(437, 105);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(142, 22);
            this.dtpEndDate.TabIndex = 15;
            this.dtpEndDate.Value = new System.DateTime(2018, 12, 22, 0, 0, 0, 0);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label16.Location = new System.Drawing.Point(270, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 16);
            this.label16.TabIndex = 12;
            this.label16.Text = "Start Date :";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtpStartDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(270, 105);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(142, 22);
            this.dtpStartDate.TabIndex = 13;
            this.dtpStartDate.Value = new System.DateTime(2018, 12, 22, 0, 0, 0, 0);
            this.dtpStartDate.Leave += new System.EventHandler(this.dtpStartDate_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label15.Location = new System.Drawing.Point(19, 85);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 16);
            this.label15.TabIndex = 6;
            this.label15.Text = "Duration :";
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.Color.SkyBlue;
            this.txtDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(19, 108);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDuration.MaxLength = 3;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(103, 15);
            this.txtDuration.TabIndex = 7;
            this.txtDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuration_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(19, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 1);
            this.panel1.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label14.Location = new System.Drawing.Point(437, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Subscription Date :";
            // 
            // dtpSubscriptionDate
            // 
            this.dtpSubscriptionDate.CustomFormat = "dd/MM/yyyy";
            this.dtpSubscriptionDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpSubscriptionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSubscriptionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSubscriptionDate.Location = new System.Drawing.Point(437, 43);
            this.dtpSubscriptionDate.Name = "dtpSubscriptionDate";
            this.dtpSubscriptionDate.Size = new System.Drawing.Size(142, 22);
            this.dtpSubscriptionDate.TabIndex = 5;
            this.dtpSubscriptionDate.Value = new System.DateTime(2018, 12, 22, 0, 0, 0, 0);
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.SkyBlue;
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(19, 170);
            this.txtNote.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNote.MaxLength = 1000;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(560, 15);
            this.txtNote.TabIndex = 17;
            // 
            // grpPerson
            // 
            this.grpPerson.Controls.Add(this.txtAddress);
            this.grpPerson.Controls.Add(this.lblEmail);
            this.grpPerson.Controls.Add(this.lblContact);
            this.grpPerson.Controls.Add(this.label5);
            this.grpPerson.Controls.Add(this.lblCode);
            this.grpPerson.Controls.Add(this.label2);
            this.grpPerson.Controls.Add(this.label4);
            this.grpPerson.Controls.Add(this.label3);
            this.grpPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.grpPerson.Location = new System.Drawing.Point(11, 46);
            this.grpPerson.Name = "grpPerson";
            this.grpPerson.Size = new System.Drawing.Size(599, 169);
            this.grpPerson.TabIndex = 5;
            this.grpPerson.TabStop = false;
            this.grpPerson.Text = "Person Details";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.SkyBlue;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(110, 52);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAddress.MaxLength = 3;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(467, 48);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Text = "Address";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(110, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.Black;
            this.lblContact.Location = new System.Drawing.Point(110, 109);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(52, 16);
            this.lblContact.TabIndex = 11;
            this.lblContact.Text = "Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label5.Location = new System.Drawing.Point(13, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contact No :";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.Color.Black;
            this.lblCode.Location = new System.Drawing.Point(110, 28);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(87, 16);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Code - Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(49, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label4.Location = new System.Drawing.Point(31, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label3.Location = new System.Drawing.Point(46, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.grpPerson);
            this.panel3.Controls.Add(this.grpButtons);
            this.panel3.Controls.Add(this.grpSubscription);
            this.panel3.Location = new System.Drawing.Point(13, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(622, 497);
            this.panel3.TabIndex = 6;
            // 
            // frmEditSubscription
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(647, 523);
            this.Controls.Add(this.panel3);
            this.Name = "frmEditSubscription";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditSubscription";
            this.Load += new System.EventHandler(this.frmEditSubscription_Load);
            this.grpButtons.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconEditSubscription)).EndInit();
            this.grpSubscription.ResumeLayout(false);
            this.grpSubscription.PerformLayout();
            this.grpPerson.ResumeLayout(false);
            this.grpPerson.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox grpSubscription;
        private System.Windows.Forms.ComboBox cmbSubscriptionType;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbAgent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpSubscriptionDate;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.GroupBox grpPerson;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconPictureBox iconEditSubscription;
        private System.Windows.Forms.Panel panel3;
    }
}