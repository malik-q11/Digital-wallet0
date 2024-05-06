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
    public partial class New_Group : Form
    {
        public New_Group()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e)
        {
            Services m = new Services();
            m = new Services();
            m.Show();
        }

        private void listgroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void baddname_Click(object sender, EventArgs e)
        {
            if (this.txtname.Text !="")
            {
                listgroup.Items.Add(this.txtname.Text);
                this.txtname.Focus();
                this.txtname.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a name to add.","Error",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtname.Focus();
            }
        }
    }
}
