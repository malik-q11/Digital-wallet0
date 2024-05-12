namespace Digital_wallet
{
    partial class New_account
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nxtnew = new System.Windows.Forms.Button();
            this.newuser = new System.Windows.Forms.TextBox();
            this.newpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New user name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New password";
            // 
            // nxtnew
            // 
            this.nxtnew.Location = new System.Drawing.Point(94, 161);
            this.nxtnew.Name = "nxtnew";
            this.nxtnew.Size = new System.Drawing.Size(75, 23);
            this.nxtnew.TabIndex = 2;
            this.nxtnew.Text = "Next";
            this.nxtnew.UseVisualStyleBackColor = true;
            this.nxtnew.Click += new System.EventHandler(this.nxtnew_Click);
            // 
            // newuser
            // 
            this.newuser.Location = new System.Drawing.Point(112, 57);
            this.newuser.Name = "newuser";
            this.newuser.Size = new System.Drawing.Size(116, 20);
            this.newuser.TabIndex = 3;
            // 
            // newpass
            // 
            this.newpass.Location = new System.Drawing.Point(112, 106);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(116, 20);
            this.newpass.TabIndex = 4;
            // 
            // New_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 212);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.newuser);
            this.Controls.Add(this.nxtnew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "New_account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nxtnew;
        private System.Windows.Forms.TextBox newuser;
        private System.Windows.Forms.TextBox newpass;
    }
}