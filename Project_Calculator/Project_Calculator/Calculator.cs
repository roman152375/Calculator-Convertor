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
    public partial class Calculator : Form
    {
        float input1;
        float input2;
        float input3;
        float result;
        char oper;
        bool length;
        bool point = false;
        bool calculator;
        bool km;
        bool miles;
        bool kg;
        bool pounds;
        public Calculator()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
           // if (point == false)
          //  {
          //      txtDisplay.Text = txtDisplay.Text + ".";
          // }
          //  point = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtDisplay.Text, out input1)) ;
            {
                if (float.TryParse(txtDisplay.Text, out input1))
                {
                    txtDisplay.Clear();
                }
                oper = '+';
                point = false;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

            if (float.TryParse(txtDisplay.Text, out input1)) ;
            {
                if (float.TryParse(txtDisplay.Text, out input1))
                {
                    txtDisplay.Clear();
                }
                oper = '-';
                point = false;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

            if (float.TryParse(txtDisplay.Text, out input1)) ;
            {
                if (float.TryParse(txtDisplay.Text, out input1))
                {
                    txtDisplay.Clear();
                }
                oper = '*';
                point = false;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

            if (float.TryParse(txtDisplay.Text, out input1)) ;
            {
                if (float.TryParse(txtDisplay.Text, out input1))
                {
                    txtDisplay.Clear();
                }
                oper = '/';
                point = false;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtDisplay.Text, out input2))

            {
                switch (oper)

                {
                    case '+':

                        result = input1 + input2 + input3;
                        txtDisplay.Text = result.ToString();

                        break;

                    case '-':
                        result = input1 - input2;
                        txtDisplay.Text = result.ToString();

                        break;

                    case '*':

                        result = input1 * input2;

                        txtDisplay.Text = result.ToString();

                        break;

                    case '/':

                        result = input1 / input2;

                        txtDisplay.Text = result.ToString();

                        break;
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length == 1)
                txtDisplay.Text = "";

            else
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
        }
    }
}
