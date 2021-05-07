using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        private double IValue;
        private char op = 'W';
        private bool opFlag =false;
        private double memory;
        private bool memFlag;

        public Form1()
        {
            InitializeComponent();

            btnMemoryClear.Enabled = false;
            btnMemoryRead.Enabled = false;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (tbResult.Text =="0" || opFlag == true || memFlag == true)
            {
                tbResult.Text = "1";
                opFlag = false;
                memFlag = false;
            }
            else
                tbResult.Text = tbResult.Text + "1";
            Double rValue = Double.Parse(tbResult.Text);
            switch (op)
            {
                case '+':
                    tbResult.Text = (IValue + rValue).ToString();
                    break;
                case '-':
                    tbResult.Text = (IValue - rValue).ToString();

                    break;
                case '*':
                    tbResult.Text = (IValue * rValue).ToString();

                    break;
                case '/':
                    tbResult.Text = (IValue / rValue).ToString();

                    break;
                case '%':
                    tbResult.Text = (IValue % rValue).ToString();

                    break;
            }

            /* IF WE WANT SPACES BETWEEN NUMBERS 

             double v = Double.Parse(tbResult.Text);
             int pos = 0;
             if (tbResult.Text.Contains("."))
             {
                 pos = tbResult.Text.Length - tbResult.Text.IndexOf('.');
                 if (pos == 1)
                     return;
                 string formatStr = "{0:N" + (pos - 1) + "}";
                 tbResult.Text = string.Format(formatStr, v);
             }
             else

             tbResult.Text = string.Format("{0:N0}", v);
            */
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (tbResult.Text.Contains("."))
                return;
            else
                tbResult.Text += ".";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" || opFlag == true)
            {
                tbResult.Text = "2";
                opFlag = false;

            }
            else
                tbResult.Text = tbResult.Text + "2";
            Double rValue = Double.Parse(tbResult.Text);
            switch (op)
            {
                case '+':
                    tbResult.Text = (IValue + rValue).ToString();
                    break;
                case '-':
                    tbResult.Text = (IValue - rValue).ToString();

                    break;
                case '*':
                    tbResult.Text = (IValue * rValue).ToString();

                    break;
                case '/':
                    tbResult.Text = (IValue / rValue).ToString();

                    break;
                case '%':
                    tbResult.Text = (IValue % rValue).ToString();

                    break;
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" || opFlag == true)
            {
                tbResult.Text = "0";
                opFlag = false;

            }
            else
                tbResult.Text = tbResult.Text + "0";
            Double rValue = Double.Parse(tbResult.Text);
            switch (op)
            {
                case '+':
                    tbResult.Text = (IValue + rValue).ToString();
                    break;
                case '-':
                    tbResult.Text = (IValue - rValue).ToString();

                    break;
                case '*':
                    tbResult.Text = (IValue * rValue).ToString();

                    break;
                case '/':
                    tbResult.Text = (IValue / rValue).ToString();

                    break;
                case '%':
                    tbResult.Text = (IValue % rValue).ToString();

                    break;
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" || opFlag == true)
            {
                tbResult.Text = "3";
                opFlag = false;

            }
            else
                tbResult.Text = tbResult.Text + "3";
            Double rValue = Double.Parse(tbResult.Text);
            switch (op)
            {
                case '+':
                    tbResult.Text = (IValue + rValue).ToString();
                    break;
                case '-':
                    tbResult.Text = (IValue - rValue).ToString();

                    break;
                case '*':
                    tbResult.Text = (IValue * rValue).ToString();

                    break;
                case '/':
                    tbResult.Text = (IValue / rValue).ToString();

                    break;
                case '%':
                    tbResult.Text = (IValue % rValue).ToString();

                    break;
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" || opFlag == true)
            {
                tbResult.Text = "4";
                opFlag = false;

            }
            else
                tbResult.Text = tbResult.Text + "4";
            Double rValue = Double.Parse(tbResult.Text);
            switch (op)
            {
                case '+':
                    tbResult.Text = (IValue + rValue).ToString();
                    break;
                case '-':
                    tbResult.Text = (IValue - rValue).ToString();

                    break;
                case '*':
                    tbResult.Text = (IValue * rValue).ToString();

                    break;
                case '/':
                    tbResult.Text = (IValue / rValue).ToString();

                    break;
                case '%':
                    tbResult.Text = (IValue % rValue).ToString();

                    break;
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" || opFlag == true)
            {
                tbResult.Text = "5";
                opFlag = false;

            }
            else
                tbResult.Text = tbResult.Text + "5";
            Double rValue = Double.Parse(tbResult.Text);
            switch (op)
            {
                case '+':
                    tbResult.Text = (IValue + rValue).ToString();
                    break;
                case '-':
                    tbResult.Text = (IValue - rValue).ToString();

                    break;
                case '*':
                    tbResult.Text = (IValue * rValue).ToString();

                    break;
                case '/':
                    tbResult.Text = (IValue / rValue).ToString();

                    break;
                case '%':
                    tbResult.Text = (IValue % rValue).ToString();

                    break;
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" || opFlag == true)
            {
                tbResult.Text = "6";
                opFlag = false;

            }
            else
                tbResult.Text = tbResult.Text + "6";
            Double rValue = Double.Parse(tbResult.Text);
            switch (op)
            {
                case '+':
                    tbResult.Text = (IValue + rValue).ToString();
                    break;
                case '-':
                    tbResult.Text = (IValue - rValue).ToString();

                    break;
                case '*':
                    tbResult.Text = (IValue * rValue).ToString();

                    break;
                case '/':
                    tbResult.Text = (IValue / rValue).ToString();

                    break;
                case '%':
                    tbResult.Text = (IValue % rValue).ToString();

                    break;
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" || opFlag == true)
            {
                tbResult.Text = "7";
                opFlag = false;

            }
            else
                tbResult.Text = tbResult.Text + "7";
            Double rValue = Double.Parse(tbResult.Text);
            switch (op)
            {
                case '+':
                    tbResult.Text = (IValue + rValue).ToString();
                    break;
                case '-':
                    tbResult.Text = (IValue - rValue).ToString();

                    break;
                case '*':
                    tbResult.Text = (IValue * rValue).ToString();

                    break;
                case '/':
                    tbResult.Text = (IValue / rValue).ToString();

                    break;
                case '%':
                    tbResult.Text = (IValue % rValue).ToString();

                    break;
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" || opFlag == true)
            {
                tbResult.Text = "8";
                opFlag = false;

            }
            else
                tbResult.Text = tbResult.Text + "8";
            Double rValue = Double.Parse(tbResult.Text);
            switch (op)
            {
                case '+':
                    tbResult.Text = (IValue + rValue).ToString();
                    break;
                case '-':
                    tbResult.Text = (IValue - rValue).ToString();

                    break;
                case '*':
                    tbResult.Text = (IValue * rValue).ToString();

                    break;
                case '/':
                    tbResult.Text = (IValue / rValue).ToString();

                    break;
                case '%':
                    tbResult.Text = (IValue % rValue).ToString();

                    break;
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" || opFlag == true)
            {
                tbResult.Text = "9";
                opFlag = false;

            }
            else
                tbResult.Text = tbResult.Text + "9";
            Double rValue = Double.Parse(tbResult.Text);
            switch (op)
            {
                case '+':
                    tbResult.Text = (IValue + rValue).ToString();
                    break;
                case '-':
                    tbResult.Text = (IValue - rValue).ToString();

                    break;
                case '*':
                    tbResult.Text = (IValue * rValue).ToString();

                    break;
                case '/':
                    tbResult.Text = (IValue / rValue).ToString();

                    break;
                case '%':
                    tbResult.Text = (IValue % rValue).ToString();

                    break;
            }
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            double v = Double.Parse(tbResult.Text);
            tbResult.Text = (-v).ToString();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            IValue = Double.Parse(tbResult.Text);
            tbResult.Text = tbResult.Text + " +";
            op = '+';
            opFlag = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Double rValue = Double.Parse(tbResult.Text);
            switch(op)
            {
                case '+':
                    tbResult.Text = (IValue + rValue).ToString();
                    break;
                case '-':
                    tbResult.Text = (IValue - rValue).ToString();

                    break;
                case '*':
                    tbResult.Text = (IValue * rValue).ToString();

                    break;
                case '/':
                    tbResult.Text = (IValue / rValue).ToString();

                    break;
                case '%':
                    tbResult.Text = (IValue % rValue).ToString();

                    break;
            }
        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            IValue = Double.Parse(tbResult.Text);
            tbResult.Text = tbResult.Text + " -";

            op = '-';
            opFlag = true;

        }

        private void btnMultiplay_Click(object sender, EventArgs e)
        {
            IValue = Double.Parse(tbResult.Text);
            tbResult.Text = tbResult.Text + " *";

            op = '*';
            opFlag = true;

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            IValue = Double.Parse(tbResult.Text);
            tbResult.Text = tbResult.Text + " /";

            op = '/';
            opFlag = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbResult.Text = Math.Sqrt(Double.Parse(tbResult.Text)).ToString();

        }

        private void btnXX_Click(object sender, EventArgs e)
        {
            tbResult.Text = (Double.Parse(tbResult.Text) * Double.Parse(tbResult.Text)).ToString();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
            IValue = 0;
            op = 'W';
            opFlag = false;
        }

        private void btnMemorySave_Click(object sender, EventArgs e)
        {
            memory = Double.Parse(tbResult.Text);
            btnMemoryRead.Enabled = true;
            btnMemoryClear.Enabled = true;
            memFlag = true;
        }

        private void btnMemoryRead_Click(object sender, EventArgs e)
        {
            tbResult.Text = memory.ToString();
            memFlag = true;

        }

        private void btnMemoryClear_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
            memory = 0;
            btnMemoryRead.Enabled = false;
            btnMemoryClear.Enabled = false;
            
        }

        private void btnMemoryPlus_Click(object sender, EventArgs e)
        {
            memory += Double.Parse(tbResult.Text);
        }

        private void btnMemoryMinus_Click(object sender, EventArgs e)
        {
            memory -= Double.Parse(tbResult.Text);

        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            IValue = Double.Parse(tbResult.Text);
            tbResult.Text = tbResult.Text + " %";

            op = '%';
            opFlag = true;
        }

    }
}
