using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double resultValue = 0;
        double memory = 0;
        string saveDisplay = "";
        string saveEquation = "";
        string operationPerformed = "";
        bool IsOperationPerformed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (IsOperationPerformed)
                display.Clear();
            IsOperationPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ",")
            {
                if (!display.Text.Contains(","))
                {
                    display.Text = display.Text + button.Text;
                }
            }
            else
            {
                display.Text = display.Text + button.Text;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (equation.Text != "")
            {
                buttonResult.PerformClick();
                operationPerformed = button.Text;
                equation.Text = saveEquation + " " + saveDisplay + " " + operationPerformed;
                IsOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(display.Text);
                equation.Text += resultValue + " " + operationPerformed;
                IsOperationPerformed = true;
            }

            double number = Double.Parse(display.Text);
            if (operationPerformed == "√")
            {
                display.Text = Math.Sqrt(number).ToString();
                equation.Text = "";
            }
            else if (operationPerformed == "x²")
            {
                display.Text = (number * number).ToString();
                equation.Text = "";
            }
            else if (operationPerformed == "!")
            {
                double f = 1;
                for (int i = 2; i <= number; i++)
                    f *= i;
                display.Text = Convert.ToString(f);
                equation.Text = "";
            }
            else if (operationPerformed == "1/x")
            {
                display.Text = (1 / number).ToString();
                equation.Text = "";
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            display.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            resultValue = 0;
            equation.Text = "";
        }
        private void backspace(object sender, EventArgs e)
        {

            if (display.Text.Length == 1)
            {
                display.Text = "0";
            }
            else
            {
                display.Text = display.Text.Remove(display.Text.Length - 1);
            }
        }
        private void plus_minus(object sender, EventArgs e)
        {
            display.Text = (double.Parse(display.Text) * (-1)).ToString();
        }

        private void MemoryClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            String val = button.Text;
            if (val == "MC")
            {
                memory = 0;
            }
            else if (val == "MS")
            {
                memory = double.Parse(display.Text);
            }
            else if (val == "M-")
            {
                memory -= double.Parse(display.Text);
            }
            else if (val == "M+")
            {
                memory += double.Parse(display.Text);
            }
            else if (val == "MR")
            {
                resultValue = memory;
                display.Text = resultValue.ToString();
            }
        }
        private void buttonResult_Click(object sender, EventArgs e)
        {
            saveDisplay = display.Text;
            saveEquation = equation.Text;
            switch (operationPerformed)
            {
                case "+":
                    display.Text = (resultValue + Double.Parse(display.Text)).ToString();
                    break;

                case "-":
                    display.Text = (resultValue - Double.Parse(display.Text)).ToString();
                    break;

                case "×":
                    display.Text = (resultValue * Double.Parse(display.Text)).ToString();
                    break;

                case "÷":
                    display.Text = (resultValue / Double.Parse(display.Text)).ToString();
                    break;

                case "%":
                    display.Text = (resultValue * Double.Parse(display.Text) / 100).ToString();
                    break;
                default:
                    break;
            }
            resultValue = double.Parse(display.Text);
            equation.Text = "";
            IsOperationPerformed = true;
        }
    }
}