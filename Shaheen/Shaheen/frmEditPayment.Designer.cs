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
            this.label25 = new System.Windows.Forms.Label();
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
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconEditPayment)).BeginInit();
            this.grpButtons.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Navy;
            this.panel17.Controls.Add(this.iconEditPayment);
            this.panel17.Controls.Add(this.label27);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(544, 37);
            this.panel17.TabIndex = 44;
            // 
            // iconEditPayment
            // 
            this.iconEditPayment.BackColor = System.Drawing.Color.Navy;
            this.iconEditPayment.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.iconEditPayment.IconColor = System.Drawing.Color.White;
            this.iconEditPayment.Location = new System.Drawing.Point(10, 6);
            this.iconEditPayment.Name = "iconEditPayment";
            this.iconEditPayment.Size = new System.Drawing.Size(32, 32);
            this.iconEditPayment.TabIndex = 7;
            this.iconEditPayment.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(48, 6);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(135, 25);
            this.label27.TabIndex = 0;
            this.label27.Text = "Edit Payment";
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnSave);
            this.grpButtons.Controls.Add(this.btnClose);
            this.grpButtons.Location = new System.Drawing.Point(10, 243);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(524, 60);
            this.grpButtons.TabIndex = 45;
            this.grpButtons.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSave.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.DarkBlue;
            this.btnSave.IconSize = 32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(321, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(90, 37);
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
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnClose.IconColor = System.Drawing.Color.Maroon;
            this.btnClose.IconSize = 32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(417, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0D;
            this.btnClose.Size = new System.Drawing.Size(90, 37);
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
            this.grpPayment.Controls.Add(this.label25);
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
            this.grpPayment.Location = new System.Drawing.Point(10, 43);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(524, 200);
            this.grpPayment.TabIndex = 46;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payment Details";
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.BackColor = System.Drawing.Color.SkyBlue;
            this.cmbPaymentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPaymentType.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentType.IntegralHeight = false;
            this.cmbPaymentType.Location = new System.Drawing.Point(17, 48);
            this.cmbPaymentType.Margin = new System.Windows.Forms.Padding(0);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(153, 27);
            this.cmbPaymentType.TabIndex = 1;
            this.cmbPaymentType.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentType_SelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label26.Location = new System.Drawing.Point(357, 90);
            this.label26.Margin = new System.Windows.Forms.Padding(0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 15);
            this.label26.TabIndex = 12;
            this.label26.Text = "Receipt No :";
            // 
            // txtReceiptNo
            // 
            this.txtReceiptNo.BackColor = System.Drawing.Color.SkyBlue;
            this.txtReceiptNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceiptNo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiptNo.Location = new System.Drawing.Point(357, 110);
            this.txtReceiptNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtReceiptNo.MaxLength = 20;
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.Size = new System.Drawing.Size(150, 20);
            this.txtReceiptNo.TabIndex = 13;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.SkyBlue;
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel16.Location = new System.Drawing.Point(357, 133);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(150, 1);
            this.panel16.TabIndex = 14;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label25.Location = new System.Drawing.Point(17, 145);
            this.label25.Margin = new System.Windows.Forms.Padding(0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(79, 15);
            this.label25.TabIndex = 15;
            this.label25.Text = "Bank Name :";
            // 
            // txtBankName
            // 
            this.txtBankName.BackColor = System.Drawing.Color.SkyBlue;
            this.txtBankName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBankName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankName.Location = new System.Drawing.Point(17, 165);
            this.txtBankName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBankName.MaxLength = 200;
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(490, 20);
            this.txtBankName.TabIndex = 16;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label24.Location = new System.Drawing.Point(357, 30);
            this.label24.Margin = new System.Windows.Forms.Padding(0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 15);
            this.label24.TabIndex = 4;
            this.label24.Text = "Paid Amount :";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.SkyBlue;
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel15.Location = new System.Drawing.Point(17, 188);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(490, 1);
            this.panel15.TabIndex = 17;
            // 
            // txtPaidAmout
            // 
            this.txtPaidAmout.BackColor = System.Drawing.Color.SkyBlue;
            this.txtPaidAmout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaidAmout.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmout.Location = new System.Drawing.Point(357, 51);
            this.txtPaidAmout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPaidAmout.MaxLength = 10;
            this.txtPaidAmout.Name = "txtPaidAmout";
            this.txtPaidAmout.Size = new System.Drawing.Size(150, 20);
            this.txtPaidAmout.TabIndex = 5;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.SkyBlue;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel14.Location = new System.Drawing.Point(357, 74);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(150, 1);
            this.panel14.TabIndex = 6;
            // 
            // lblChequeDate
            // 
            this.lblChequeDate.AutoSize = true;
            this.lblChequeDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.lblChequeDate.Location = new System.Drawing.Point(187, 90);
            this.lblChequeDate.Name = "lblChequeDate";
            this.lblChequeDate.Size = new System.Drawing.Size(111, 15);
            this.lblChequeDate.TabIndex = 10;
            this.lblChequeDate.Text = "Transaction Date :";
            // 
            // dtpChequeDate
            // 
            this.dtpChequeDate.CustomFormat = "";
            this.dtpChequeDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpChequeDate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpChequeDate.Location = new System.Drawing.Point(187, 107);
            this.dtpChequeDate.Name = "dtpChequeDate";
            this.dtpChequeDate.Size = new System.Drawing.Size(150, 27);
            this.dtpChequeDate.TabIndex = 11;
            this.dtpChequeDate.Value = new System.DateTime(2018, 12, 22, 0, 0, 0, 0);
            // 
            // lblChequeNo
            // 
            this.lblChequeNo.AutoSize = true;
            this.lblChequeNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.lblChequeNo.Location = new System.Drawing.Point(17, 90);
            this.lblChequeNo.Margin = new System.Windows.Forms.Padding(0);
            this.lblChequeNo.Name = "lblChequeNo";
            this.lblChequeNo.Size = new System.Drawing.Size(100, 15);
            this.lblChequeNo.TabIndex = 7;
            this.lblChequeNo.Text = "Transaction No :";
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.BackColor = System.Drawing.Color.SkyBlue;
            this.txtChequeNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChequeNo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChequeNo.Location = new System.Drawing.Point(17, 110);
            this.txtChequeNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtChequeNo.MaxLength = 20;
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(150, 20);
            this.txtChequeNo.TabIndex = 8;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.SkyBlue;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel13.Location = new System.Drawing.Point(20, 133);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(150, 1);
            this.panel13.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label21.Location = new System.Drawing.Point(187, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 15);
            this.label21.TabIndex = 2;
            this.label21.Text = "Payment Date :";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.CustomFormat = "";
            this.dtpPaymentDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpPaymentDate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(187, 48);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(150, 27);
            this.dtpPaymentDate.TabIndex = 3;
            this.dtpPaymentDate.Value = new System.DateTime(2018, 12, 22, 0, 0, 0, 0);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label20.Location = new System.Drawing.Point(17, 30);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "Payment Type :";
            // 
            // frmEditPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 315);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.panel17);
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
        private System.Windows.Forms.Label label25;
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
    }
}