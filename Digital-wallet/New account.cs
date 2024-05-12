using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_wallet
{
    public partial class New_account : Form
    {
        public New_account()
        {
            InitializeComponent();
        }

        private void nxtnew_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(newuser.Text) && string.IsNullOrEmpty(newpass.Text))
                {
                    MessageBox.Show("Username or password Empty!");
                }

                else
                {
                    if (newuser.Text == "New" && newpass.Text == "12345")
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
