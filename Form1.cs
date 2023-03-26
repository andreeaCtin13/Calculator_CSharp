using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorCSharp
{
    public partial class Form1 : Form
    {
        Calculator calc = new Calculator();

        int Adding()
        {
            calc.Add();
            return calc.Total;
        }


        int Difference()
        {
            calc.Minus();
            return calc.Total;
        }

        int Divide()
        {
            calc.Divide();
            return calc.Total;
        }

        int Multiply()
        {
            calc.Multiplicate();
            return calc.Total;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(calc.Op == operation.none)
            {
                calc.Operand1 = calc.Operand1 * 10 + 0;
                lblFocus.Text = Convert.ToString(calc.Operand1);

            }
            else
            {
                calc.Operand2 = calc.Operand2 * 10 + 0;
                lblFocus.Text = Convert.ToString(calc.Operand2);

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

            if (calc.Op == operation.none)
            {
                calc.Operand1 = calc.Operand1 * 10 + 1;
                lblFocus.Text = Convert.ToString(calc.Operand1);

            }
            else
            {
                calc.Operand2 = calc.Operand2 * 10 + 1;
                lblFocus.Text = Convert.ToString(calc.Operand2);

            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Calculator.nrOperatii++;
            calc.Op = operation.add;
          
            if (lblResult.Text != "0"&&lblResult.Text!="Start")
            {
                calc.Operand1 = Convert.ToInt32(lblResult.Text);
            }
            
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Calculator.nrOperatii++;
            calc.Op = operation.minus;
            if (lblResult.Text != "0" && lblResult.Text != "Start")
            {
                calc.Operand1 = Convert.ToInt32(lblResult.Text);
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            Calculator.nrOperatii++;
            calc.Op = operation.multiplicate;
            if (lblResult.Text != "0" && lblResult.Text != "Start")
            {
                calc.Operand1 = Convert.ToInt32(lblResult.Text);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Calculator.nrOperatii++;
            calc.Op = operation.divide;
            if (lblResult.Text != "0" && lblResult.Text != "Start")
            {
                calc.Operand1 = Convert.ToInt32(lblResult.Text);
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if(calc.Op == operation.add)
            {
                Adding();
            }
            else if(calc.Op== operation.minus)
            {
                Difference();
            }
            else if (calc.Op == operation.divide)
            {
                Divide();
            }
            else if(calc.Op == operation.multiplicate)
            {
                Multiply();
            }
            calc.Op = operation.equal;
            calc.Operand1 = calc.Total;
            lblResult.Text =Convert.ToString(calc.Total);
            lblFocus.Text = Convert.ToString(calc.Total);
            calc.Op = operation.none;
            calc.Operand1 = 0;
            calc.Operand2=0;
           
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (calc.Op == operation.none)
            {
                calc.Operand1 = calc.Operand1 * 10 + 2;
                lblFocus.Text = Convert.ToString(calc.Operand1);

            }
            else
            {
                calc.Operand2 = calc.Operand2 * 10 + 2;
                lblFocus.Text = Convert.ToString(calc.Operand2);

            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (calc.Op == operation.none)
            {
                calc.Operand1 = calc.Operand1 * 10 + 3;
                lblFocus.Text = Convert.ToString(calc.Operand1);

            }
            else
            {
                calc.Operand2 = calc.Operand2 * 10 + 3;
                lblFocus.Text = Convert.ToString(calc.Operand2);

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (calc.Op == operation.none)
            {
                calc.Operand1 = calc.Operand1 * 10 + 4;
                lblFocus.Text = Convert.ToString(calc.Operand1);

            }
            else
            {
                calc.Operand2 = calc.Operand2 * 10 + 4;
                lblFocus.Text = Convert.ToString(calc.Operand2);

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (calc.Op == operation.none)
            {
                calc.Operand1 = calc.Operand1 * 10 + 5;
                lblFocus.Text = Convert.ToString(calc.Operand1);

            }
            else
            {
                calc.Operand2 = calc.Operand2 * 10 + 5;
                lblFocus.Text = Convert.ToString(calc.Operand2);

            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (calc.Op == operation.none)
            {
                calc.Operand1 = calc.Operand1 * 10 + 6;
                lblFocus.Text = Convert.ToString(calc.Operand1);

            }
            else
            {
                calc.Operand2 = calc.Operand2 * 10 + 6;
                lblFocus.Text = Convert.ToString(calc.Operand2);

            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (calc.Op == operation.none)
            {
                calc.Operand1 = calc.Operand1 * 10 + 7;
                lblFocus.Text = Convert.ToString(calc.Operand1);

            }
            else
            {
                calc.Operand2 = calc.Operand2 * 10 + 7;
                lblFocus.Text = Convert.ToString(calc.Operand2);

            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (calc.Op == operation.none)
            {
                calc.Operand1 = calc.Operand1 * 10 + 8;
                lblFocus.Text = Convert.ToString(calc.Operand1);

            }
            else
            {
                calc.Operand2 = calc.Operand2 * 10 + 8;
                lblFocus.Text = Convert.ToString(calc.Operand2);

            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (calc.Op == operation.none)
            {
                calc.Operand1 = calc.Operand1 * 10 + 9;
                lblFocus.Text = Convert.ToString(calc.Operand1);

            }
            else
            {
                calc.Operand2 = calc.Operand2 * 10 + 9;
                lblFocus.Text = Convert.ToString(calc.Operand2);

            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            calc.Reset(0);
            lblFocus.Text = Convert.ToString(0);
            lblResult.Text = Convert.ToString(0);
        }

        private void lblFocus_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(calc.Op== operation.none)
            {
                calc.Operand1 = calc.Operand1 / 10;
                lblFocus.Text= Convert.ToString(calc.Operand1);
            }
            else
            {
                calc.Operand2 = calc.Operand2 / 10;
                lblFocus.Text = Convert.ToString(calc.Operand2);

            }
        }
    }
}
