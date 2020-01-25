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
    public partial class weight : Form
    {
        public weight()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            txtKG.Clear();
            txtPounds.Clear();
            txtResultW.Clear();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool flag;
            double KG;
            double Pounds;
            double answer;
            if (txtPounds.Text == "")
            {
                flag = double.TryParse(txtKG.Text, out KG);
                answer = KG * 2.20462;
                txtResultW.Text = answer.ToString() + " Pounds ";
            }
            else
            {
                flag = double.TryParse(txtPounds.Text, out Pounds);
                answer = Pounds * 0.453592;
                txtResultW.Text = answer.ToString() + " kiloGrams ";
            }
        }
    }
}
