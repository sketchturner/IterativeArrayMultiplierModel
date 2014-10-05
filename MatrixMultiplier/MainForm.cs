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
            int A, B;
            if (!(int.TryParse(tbADec.Text, out A) && (int.TryParse(tbBDec.Text, out B))))
                MessageBox.Show("Incorrect input");
            else
            {
                Multiplier mul = new Multiplier(A, B);
                mul.Multiply();
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
    }
}
