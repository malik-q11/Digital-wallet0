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
                listBox1.Items.Add(this.txtname.Text);
                this.txtname.Focus();
                txtname.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a name to add.","Error",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtname.Focus();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.Text);
        }
    }
}
