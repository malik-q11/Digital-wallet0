namespace Digital_wallet
{
    partial class New_Group
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
            this.next = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.baddname = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(106, 182);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 0;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(69, 39);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(155, 20);
            this.txtname.TabIndex = 2;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(12, 42);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(38, 13);
            this.l1.TabIndex = 3;
            this.l1.Text = "Name:";
            // 
            // baddname
            // 
            this.baddname.Location = new System.Drawing.Point(106, 83);
            this.baddname.Name = "baddname";
            this.baddname.Size = new System.Drawing.Size(75, 23);
            this.baddname.TabIndex = 4;
            this.baddname.Text = "Add";
            this.baddname.UseVisualStyleBackColor = true;
            this.baddname.Click += new System.EventHandler(this.baddname_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Dr.Saleh",
            "Malik",
            "Zyad",
            "Abdullah "});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "D.r Saleh ",
            "Malik",
            "Zyad ",
            "Abdullah"});
            this.comboBox1.Location = new System.Drawing.Point(69, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // New_Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 259);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.baddname);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.next);
            this.Name = "New_Group";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Group";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Button baddname;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}