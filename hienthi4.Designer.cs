namespace hienthi4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTK = new System.Windows.Forms.Label();
            this.lblHienTK = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblHienEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTK
            // 
            this.lblTK.BackColor = System.Drawing.Color.Transparent;
            this.lblTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTK.Location = new System.Drawing.Point(119, 68);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(145, 23);
            this.lblTK.TabIndex = 0;
            this.lblTK.Text = "Tài Khoản";
            this.lblTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHienTK
            // 
            this.lblHienTK.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblHienTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienTK.Location = new System.Drawing.Point(318, 68);
            this.lblHienTK.Name = "lblHienTK";
            this.lblHienTK.Size = new System.Drawing.Size(277, 23);
            this.lblHienTK.TabIndex = 1;
            this.lblHienTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHienTK.Click += new System.EventHandler(this.lblHienTK_Click);
            // 
            // lblemail
            // 
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(122, 153);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(142, 23);
            this.lblemail.TabIndex = 2;
            this.lblemail.Text = "Email";
            this.lblemail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHienEmail
            // 
            this.lblHienEmail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblHienEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienEmail.Location = new System.Drawing.Point(318, 153);
            this.lblHienEmail.Name = "lblHienEmail";
            this.lblHienEmail.Size = new System.Drawing.Size(277, 23);
            this.lblHienEmail.TabIndex = 3;
            this.lblHienEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHienEmail.Click += new System.EventHandler(this.lblHienEmail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(736, 462);
            this.Controls.Add(this.lblHienEmail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblHienTK);
            this.Controls.Add(this.lblTK);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Label lblHienTK;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblHienEmail;
    }
}

