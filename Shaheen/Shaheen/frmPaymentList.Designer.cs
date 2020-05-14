namespace Shaheen
{
    partial class frmPaymentList
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpPerson = new System.Windows.Forms.GroupBox();
            this.lblAgent = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtReceiptNo = new System.Windows.Forms.TextBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtPaidAmout = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.dtpChequeDate = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.txtChequeNo = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            this.rdoDD = new System.Windows.Forms.RadioButton();
            this.rdoCheque = new System.Windows.Forms.RadioButton();
            this.rdoMO = new System.Windows.Forms.RadioButton();
            this.grpButtons.SuspendLayout();
            this.grpPerson.SuspendLayout();
            this.panel17.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnClose);
            this.grpButtons.Controls.Add(this.btnSave);
            this.grpButtons.Location = new System.Drawing.Point(12, 546);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(563, 59);
            this.grpButtons.TabIndex = 44;
            this.grpButtons.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(470, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(389, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // grpPerson
            // 
            this.grpPerson.Controls.Add(this.txtCode);
            this.grpPerson.Controls.Add(this.lblAgent);
            this.grpPerson.Controls.Add(this.panel1);
            this.grpPerson.Controls.Add(this.lblContact);
            this.grpPerson.Controls.Add(this.label5);
            this.grpPerson.Controls.Add(this.lblCity);
            this.grpPerson.Controls.Add(this.lblAddress);
            this.grpPerson.Controls.Add(this.lblName);
            this.grpPerson.Controls.Add(this.label13);
            this.grpPerson.Controls.Add(this.label1);
            this.grpPerson.Controls.Add(this.label4);
            this.grpPerson.Controls.Add(this.label3);
            this.grpPerson.ForeColor = System.Drawing.Color.Black;
            this.grpPerson.Location = new System.Drawing.Point(12, 43);
            this.grpPerson.Name = "grpPerson";
            this.grpPerson.Size = new System.Drawing.Size(848, 147);
            this.grpPerson.TabIndex = 42;
            this.grpPerson.TabStop = false;
            this.grpPerson.Text = "Person Details";
            // 
            // lblAgent
            // 
            this.lblAgent.AutoSize = true;
            this.lblAgent.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgent.Location = new System.Drawing.Point(496, 118);
            this.lblAgent.Name = "lblAgent";
            this.lblAgent.Size = new System.Drawing.Size(50, 19);
            this.lblAgent.TabIndex = 44;
            this.lblAgent.Text = "Agent";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(99, 74);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(64, 19);
            this.lblContact.TabIndex = 42;
            this.lblContact.Text = "Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(15, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "Contact No :";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(627, 52);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(36, 19);
            this.lblCity.TabIndex = 36;
            this.lblCity.Text = "City";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(99, 55);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(66, 19);
            this.lblAddress.TabIndex = 34;
            this.lblAddress.Text = "Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(442, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "Agent :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(31, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(49, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Code :";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Navy;
            this.panel17.Controls.Add(this.label27);
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(585, 37);
            this.panel17.TabIndex = 45;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(7, 6);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(133, 25);
            this.label27.TabIndex = 0;
            this.label27.Text = "Payment List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(260, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(318, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(99, 19);
            this.lblName.TabIndex = 33;
            this.lblName.Text = "Code - Name";
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.SkyBlue;
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(99, 21);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCode.MaxLength = 10;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(102, 20);
            this.txtCode.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(99, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 1);
            this.panel1.TabIndex = 19;
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.label26);
            this.grpPayment.Controls.Add(this.txtReceiptNo);
            this.grpPayment.Controls.Add(this.panel16);
            this.grpPayment.Controls.Add(this.label25);
            this.grpPayment.Controls.Add(this.txtBankName);
            this.grpPayment.Controls.Add(this.label24);
            this.grpPayment.Controls.Add(this.panel15);
            this.grpPayment.Controls.Add(this.txtPaidAmout);
            this.grpPayment.Controls.Add(this.panel14);
            this.grpPayment.Controls.Add(this.label23);
            this.grpPayment.Controls.Add(this.dtpChequeDate);
            this.grpPayment.Controls.Add(this.label22);
            this.grpPayment.Controls.Add(this.txtChequeNo);
            this.grpPayment.Controls.Add(this.panel13);
            this.grpPayment.Controls.Add(this.label21);
            this.grpPayment.Controls.Add(this.dtpPaymentDate);
            this.grpPayment.Controls.Add(this.panel12);
            this.grpPayment.Controls.Add(this.label20);
            this.grpPayment.Controls.Add(this.panel11);
            this.grpPayment.Location = new System.Drawing.Point(12, 190);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(848, 200);
            this.grpPayment.TabIndex = 46;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payment Details";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label26.Location = new System.Drawing.Point(588, 145);
            this.label26.Margin = new System.Windows.Forms.Padding(0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 15);
            this.label26.TabIndex = 16;
            this.label26.Text = "Receipt No :";
            // 
            // txtReceiptNo
            // 
            this.txtReceiptNo.BackColor = System.Drawing.Color.SkyBlue;
            this.txtReceiptNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceiptNo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiptNo.Location = new System.Drawing.Point(588, 165);
            this.txtReceiptNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtReceiptNo.MaxLength = 20;
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.Size = new System.Drawing.Size(245, 20);
            this.txtReceiptNo.TabIndex = 17;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.SkyBlue;
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel16.Location = new System.Drawing.Point(588, 188);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(245, 1);
            this.panel16.TabIndex = 18;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label25.Location = new System.Drawing.Point(20, 145);
            this.label25.Margin = new System.Windows.Forms.Padding(0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(79, 15);
            this.label25.TabIndex = 13;
            this.label25.Text = "Bank Name :";
            // 
            // txtBankName
            // 
            this.txtBankName.BackColor = System.Drawing.Color.SkyBlue;
            this.txtBankName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBankName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankName.Location = new System.Drawing.Point(20, 165);
            this.txtBankName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBankName.MaxLength = 200;
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(525, 20);
            this.txtBankName.TabIndex = 14;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label24.Location = new System.Drawing.Point(588, 90);
            this.label24.Margin = new System.Windows.Forms.Padding(0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 15);
            this.label24.TabIndex = 10;
            this.label24.Text = "Paid Amount :";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.SkyBlue;
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel15.Location = new System.Drawing.Point(20, 188);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(525, 1);
            this.panel15.TabIndex = 15;
            // 
            // txtPaidAmout
            // 
            this.txtPaidAmout.BackColor = System.Drawing.Color.SkyBlue;
            this.txtPaidAmout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaidAmout.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmout.Location = new System.Drawing.Point(588, 110);
            this.txtPaidAmout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPaidAmout.MaxLength = 10;
            this.txtPaidAmout.Name = "txtPaidAmout";
            this.txtPaidAmout.Size = new System.Drawing.Size(245, 20);
            this.txtPaidAmout.TabIndex = 11;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.SkyBlue;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel14.Location = new System.Drawing.Point(588, 133);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(245, 1);
            this.panel14.TabIndex = 12;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label23.Location = new System.Drawing.Point(302, 90);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(146, 15);
            this.label23.TabIndex = 8;
            this.label23.Text = "DD / Cheque / MO Date :";
            // 
            // dtpChequeDate
            // 
            this.dtpChequeDate.CustomFormat = "";
            this.dtpChequeDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpChequeDate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpChequeDate.Location = new System.Drawing.Point(302, 107);
            this.dtpChequeDate.Name = "dtpChequeDate";
            this.dtpChequeDate.Size = new System.Drawing.Size(247, 27);
            this.dtpChequeDate.TabIndex = 9;
            this.dtpChequeDate.Value = new System.DateTime(2018, 12, 22, 0, 0, 0, 0);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(20, 90);
            this.label22.Margin = new System.Windows.Forms.Padding(0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(135, 15);
            this.label22.TabIndex = 5;
            this.label22.Text = "DD / Cheque / MO No :";
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.BackColor = System.Drawing.Color.SkyBlue;
            this.txtChequeNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChequeNo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChequeNo.Location = new System.Drawing.Point(20, 110);
            this.txtChequeNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtChequeNo.MaxLength = 20;
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(245, 20);
            this.txtChequeNo.TabIndex = 6;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.SkyBlue;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel13.Location = new System.Drawing.Point(20, 133);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(245, 1);
            this.panel13.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label21.Location = new System.Drawing.Point(588, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 15);
            this.label21.TabIndex = 3;
            this.label21.Text = "Payment Date :";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.CustomFormat = "";
            this.dtpPaymentDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpPaymentDate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(588, 48);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(247, 27);
            this.dtpPaymentDate.TabIndex = 4;
            this.dtpPaymentDate.Value = new System.DateTime(2018, 12, 22, 0, 0, 0, 0);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.SkyBlue;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel12.Location = new System.Drawing.Point(23, 76);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(527, 1);
            this.panel12.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(20, 30);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "Payment Type :";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.rdoCash);
            this.panel11.Controls.Add(this.rdoDD);
            this.panel11.Controls.Add(this.rdoCheque);
            this.panel11.Controls.Add(this.rdoMO);
            this.panel11.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel11.Location = new System.Drawing.Point(23, 48);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(527, 28);
            this.panel11.TabIndex = 1;
            // 
            // rdoCash
            // 
            this.rdoCash.AutoSize = true;
            this.rdoCash.Location = new System.Drawing.Point(3, 1);
            this.rdoCash.Name = "rdoCash";
            this.rdoCash.Size = new System.Drawing.Size(63, 23);
            this.rdoCash.TabIndex = 0;
            this.rdoCash.Text = "Cash";
            this.rdoCash.UseVisualStyleBackColor = true;
            // 
            // rdoDD
            // 
            this.rdoDD.AutoSize = true;
            this.rdoDD.Location = new System.Drawing.Point(110, 1);
            this.rdoDD.Name = "rdoDD";
            this.rdoDD.Size = new System.Drawing.Size(127, 23);
            this.rdoDD.TabIndex = 1;
            this.rdoDD.Text = "Demand Draft";
            this.rdoDD.UseVisualStyleBackColor = true;
            // 
            // rdoCheque
            // 
            this.rdoCheque.AutoSize = true;
            this.rdoCheque.Location = new System.Drawing.Point(281, 1);
            this.rdoCheque.Name = "rdoCheque";
            this.rdoCheque.Size = new System.Drawing.Size(80, 23);
            this.rdoCheque.TabIndex = 2;
            this.rdoCheque.Text = "Cheque";
            this.rdoCheque.UseVisualStyleBackColor = true;
            // 
            // rdoMO
            // 
            this.rdoMO.AutoSize = true;
            this.rdoMO.Location = new System.Drawing.Point(405, 1);
            this.rdoMO.Name = "rdoMO";
            this.rdoMO.Size = new System.Drawing.Size(117, 23);
            this.rdoMO.TabIndex = 3;
            this.rdoMO.Text = "Money Order";
            this.rdoMO.UseVisualStyleBackColor = true;
            // 
            // frmPaymentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 617);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.grpPerson);
            this.Name = "frmPaymentList";
            this.Text = "PaymentList";
            this.grpButtons.ResumeLayout(false);
            this.grpPerson.ResumeLayout(false);
            this.grpPerson.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpPerson;
        private System.Windows.Forms.Label lblAgent;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtReceiptNo;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtPaidAmout;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtpChequeDate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtChequeNo;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.RadioButton rdoCash;
        private System.Windows.Forms.RadioButton rdoDD;
        private System.Windows.Forms.RadioButton rdoCheque;
        private System.Windows.Forms.RadioButton rdoMO;
    }
}