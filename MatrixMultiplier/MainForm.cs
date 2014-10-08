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
            int A, B, width, truncated;
            if (!(int.TryParse(tbADec.Text, out A) && (int.TryParse(tbBDec.Text, out B)) && (int.TryParse(tbWidth.Text, out width)) && (int.TryParse(tbTruncated.Text, out truncated))))
                MessageBox.Show("Incorrect input");
            else if (width > 32)
                MessageBox.Show("Input data width should be 32 or less");
            else if (!((truncated > width - 1) || (truncated > 0)))
                MessageBox.Show("Truncated bits count should be between 1 and data_width");
            else
            {
                if (rbFull.Checked)
                {
                    Multiplier mul = new Multiplier(A, B, width);
                    tbResDec.Text = mul.Multiply().ToString();
                }
                else
                {
                    Multiplier mul = new Multiplier(A, B, width, truncated);
                    tbResDec.Text = mul.ShortMultiply().ToString();
                }
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
