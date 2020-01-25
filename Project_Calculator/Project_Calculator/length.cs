using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Calculator
{
    public partial class length : Form
    {
        public length()
        {
            InitializeComponent();
        }

        private void btnCalculateL_Click(object sender, EventArgs e)
        {
            bool flag;
            double KM;
            double Miles;
            double answer;
            if (txtMiles.Text == "")
            {
                flag = double.TryParse(txtkm.Text, out KM);
                answer = KM * 0.621371;
                txtResultL.Text = answer.ToString() + " Miles ";
            }
            else
            {
                flag = double.TryParse(txtMiles.Text, out Miles);
                answer = Miles * 1.60934;
                txtResultL.Text = answer.ToString() + " kiloMeters ";
            }
        }

        private void btnResetL_Click(object sender, EventArgs e)
        {
            txtkm.Clear();
            txtMiles.Clear();
            txtResultL.Clear();
        }
    }
}
