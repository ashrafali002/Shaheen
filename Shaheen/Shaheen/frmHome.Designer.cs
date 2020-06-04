namespace Shaheen
{
    partial class frmHome
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
            this.dgvAgentWiseStatusCount = new System.Windows.Forms.DataGridView();
            this.agentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.continueCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblActiveSubscription = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblContinueSubscription = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblClosedSubscription = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.iconHome = new FontAwesome.Sharp.IconPictureBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgentWiseStatusCount)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAgentWiseStatusCount
            // 
            this.dgvAgentWiseStatusCount.AllowUserToAddRows = false;
            this.dgvAgentWiseStatusCount.AllowUserToDeleteRows = false;
            this.dgvAgentWiseStatusCount.AllowUserToOrderColumns = true;
            this.dgvAgentWiseStatusCount.AllowUserToResizeColumns = false;
            this.dgvAgentWiseStatusCount.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(210)))), ((int)(((byte)(248)))));
            this.dgvAgentWiseStatusCount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgentWiseStatusCount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.dgvAgentWiseStatusCount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgentWiseStatusCount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAgentWiseStatusCount.ColumnHeadersHeight = 35;
            this.dgvAgentWiseStatusCount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agentName,
            this.activeCount,
            this.closeCount,
            this.continueCount,
            this.totalCount});
            this.dgvAgentWiseStatusCount.EnableHeadersVisualStyles = false;
            this.dgvAgentWiseStatusCount.GridColor = System.Drawing.Color.Black;
            this.dgvAgentWiseStatusCount.Location = new System.Drawing.Point(10, 78);
            this.dgvAgentWiseStatusCount.MultiSelect = false;
            this.dgvAgentWiseStatusCount.Name = "dgvAgentWiseStatusCount";
            this.dgvAgentWiseStatusCount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgentWiseStatusCount.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAgentWiseStatusCount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAgentWiseStatusCount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAgentWiseStatusCount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgentWiseStatusCount.Size = new System.Drawing.Size(674, 217);
            this.dgvAgentWiseStatusCount.TabIndex = 6;
            this.dgvAgentWiseStatusCount.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAgentWiseStatusCount_DataBindingComplete);
            // 
            // agentName
            // 
            this.agentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.agentName.DataPropertyName = "agentName";
            this.agentName.FillWeight = 262.0049F;
            this.agentName.HeaderText = "Agent";
            this.agentName.Name = "agentName";
            this.agentName.ReadOnly = true;
            // 
            // activeCount
            // 
            this.activeCount.DataPropertyName = "activeCount";
            this.activeCount.FillWeight = 60.42761F;
            this.activeCount.HeaderText = "Active";
            this.activeCount.Name = "activeCount";
            this.activeCount.ReadOnly = true;
            this.activeCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.activeCount.ToolTipText = "Active";
            this.activeCount.Width = 80;
            // 
            // closeCount
            // 
            this.closeCount.DataPropertyName = "closeCount";
            this.closeCount.FillWeight = 54.44703F;
            this.closeCount.HeaderText = "Close";
            this.closeCount.Name = "closeCount";
            this.closeCount.ReadOnly = true;
            this.closeCount.Width = 80;
            // 
            // continueCount
            // 
            this.continueCount.DataPropertyName = "continueCount";
            this.continueCount.FillWeight = 73.76889F;
            this.continueCount.HeaderText = "Continue";
            this.continueCount.Name = "continueCount";
            this.continueCount.ReadOnly = true;
            this.continueCount.ToolTipText = "Continue";
            this.continueCount.Width = 80;
            // 
            // totalCount
            // 
            this.totalCount.DataPropertyName = "totalCount";
            this.totalCount.HeaderText = "Total";
            this.totalCount.Name = "totalCount";
            this.totalCount.ReadOnly = true;
            this.totalCount.Width = 80;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblActiveSubscription);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(10, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 142);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Active";
            // 
            // lblActiveSubscription
            // 
            this.lblActiveSubscription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblActiveSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblActiveSubscription.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveSubscription.Location = new System.Drawing.Point(0, 63);
            this.lblActiveSubscription.Name = "lblActiveSubscription";
            this.lblActiveSubscription.Size = new System.Drawing.Size(188, 77);
            this.lblActiveSubscription.TabIndex = 1;
            this.lblActiveSubscription.Text = "10";
            this.lblActiveSubscription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblContinueSubscription);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(252, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 142);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Continue";
            // 
            // lblContinueSubscription
            // 
            this.lblContinueSubscription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblContinueSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContinueSubscription.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinueSubscription.Location = new System.Drawing.Point(0, 63);
            this.lblContinueSubscription.Name = "lblContinueSubscription";
            this.lblContinueSubscription.Size = new System.Drawing.Size(188, 77);
            this.lblContinueSubscription.TabIndex = 1;
            this.lblContinueSubscription.Text = "10";
            this.lblContinueSubscription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblClosedSubscription);
            this.panel3.ForeColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(494, 337);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 142);
            this.panel3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Closed";
            // 
            // lblClosedSubscription
            // 
            this.lblClosedSubscription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblClosedSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClosedSubscription.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClosedSubscription.Location = new System.Drawing.Point(0, 63);
            this.lblClosedSubscription.Name = "lblClosedSubscription";
            this.lblClosedSubscription.Size = new System.Drawing.Size(188, 77);
            this.lblClosedSubscription.TabIndex = 1;
            this.lblClosedSubscription.Text = "10";
            this.lblClosedSubscription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Navy;
            this.panel17.Controls.Add(this.iconHome);
            this.panel17.Controls.Add(this.label27);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(694, 37);
            this.panel17.TabIndex = 41;
            // 
            // iconHome
            // 
            this.iconHome.BackColor = System.Drawing.Color.Navy;
            this.iconHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconHome.IconColor = System.Drawing.Color.White;
            this.iconHome.Location = new System.Drawing.Point(10, 6);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(32, 32);
            this.iconHome.TabIndex = 10;
            this.iconHome.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(48, 6);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(189, 25);
            this.label27.TabIndex = 0;
            this.label27.Text = "Home / Dashboard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Agent-wise Status :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(12, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Total Status :";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 491);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvAgentWiseStatusCount);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgentWiseStatusCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAgentWiseStatusCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblActiveSubscription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblContinueSubscription;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblClosedSubscription;
        private System.Windows.Forms.Panel panel17;
        private FontAwesome.Sharp.IconPictureBox iconHome;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn continueCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCount;
    }
}