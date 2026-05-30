using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        // Tracks the first number entered before an operator is pressed
        private double firstNumber = 0;
        private string currentOperator = "";
        private bool operatorPressed = false;
        private bool freshResult = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Handles all digit button clicks (0-9)
        private void DigitButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string digit = btn.Text;

            // If a result was just calculated, start fresh
            if (freshResult)
            {
                txtDisplay.Text = digit;
                freshResult = false;
                return;
            }

            // Replace the zero placeholder or append the digit
            if (operatorPressed || txtDisplay.Text == "0")
                txtDisplay.Text = digit;
            else
                txtDisplay.Text += digit;

            operatorPressed = false;
        }

        // Handles +, -, *, / operator buttons
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // If user chained operators, compute intermediate result first
            if (!operatorPressed && currentOperator != "")
                CalculateResult();

            firstNumber = double.Parse(txtDisplay.Text);
            currentOperator = btn.Text;
            operatorPressed = true;
            freshResult = false;
        }

        // Equals button - compute and show the final result
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (currentOperator == "") return;
            CalculateResult();
            currentOperator = "";
            freshResult = true;
        }

        // Core calculation logic
        private void CalculateResult()
        {
            double secondNumber = double.Parse(txtDisplay.Text);
            double result = 0;

            switch (currentOperator)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        txtDisplay.Text = "Error";
                        currentOperator = "";
                        return;
                    }
                    result = firstNumber / secondNumber;
                    break;
            }

            // Avoid showing unnecessary decimal places like "5.0"
            txtDisplay.Text = result % 1 == 0 ? result.ToString("0") : result.ToString("G10");
            firstNumber = result;
        }

        // Clear everything and reset to initial state
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstNumber = 0;
            currentOperator = "";
            operatorPressed = false;
            freshResult = false;
        }

        // Delete the last typed character
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            else
                txtDisplay.Text = "0";
        }

        // Toggle positive/negative sign
        private void btnToggleSign_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double val) && val != 0)
                txtDisplay.Text = (val * -1).ToString();
        }

        // Decimal point button - only add if not already present
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (operatorPressed)
            {
                txtDisplay.Text = "0.";
                operatorPressed = false;
                return;
            }
            if (!txtDisplay.Text.Contains("."))
                txtDisplay.Text += ".";
        }

        // Percentage: convert current display value to a percentage of firstNumber
        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double val))
            {
                double pct = firstNumber != 0 ? (firstNumber * val / 100) : val / 100;
                txtDisplay.Text = pct % 1 == 0 ? pct.ToString("0") : pct.ToString("G10");
            }
        }

        // Square root of current display value
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double val))
            {
                if (val < 0)
                {
                    txtDisplay.Text = "Error";
                    return;
                }
                double result = Math.Sqrt(val);
                txtDisplay.Text = result % 1 == 0 ? result.ToString("0") : result.ToString("G10");
                freshResult = true;
            }
        }
    }
}
