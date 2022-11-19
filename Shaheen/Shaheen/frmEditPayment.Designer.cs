namespace Shaheen
{
    partial class frmEditPayment
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
            this.panel17 = new System.Windows.Forms.Panel();
            this.iconEditPayment = new FontAwesome.Sharp.IconPictureBox();
            this.label27 = new System.Windows.Forms.Label();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtReceiptNo = new System.Windows.Forms.TextBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.lblBankName = new System.Windows.Forms.Label();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtPaidAmout = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lblChequeDate = new System.Windows.Forms.Label();
            this.dtpChequeDate = new System.Windows.Forms.DateTimePicker();
            this.lblChequeNo = new System.Windows.Forms.Label();
            this.txtChequeNo = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconEditPayment)).BeginInit();
            this.grpButtons.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel17.Controls.Add(this.iconEditPayment);
            this.panel17.Controls.Add(this.label27);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(622, 39);
            this.panel17.TabIndex = 44;
            // 
            // iconEditPayment
            // 
            this.iconEditPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.iconEditPayment.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.iconEditPayment.IconColor = System.Drawing.Color.White;
            this.iconEditPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEditPayment.IconSize = 34;
            this.iconEditPayment.Location = new System.Drawing.Point(11, 6);
            this.iconEditPayment.Name = "iconEditPayment";
            this.iconEditPayment.Size = new System.Drawing.Size(37, 34);
            this.iconEditPayment.TabIndex = 7;
            this.iconEditPayment.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(55, 6);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(139, 25);
            this.label27.TabIndex = 0;
            this.label27.Text = "Edit Payment";
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnSave);
            this.grpButtons.Controls.Add(this.btnClose);
            this.grpButtons.Location = new System.Drawing.Point(11, 260);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(599, 64);
            this.grpButtons.TabIndex = 45;
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
            this.btnSave.TabIndex = 27;
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
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.cmbPaymentType);
            this.grpPayment.Controls.Add(this.label26);
            this.grpPayment.Controls.Add(this.txtReceiptNo);
            this.grpPayment.Controls.Add(this.panel16);
            this.grpPayment.Controls.Add(this.lblBankName);
            this.grpPayment.Controls.Add(this.txtBankName);
            this.grpPayment.Controls.Add(this.label24);
            this.grpPayment.Controls.Add(this.panel15);
            this.grpPayment.Controls.Add(this.txtPaidAmout);
            this.grpPayment.Controls.Add(this.panel14);
            this.grpPayment.Controls.Add(this.lblChequeDate);
            this.grpPayment.Controls.Add(this.dtpChequeDate);
            this.grpPayment.Controls.Add(this.lblChequeNo);
            this.grpPayment.Controls.Add(this.txtChequeNo);
            this.grpPayment.Controls.Add(this.panel13);
            this.grpPayment.Controls.Add(this.label21);
            this.grpPayment.Controls.Add(this.dtpPaymentDate);
            this.grpPayment.Controls.Add(this.label20);
            this.grpPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.grpPayment.Location = new System.Drawing.Point(11, 47);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(599, 213);
            this.grpPayment.TabIndex = 46;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payment Details";
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.BackColor = System.Drawing.Color.SkyBlue;
            this.cmbPaymentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentType.IntegralHeight = false;
            this.cmbPaymentType.Location = new System.Drawing.Point(19, 51);
            this.cmbPaymentType.Margin = new System.Windows.Forms.Padding(0);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(174, 24);
            this.cmbPaymentType.TabIndex = 1;
            this.cmbPaymentType.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentType_SelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label26.Location = new System.Drawing.Point(408, 96);
            this.label26.Margin = new System.Windows.Forms.Padding(0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(81, 16);
            this.label26.TabIndex = 12;
            this.label26.Text = "Receipt No :";
            // 
            // txtReceiptNo
            // 
            this.txtReceiptNo.BackColor = System.Drawing.Color.SkyBlue;
            this.txtReceiptNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceiptNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiptNo.Location = new System.Drawing.Point(408, 117);
            this.txtReceiptNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtReceiptNo.MaxLength = 20;
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.Size = new System.Drawing.Size(171, 15);
            this.txtReceiptNo.TabIndex = 13;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.SkyBlue;
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel16.Location = new System.Drawing.Point(408, 135);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(171, 1);
            this.panel16.TabIndex = 14;
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.lblBankName.Location = new System.Drawing.Point(19, 155);
            this.lblBankName.Margin = new System.Windows.Forms.Padding(0);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(84, 16);
            this.lblBankName.TabIndex = 15;
            this.lblBankName.Text = "Bank Name :";
            // 
            // txtBankName
            // 
            this.txtBankName.BackColor = System.Drawing.Color.SkyBlue;
            this.txtBankName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankName.Location = new System.Drawing.Point(19, 176);
            this.txtBankName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBankName.MaxLength = 200;
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(560, 15);
            this.txtBankName.TabIndex = 16;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label24.Location = new System.Drawing.Point(408, 32);
            this.label24.Margin = new System.Windows.Forms.Padding(0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 16);
            this.label24.TabIndex = 4;
            this.label24.Text = "Paid Amount :";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.SkyBlue;
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel15.Location = new System.Drawing.Point(19, 194);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(560, 1);
            this.panel15.TabIndex = 17;
            // 
            // txtPaidAmout
            // 
            this.txtPaidAmout.BackColor = System.Drawing.Color.SkyBlue;
            this.txtPaidAmout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaidAmout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmout.Location = new System.Drawing.Point(408, 54);
            this.txtPaidAmout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPaidAmout.MaxLength = 10;
            this.txtPaidAmout.Name = "txtPaidAmout";
            this.txtPaidAmout.Size = new System.Drawing.Size(171, 15);
            this.txtPaidAmout.TabIndex = 5;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.SkyBlue;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel14.Location = new System.Drawing.Point(408, 72);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(171, 1);
            this.panel14.TabIndex = 6;
            // 
            // lblChequeDate
            // 
            this.lblChequeDate.AutoSize = true;
            this.lblChequeDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.lblChequeDate.Location = new System.Drawing.Point(214, 96);
            this.lblChequeDate.Name = "lblChequeDate";
            this.lblChequeDate.Size = new System.Drawing.Size(116, 16);
            this.lblChequeDate.TabIndex = 10;
            this.lblChequeDate.Text = "Transaction Date :";
            // 
            // dtpChequeDate
            // 
            this.dtpChequeDate.CustomFormat = "dd/MM/yyyy";
            this.dtpChequeDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpChequeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChequeDate.Location = new System.Drawing.Point(214, 114);
            this.dtpChequeDate.Name = "dtpChequeDate";
            this.dtpChequeDate.Size = new System.Drawing.Size(171, 22);
            this.dtpChequeDate.TabIndex = 11;
            this.dtpChequeDate.Value = new System.DateTime(2018, 12, 22, 0, 0, 0, 0);
            // 
            // lblChequeNo
            // 
            this.lblChequeNo.AutoSize = true;
            this.lblChequeNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.lblChequeNo.Location = new System.Drawing.Point(19, 96);
            this.lblChequeNo.Margin = new System.Windows.Forms.Padding(0);
            this.lblChequeNo.Name = "lblChequeNo";
            this.lblChequeNo.Size = new System.Drawing.Size(105, 16);
            this.lblChequeNo.TabIndex = 7;
            this.lblChequeNo.Text = "Transaction No :";
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.BackColor = System.Drawing.Color.SkyBlue;
            this.txtChequeNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChequeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChequeNo.Location = new System.Drawing.Point(19, 117);
            this.txtChequeNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtChequeNo.MaxLength = 20;
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(171, 15);
            this.txtChequeNo.TabIndex = 8;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.SkyBlue;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel13.Location = new System.Drawing.Point(23, 135);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(171, 1);
            this.panel13.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label21.Location = new System.Drawing.Point(214, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(98, 16);
            this.label21.TabIndex = 2;
            this.label21.Text = "Payment Date :";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.CustomFormat = "dd/MM/yyyy";
            this.dtpPaymentDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPaymentDate.Location = new System.Drawing.Point(214, 51);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(171, 22);
            this.dtpPaymentDate.TabIndex = 3;
            this.dtpPaymentDate.Value = new System.DateTime(2018, 12, 22, 0, 0, 0, 0);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label20.Location = new System.Drawing.Point(19, 32);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 16);
            this.label20.TabIndex = 0;
            this.label20.Text = "Payment Type :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.panel17);
            this.panel1.Controls.Add(this.grpPayment);
            this.panel1.Controls.Add(this.grpButtons);
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 335);
            this.panel1.TabIndex = 47;
            // 
            // frmEditPayment
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(646, 358);
            this.Controls.Add(this.panel1);
            this.Name = "frmEditPayment";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEditPayment";
            this.Load += new System.EventHandler(this.frmEditPayment_Load);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconEditPayment)).EndInit();
            this.grpButtons.ResumeLayout(false);
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtReceiptNo;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtPaidAmout;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lblChequeDate;
        private System.Windows.Forms.DateTimePicker dtpChequeDate;
        private System.Windows.Forms.Label lblChequeNo;
        private System.Windows.Forms.TextBox txtChequeNo;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label label20;
        private FontAwesome.Sharp.IconPictureBox iconEditPayment;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panel1;
    }
}