namespace Shaheen
{
    partial class MDIMain
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMasters = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCountry = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCustomer,
            this.mnuDashboard,
            this.mnuMasters,
            this.mnuExit});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(852, 24);
            this.mnuMain.TabIndex = 1;
            // 
            // mnuCustomer
            // 
            this.mnuCustomer.Name = "mnuCustomer";
            this.mnuCustomer.Size = new System.Drawing.Size(76, 20);
            this.mnuCustomer.Text = "Customers";
            this.mnuCustomer.Click += new System.EventHandler(this.mnuCustomer_Click);
            // 
            // mnuDashboard
            // 
            this.mnuDashboard.Name = "mnuDashboard";
            this.mnuDashboard.Size = new System.Drawing.Size(76, 20);
            this.mnuDashboard.Text = "Dashboard";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // mnuMasters
            // 
            this.mnuMasters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCountry});
            this.mnuMasters.Name = "mnuMasters";
            this.mnuMasters.Size = new System.Drawing.Size(60, 20);
            this.mnuMasters.Text = "Masters";
            // 
            // mnuCountry
            // 
            this.mnuCountry.Name = "mnuCountry";
            this.mnuCountry.Size = new System.Drawing.Size(180, 22);
            this.mnuCountry.Text = "Country";
            this.mnuCountry.Click += new System.EventHandler(this.MnuCountry_Click);
            // 
            // MDIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 506);
            this.Controls.Add(this.mnuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MDIMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shaheen Weekly";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuDashboard;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuMasters;
        private System.Windows.Forms.ToolStripMenuItem mnuCountry;
    }
}