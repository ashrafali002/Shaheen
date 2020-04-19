namespace Shaheen
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubscription = new System.Windows.Forms.Button();
            this.btnState = new System.Windows.Forms.Button();
            this.btnCountry = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblLogoText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.btnDistrict = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.btnDistrict);
            this.panel1.Controls.Add(this.btnSubscription);
            this.panel1.Controls.Add(this.btnState);
            this.panel1.Controls.Add(this.btnCountry);
            this.panel1.Controls.Add(this.pnlLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 823);
            this.panel1.TabIndex = 0;
            // 
            // btnSubscription
            // 
            this.btnSubscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubscription.Location = new System.Drawing.Point(12, 102);
            this.btnSubscription.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubscription.Name = "btnSubscription";
            this.btnSubscription.Size = new System.Drawing.Size(265, 38);
            this.btnSubscription.TabIndex = 5;
            this.btnSubscription.Text = "Subscription";
            this.btnSubscription.UseVisualStyleBackColor = false;
            this.btnSubscription.Click += new System.EventHandler(this.btnSubscription_Click);
            // 
            // btnState
            // 
            this.btnState.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnState.Location = new System.Drawing.Point(12, 236);
            this.btnState.Margin = new System.Windows.Forms.Padding(4);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(265, 38);
            this.btnState.TabIndex = 4;
            this.btnState.Text = "Add / Edit State";
            this.btnState.UseVisualStyleBackColor = false;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // btnCountry
            // 
            this.btnCountry.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCountry.Location = new System.Drawing.Point(10, 190);
            this.btnCountry.Margin = new System.Windows.Forms.Padding(4);
            this.btnCountry.Name = "btnCountry";
            this.btnCountry.Size = new System.Drawing.Size(265, 38);
            this.btnCountry.TabIndex = 3;
            this.btnCountry.Text = "Add / Edit Country";
            this.btnCountry.UseVisualStyleBackColor = false;
            this.btnCountry.Click += new System.EventHandler(this.btnCountry_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.pnlLogo.Controls.Add(this.lblClient);
            this.pnlLogo.Controls.Add(this.lblLogoText);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(286, 94);
            this.pnlLogo.TabIndex = 2;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(81, 58);
            this.lblClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(111, 16);
            this.lblClient.TabIndex = 1;
            this.lblClient.Text = "Shaheen Weekly";
            // 
            // lblLogoText
            // 
            this.lblLogoText.AutoSize = true;
            this.lblLogoText.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoText.Location = new System.Drawing.Point(71, 9);
            this.lblLogoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogoText.Name = "lblLogoText";
            this.lblLogoText.Size = new System.Drawing.Size(126, 36);
            this.lblLogoText.TabIndex = 0;
            this.lblLogoText.Text = "Ishtiraq";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(286, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 97);
            this.panel2.TabIndex = 1;
            // 
            // pnlForm
            // 
            this.pnlForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(286, 97);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1058, 726);
            this.pnlForm.TabIndex = 2;
            // 
            // btnDistrict
            // 
            this.btnDistrict.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistrict.Location = new System.Drawing.Point(12, 282);
            this.btnDistrict.Margin = new System.Windows.Forms.Padding(4);
            this.btnDistrict.Name = "btnDistrict";
            this.btnDistrict.Size = new System.Drawing.Size(265, 38);
            this.btnDistrict.TabIndex = 6;
            this.btnDistrict.Text = "Add / Edit District";
            this.btnDistrict.UseVisualStyleBackColor = false;
            this.btnDistrict.Click += new System.EventHandler(this.btnDistrict_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 823);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogoText;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Button btnCountry;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Button btnState;
        private System.Windows.Forms.Button btnSubscription;
        private System.Windows.Forms.Button btnDistrict;
    }
}