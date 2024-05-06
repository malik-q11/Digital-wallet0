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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add_a_new_invoice A = new Add_a_new_invoice();
            A = new Add_a_new_invoice();
            A.Show();
        }

        private void Split_Click(object sender, EventArgs e)
        {
            Split p = new Split();
            p = new Split();
            p.Show();
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            Pay_bills b = new Pay_bills();
            b = new Pay_bills();
            b.Show();
        }
    }
}
