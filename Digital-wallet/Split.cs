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
    public partial class Split : Form
    {
        public Split()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void equally_Click(object sender, EventArgs e)
        {
            try
            {
               int a=int.Parse(txtmoney.Text);
               int b=int.Parse(people.Text);
                int c = a / b;
                result.Text=c.ToString();

            }

            catch (FormatException)
            {
                result.Text = "Error";
            }
        }
    }
}
