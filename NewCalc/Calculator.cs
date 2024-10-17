using System.Linq.Expressions;

namespace NewCalc
#pragma warning disable
{
    public partial class Calculator : Form
    {
        private string currentInput = "";
        private string previousInput = "";
        private string currentOperator = "";
        private double result;
        private bool operatorClicked = false;
        private bool isResultDisplayed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (isResultDisplayed)
                {
                    ClearAll();
                    isResultDisplayed = false; 
                }
                string buttonText = button.Text;
                AppendToInput(buttonText);
            }
        }

        private void btnOprtr_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                string buttonText = button.Text;
                SetOperator(buttonText);
            }
        }

        #region Methods

        private void SetOperator(string operatorSymbol)
        {
            if (!string.IsNullOrEmpty(previousInput) && !string.IsNullOrEmpty(currentInput) && !string.IsNullOrEmpty(currentOperator))
            {
                AutoComp();
                currentOperator = operatorSymbol;
                txtPreview.Text = previousInput + currentOperator;
            }
            else if (operatorClicked)
            {
                if (double.TryParse(previousInput, out double number))
                {
                    previousInput = string.Format("{0:N0}", number);
                }

                currentOperator = operatorSymbol;
                txtPreview.Text = previousInput + currentOperator;
            }
            else
            {
                previousInput = currentInput;
                currentOperator = operatorSymbol;
                currentInput = "";
                txtDisplay.Clear();
                txtDisplay.Text = "0";

                if (double.TryParse(previousInput, out double number))
                {
                    if (previousInput.Contains("."))
                    {
                        previousInput = string.Format("{0:N}", number);
                    }
                    else
                    {
                        previousInput = string.Format("{0:N0}", number);
                    }
                }
                txtPreview.Text = previousInput + currentOperator;
            }

            operatorClicked = true;
        }

        private void AppendToInput(string value)
        {
            if (operatorClicked)
            {
                currentInput = value;
                operatorClicked = false;
            }
            else
            {
                currentInput += value;
            }

            FormatAndDisplayInput();
        }

        private void ClearAll()
        {
            currentInput = "";
            previousInput = "";
            currentOperator = "";
            result = 0;
            operatorClicked = false;
            isResultDisplayed = false;
            txtDisplay.Clear();
            txtPreview.Clear();
        }

        private void AutoComp()
        {
            try
            {
                double num1 = double.Parse(previousInput);
                double num2 = double.Parse(currentInput);

                switch (currentOperator)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "×":
                        result = num1 * num2;
                        break;
                    case "÷":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                            throw new DivideByZeroException();
                        break;
                }

                previousInput = result.ToString("N0");
                txtPreview.Text = $"{result} {currentOperator}";
                txtDisplay.Clear();
                currentInput = "";
            }
            catch (DivideByZeroException ex)
            {
                ClearAll();
                txtDisplay.Text = "Syntax Error";
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                ClearAll();
                txtDisplay.Text = "Syntax Error";
                MessageBox.Show(ex.Message);
            }
        }
        private void FormatAndDisplayInput()
        {
            if (currentInput.Contains("."))
            {
                string[] parts = currentInput.Split('.');
                string formattedIntegerPart = string.Format("{0:N0}", decimal.Parse(parts[0]));
                txtDisplay.Text = formattedIntegerPart + "." + (parts.Length > 1 ? parts[1] : "");
            }
            else
            {
                txtDisplay.Text = string.Format("{0:N0}", decimal.Parse(currentInput));
            }
        }
        #endregion

        #region Buttons
        private void btnequals_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(previousInput);
                double num2 = double.Parse(currentInput);

                switch (currentOperator)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "×":
                        result = num1 * num2;
                        break;
                    case "÷":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                            throw new DivideByZeroException();
                        break;
                }

                txtDisplay.Text = result.ToString("#,##0.##########");
                string formattedNum1 = num1.ToString("#,##0.##########");
                string formattedNum2 = num2.ToString("#,##0.##########");
                txtPreview.Text = $"{formattedNum1} {currentOperator} {formattedNum2} =";
                previousInput = result.ToString();
                operatorClicked = false;
                isResultDisplayed = true;

            }
            catch (DivideByZeroException ex)
            {
                ClearAll();
                txtDisplay.Text = "Syntax error";
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                ClearAll();
                txtDisplay.Text = "Syntax error";
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed && previousInput.Length > 0) 
            {
                previousInput = previousInput.Substring(0, previousInput.Length - 1);

                if (string.IsNullOrEmpty(previousInput))
                    txtDisplay.Text = "0";
                else
                {
                    if (previousInput.Contains("."))
                    {
                        string[] parts = previousInput.Split('.');
                        string formattedIntegerPart = string.Format("{0:N0}", decimal.Parse(parts[0]));
                        txtDisplay.Text = formattedIntegerPart + "." + (parts.Length > 1 ? parts[1] : "");
                    }
                    else
                    {
                        txtDisplay.Text = string.Format("{0:N0}", decimal.Parse(previousInput));
                    }
                }
            }
            else if (currentInput.Length > 0)
            {
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
                txtDisplay.Text = currentInput;

                if (string.IsNullOrEmpty(currentInput))
                    txtDisplay.Text = "0";
                else
                    FormatAndDisplayInput();
            }
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (!currentInput.Contains("."))
            {
                if (string.IsNullOrEmpty(currentInput))
                    currentInput = "0.";
                else
                    currentInput += "."; 
                FormatAndDisplayInput();
            }
        }

        private void btnneg_Click(object sender, EventArgs e)
        {
            try
            {
                double newInput = double.Parse(currentInput);

                if (newInput > 0)
                {
                    newInput = -newInput;
                    txtDisplay.Text = newInput.ToString();
                    currentInput = txtDisplay.Text;
                }
                else if (newInput < 0)
                {
                    newInput = Math.Abs(newInput);
                    txtDisplay.Text = newInput.ToString();
                    currentInput = txtDisplay.Text;
                }
            }
            catch (Exception ex)
            {
                ClearAll();
                txtDisplay.Text = "Syntax error";
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void Calculator_Load(object sender, EventArgs e)
        {
            txtDisplay.DeselectAll();
            txtPreview.DeselectAll();
        }
    }
}