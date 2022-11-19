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
            this.btnPrepareDatabase = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnClearDatabase
            // 
            this.btnClearDatabase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClearDatabase.FlatAppearance.BorderSize = 0;
            this.btnClearDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDatabase.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btnClearDatabase.IconColor = System.Drawing.Color.Maroon;
            this.btnClearDatabase.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnClearDatabase.IconSize = 32;
            this.btnClearDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearDatabase.Location = new System.Drawing.Point(294, 203);
            this.btnClearDatabase.Name = "btnClearDatabase";
            this.btnClearDatabase.Size = new System.Drawing.Size(272, 48);
            this.btnClearDatabase.TabIndex = 5;
            this.btnClearDatabase.Text = "Clear Database";
            this.btnClearDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearDatabase.UseVisualStyleBackColor = false;
            this.btnClearDatabase.Click += new System.EventHandler(this.btnClearDatabase_Click);
            // 
            // btnPrepareDatabase
            // 
            this.btnPrepareDatabase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrepareDatabase.BackColor = System.Drawing.Color.Teal;
            this.btnPrepareDatabase.FlatAppearance.BorderSize = 0;
            this.btnPrepareDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrepareDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrepareDatabase.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrepareDatabase.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnPrepareDatabase.IconColor = System.Drawing.SystemColors.Control;
            this.btnPrepareDatabase.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnPrepareDatabase.IconSize = 32;
            this.btnPrepareDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrepareDatabase.Location = new System.Drawing.Point(294, 257);
            this.btnPrepareDatabase.Name = "btnPrepareDatabase";
            this.btnPrepareDatabase.Size = new System.Drawing.Size(272, 48);
            this.btnPrepareDatabase.TabIndex = 6;
            this.btnPrepareDatabase.Text = "Prepare Database";
            this.btnPrepareDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrepareDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrepareDatabase.UseVisualStyleBackColor = false;
            this.btnPrepareDatabase.Visible = false;
            this.btnPrepareDatabase.Click += new System.EventHandler(this.btnPrepareDatabase_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 636);
            this.Controls.Add(this.btnPrepareDatabase);
            this.Controls.Add(this.btnClearDatabase);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnClearDatabase;
        private FontAwesome.Sharp.IconButton btnPrepareDatabase;
    }
}