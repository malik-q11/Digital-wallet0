namespace Digital_wallet
{
    partial class Split
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
            this.txtmoney = new System.Windows.Forms.TextBox();
            this.people = new System.Windows.Forms.TextBox();
            this.equally = new System.Windows.Forms.Button();
            this.percntage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtmoney
            // 
            this.txtmoney.Location = new System.Drawing.Point(127, 65);
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.Size = new System.Drawing.Size(74, 20);
            this.txtmoney.TabIndex = 0;
            // 
            // people
            // 
            this.people.Location = new System.Drawing.Point(127, 97);
            this.people.Name = "people";
            this.people.Size = new System.Drawing.Size(74, 20);
            this.people.TabIndex = 1;
            // 
            // equally
            // 
            this.equally.Location = new System.Drawing.Point(52, 160);
            this.equally.Name = "equally";
            this.equally.Size = new System.Drawing.Size(38, 42);
            this.equally.TabIndex = 2;
            this.equally.Text = "/";
            this.equally.UseVisualStyleBackColor = true;
            this.equally.Click += new System.EventHandler(this.equally_Click);
            // 
            // percntage
            // 
            this.percntage.Location = new System.Drawing.Point(136, 160);
            this.percntage.Name = "percntage";
            this.percntage.Size = new System.Drawing.Size(38, 42);
            this.percntage.TabIndex = 3;
            this.percntage.Text = "%";
            this.percntage.UseVisualStyleBackColor = true;
            this.percntage.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "The amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of individuals";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(127, 230);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(74, 20);
            this.result.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount per person";
            // 
            // Split
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 270);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.percntage);
            this.Controls.Add(this.equally);
            this.Controls.Add(this.people);
            this.Controls.Add(this.txtmoney);
            this.Name = "Split";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Split";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmoney;
        private System.Windows.Forms.TextBox people;
        private System.Windows.Forms.Button equally;
        private System.Windows.Forms.Button percntage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label3;
    }
}