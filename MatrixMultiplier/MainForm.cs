using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixMultiplier
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            int A, B, width;
            if (!(int.TryParse(tbADec.Text, out A) && (int.TryParse(tbBDec.Text, out B)) && (int.TryParse(tbWidth.Text, out width))))
                MessageBox.Show("Incorrect input");
            else if (width > 32)
                MessageBox.Show("Input data width should be 32 or less");
            else
            {
                Multiplier mul = new Multiplier(A, B, width);
                tbResDec.Text = mul.Multiply().ToString();
            }
        }

        private void tbADec_TextChanged(object sender, EventArgs e)
        {
            tbABin.Text = NumUtils.DecToBin(((TextBox)sender).Text);
        }

        private void tbBDec_TextChanged(object sender, EventArgs e)
        {
            tbBBin.Text = NumUtils.DecToBin(((TextBox)sender).Text);
        }

        private void tbResDec_TextChanged(object sender, EventArgs e)
        {
            tbResBin.Text = NumUtils.DecToBin(((TextBox)sender).Text);
        }
    }
}
