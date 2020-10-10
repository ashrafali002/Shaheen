namespace Shaheen
{
    partial class frmAdmin
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
            this.btnClearDatabase = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnClearDatabase
            // 
            this.btnClearDatabase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClearDatabase.FlatAppearance.BorderSize = 0;
            this.btnClearDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearDatabase.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClearDatabase.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDatabase.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnClearDatabase.IconColor = System.Drawing.Color.Maroon;
            this.btnClearDatabase.IconSize = 32;
            this.btnClearDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearDatabase.Location = new System.Drawing.Point(261, 190);
            this.btnClearDatabase.Name = "btnClearDatabase";
            this.btnClearDatabase.Rotation = 0D;
            this.btnClearDatabase.Size = new System.Drawing.Size(209, 45);
            this.btnClearDatabase.TabIndex = 5;
            this.btnClearDatabase.Text = "Clear Database";
            this.btnClearDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearDatabase.UseVisualStyleBackColor = false;
            this.btnClearDatabase.Click += new System.EventHandler(this.btnClearDatabase_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 596);
            this.Controls.Add(this.btnClearDatabase);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnClearDatabase;
    }
}