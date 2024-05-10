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
            this.next.Location = new System.Drawing.Point(159, 305);
            this.next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(112, 34);
            this.next.TabIndex = 0;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(104, 57);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(230, 27);
            this.txtname.TabIndex = 2;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(18, 61);
            this.l1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(56, 19);
            this.l1.TabIndex = 3;
            this.l1.Text = "Name:";
            // 
            // baddname
            // 
            this.baddname.Location = new System.Drawing.Point(222, 104);
            this.baddname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.baddname.Name = "baddname";
            this.baddname.Size = new System.Drawing.Size(112, 34);
            this.baddname.TabIndex = 4;
            this.baddname.Text = "Add";
            this.baddname.UseVisualStyleBackColor = true;
            this.baddname.Click += new System.EventHandler(this.baddname_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(104, 154);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(230, 137);
            this.listBox1.TabIndex = 6;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(103, 104);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(112, 34);
            this.clear.TabIndex = 7;
            this.clear.Text = "Delete";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // New_Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 379);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.baddname);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.next);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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