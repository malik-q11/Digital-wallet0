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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(106, 209);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 3;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(69, 39);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(155, 20);
            this.txtname.TabIndex = 0;
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
            this.baddname.Location = new System.Drawing.Point(148, 71);
            this.baddname.Name = "baddname";
            this.baddname.Size = new System.Drawing.Size(75, 23);
            this.baddname.TabIndex = 1;
            this.baddname.Text = "Add";
            this.baddname.UseVisualStyleBackColor = true;
            this.baddname.Click += new System.EventHandler(this.baddname_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(69, 105);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(155, 95);
            this.listBox1.TabIndex = 4;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(69, 71);
            this.clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 2;
            this.clear.Text = "Delete";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // New_Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 259);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.baddname);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.next);
            this.Name = "New_Group";
            this.ShowIcon = false;
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button clear;
    }
}