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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpPerson = new System.Windows.Forms.GroupBox();
            this.iconSearch = new FontAwesome.Sharp.IconPictureBox();
            this.lblPendingAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblAgent = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.iconPayment = new FontAwesome.Sharp.IconPictureBox();
            this.label27 = new System.Windows.Forms.Label();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.paymentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnPayment = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPerson
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.grpPerson, 2);
            this.grpPerson.Controls.Add(this.iconSearch);
            this.grpPerson.Controls.Add(this.lblPendingAmount);
            this.grpPerson.Controls.Add(this.label4);
            this.grpPerson.Controls.Add(this.txtCode);
            this.grpPerson.Controls.Add(this.lblAgent);
            this.grpPerson.Controls.Add(this.panel1);
            this.grpPerson.Controls.Add(this.lblName);
            this.grpPerson.Controls.Add(this.label13);
            this.grpPerson.Controls.Add(this.label1);
            this.grpPerson.Controls.Add(this.label3);
            this.grpPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.grpPerson.Location = new System.Drawing.Point(3, 48);
            this.grpPerson.Name = "grpPerson";
            this.grpPerson.Size = new System.Drawing.Size(986, 107);
            this.grpPerson.TabIndex = 42;
            this.grpPerson.TabStop = false;
            this.grpPerson.Text = "Person Details";
            // 
            // iconSearch
            // 
            this.iconSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.iconSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.iconSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.iconSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSearch.IconSize = 26;
            this.iconSearch.Location = new System.Drawing.Point(235, 27);
            this.iconSearch.Name = "iconSearch";
            this.iconSearch.Size = new System.Drawing.Size(27, 26);
            this.iconSearch.TabIndex = 47;
            this.iconSearch.TabStop = false;
            // 
            // lblPendingAmount
            // 
            this.lblPendingAmount.AutoSize = true;
            this.lblPendingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingAmount.Location = new System.Drawing.Point(814, 68);
            this.lblPendingAmount.Name = "lblPendingAmount";
            this.lblPendingAmount.Size = new System.Drawing.Size(0, 20);
            this.lblPendingAmount.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label4.Location = new System.Drawing.Point(688, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Pending Amout :";
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.SkyBlue;
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(113, 34);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCode.MaxLength = 10;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(117, 15);
            this.txtCode.TabIndex = 20;
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            // 
            // lblAgent
            // 
            this.lblAgent.AutoSize = true;
            this.lblAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgent.Location = new System.Drawing.Point(109, 68);
            this.lblAgent.Name = "lblAgent";
            this.lblAgent.Size = new System.Drawing.Size(0, 20);
            this.lblAgent.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(113, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 1);
            this.panel1.TabIndex = 19;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(363, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 33;
            this.lblName.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label13.Location = new System.Drawing.Point(51, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 31;
            this.label13.Text = "Agent :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(297, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.label3.Location = new System.Drawing.Point(56, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Code :";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Navy;
            this.tableLayoutPanel1.SetColumnSpan(this.panel17, 2);
            this.panel17.Controls.Add(this.iconPayment);
            this.panel17.Controls.Add(this.label27);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(3, 3);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(986, 39);
            this.panel17.TabIndex = 45;
            // 
            // iconPayment
            // 
            this.iconPayment.BackColor = System.Drawing.Color.Navy;
            this.iconPayment.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.iconPayment.IconColor = System.Drawing.Color.White;
            this.iconPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPayment.IconSize = 34;
            this.iconPayment.Location = new System.Drawing.Point(11, 6);
            this.iconPayment.Name = "iconPayment";
            this.iconPayment.Size = new System.Drawing.Size(37, 34);
            this.iconPayment.TabIndex = 11;
            this.iconPayment.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(55, 6);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(136, 25);
            this.label27.TabIndex = 0;
            this.label27.Text = "Payment List";
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.AllowUserToDeleteRows = false;
            this.dgvPayment.AllowUserToOrderColumns = true;
            this.dgvPayment.AllowUserToResizeColumns = false;
            this.dgvPayment.AllowUserToResizeRows = false;
            this.dgvPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.dgvPayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayment.ColumnHeadersHeight = 45;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentId,
            this.paymentType,
            this.paymentDate,
            this.chequeNo,
            this.chequeDate,
            this.amountPaid,
            this.receiptNo,
            this.bankName});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvPayment, 2);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayment.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayment.EnableHeadersVisualStyles = false;
            this.dgvPayment.GridColor = System.Drawing.Color.Black;
            this.dgvPayment.Location = new System.Drawing.Point(3, 161);
            this.dgvPayment.MultiSelect = false;
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPayment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayment.Size = new System.Drawing.Size(986, 374);
            this.dgvPayment.TabIndex = 46;
            this.dgvPayment.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPayment_CellFormatting);
            this.dgvPayment.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPayment_RowHeaderMouseDoubleClick);
            // 
            // paymentId
            // 
            this.paymentId.DataPropertyName = "paymentId";
            this.paymentId.HeaderText = "paymentId";
            this.paymentId.Name = "paymentId";
            this.paymentId.Visible = false;
            // 
            // paymentType
            // 
            this.paymentType.DataPropertyName = "paymentType";
            this.paymentType.HeaderText = "Payment Type";
            this.paymentType.Name = "paymentType";
            this.paymentType.ReadOnly = true;
            // 
            // paymentDate
            // 
            this.paymentDate.DataPropertyName = "paymentDate";
            this.paymentDate.HeaderText = "Payment Date";
            this.paymentDate.Name = "paymentDate";
            this.paymentDate.ReadOnly = true;
            // 
            // chequeNo
            // 
            this.chequeNo.DataPropertyName = "chequeNo";
            this.chequeNo.HeaderText = "Cheq/DD No";
            this.chequeNo.Name = "chequeNo";
            this.chequeNo.ReadOnly = true;
            // 
            // chequeDate
            // 
            this.chequeDate.DataPropertyName = "chequeDate";
            this.chequeDate.HeaderText = "Cheq/DD Date";
            this.chequeDate.Name = "chequeDate";
            this.chequeDate.ReadOnly = true;
            // 
            // amountPaid
            // 
            this.amountPaid.DataPropertyName = "amountPaid";
            this.amountPaid.HeaderText = "Amount Paid";
            this.amountPaid.Name = "amountPaid";
            this.amountPaid.ReadOnly = true;
            // 
            // receiptNo
            // 
            this.receiptNo.DataPropertyName = "receiptNo";
            this.receiptNo.HeaderText = "Receipt No";
            this.receiptNo.Name = "receiptNo";
            this.receiptNo.ReadOnly = true;
            // 
            // bankName
            // 
            this.bankName.DataPropertyName = "bankName";
            this.bankName.HeaderText = "Bank Name";
            this.bankName.Name = "bankName";
            this.bankName.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btnClose.IconColor = System.Drawing.Color.Maroon;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnClose.IconSize = 32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(886, 541);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 39);
            this.btnClose.TabIndex = 48;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPayment.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnPayment.IconChar = FontAwesome.Sharp.IconChar.IndianRupeeSign;
            this.btnPayment.IconColor = System.Drawing.Color.DarkBlue;
            this.btnPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPayment.IconSize = 32;
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(3, 541);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(161, 39);
            this.btnPayment.TabIndex = 49;
            this.btnPayment.Text = "Make Payment";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel17, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpPerson, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPayment, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgvPayment, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(992, 587);
            this.tableLayoutPanel1.TabIndex = 50;
            // 
            // frmPaymentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 587);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmPaymentList";
            this.ShowInTaskbar = false;
            this.Text = "PaymentList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPaymentList_Load);
            this.grpPerson.ResumeLayout(false);
            this.grpPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpPerson;
        private System.Windows.Forms.Label lblAgent;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.Label lblPendingAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankName;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnPayment;
        private FontAwesome.Sharp.IconPictureBox iconSearch;
        private FontAwesome.Sharp.IconPictureBox iconPayment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}