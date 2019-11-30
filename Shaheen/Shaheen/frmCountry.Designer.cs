namespace Shaheen
{
    partial class frmCountry
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
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.btnSave);
            this.grpButton.Controls.Add(this.btnClose);
            this.grpButton.Location = new System.Drawing.Point(12, 206);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(577, 54);
            this.grpButton.TabIndex = 3;
            this.grpButton.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(397, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(487, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 188);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // frmCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(601, 272);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpButton);
            this.Name = "frmCountry";
            this.Text = "frmCountry";
            this.grpButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}