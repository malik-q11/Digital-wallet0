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
            try
            {
                double a = double.Parse(txtmoney.Text);
                double b = double.Parse(people.Text);
                double c = (a / b)/100;
                result.Text = c.ToString();

            }

            catch (FormatException)
            {
                result.Text = "Error";
            }
        }

        private void equally_Click(object sender, EventArgs e)
        {
            try
            {
               double a=double.Parse(txtmoney.Text);
               double b=double.Parse(people.Text);
               double c = a / b;
               result.Text=c.ToString();

            }

            catch (FormatException)
            {
                result.Text = "Error";
            }
        }
    }
}
