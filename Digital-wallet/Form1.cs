﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Digital_wallet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtusername.Text) && string.IsNullOrEmpty(txtpassword.Text))
                {
                    MessageBox.Show("Username or password Empty!");
                }
               
                else
                {
                    if (txtusername.Text == "Digital wallet" && txtpassword.Text == "123123")
                    {
                        New_Group n = new New_Group();
                        n = new New_Group();
                        n.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or password is not correct!");
                    }

                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            
        }
       
    }
}
