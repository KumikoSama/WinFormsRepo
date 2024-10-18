using System.Linq.Expressions;

namespace NewCalc
#pragma warning disable
{
    public partial class Calculator : Form
    {
        string currentInput = "";
        string previousInput = "";
        string currentOperator = "";
        double result;
        bool operatorClicked = false;
        bool isResultDisplayed = false;

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
            if (!string.IsNullOrEmpty(previousInput) && !string.IsNullOrEmpty(currentInput) && !string.IsNullOrEmpty(currentOperator) && !isResultDisplayed)
            {
                AutoComp();
                currentOperator = operatorSymbol;
                txtPreview.Text = previousInput + currentOperator;
            }
            else if (isResultDisplayed)
            {
                currentInput = "";
                currentOperator = operatorSymbol;
                txtPreview.Text = previousInput + currentOperator;
                isResultDisplayed = false;
            }
            else if (operatorClicked)
            {
                if (double.TryParse(previousInput, out double number))
                    previousInput = string.Format("{0:N0}", number);

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
                        previousInput = string.Format("{0:N}", number);
                    else
                        previousInput = string.Format("{0:N0}", number);
                }
                txtPreview.Text = previousInput + currentOperator;
            }

            operatorClicked = true;
        }

        private void AppendToInput(string value)
        {
            if (currentInput.Length > 14)
                return;

            if (operatorClicked)
            {
                currentInput = value;
                operatorClicked = false;
            }
            else
                currentInput += value;

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

                previousInput = result.ToString("#,##0.##########");
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
                string[] parts = currentInput.Split('.'); //separates the whole num to the decimals
                string formattedIntegerPart = string.Format("{0:N0}", decimal.Parse(parts[0])); //[0] is the part w the whole num
                txtDisplay.Text = formattedIntegerPart + "." + (parts.Length > 1 ? parts[1] : ""); 
            }
            else
                txtDisplay.Text = string.Format("{0:N0}", decimal.Parse(currentInput));
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    btnNum_Click(btn0, EventArgs.Empty); // Simulate click on the "0" button
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    btnNum_Click(btn1, EventArgs.Empty); // Simulate click on the "1" button
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    btnNum_Click(btn2, EventArgs.Empty); // Simulate click on the "2" button
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    btnNum_Click(btn3, EventArgs.Empty); // Simulate click on the "3" button
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    btnNum_Click(btn4, EventArgs.Empty); // Simulate click on the "4" button
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    btnNum_Click(btn5, EventArgs.Empty); // Simulate click on the "5" button
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    btnNum_Click(btn6, EventArgs.Empty); // Simulate click on the "6" button
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    btnNum_Click(btn7, EventArgs.Empty); // Simulate click on the "7" button
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    btnNum_Click(btn8, EventArgs.Empty); // Simulate click on the "8" button
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    btnNum_Click(btn9, EventArgs.Empty); // Simulate click on the "9" button
                    break;
                case Keys.Oemplus:
                case Keys.Add:
                    btnOprtr_Click(btnplus, EventArgs.Empty); // Simulate click on the "+" button
                    break;
                case Keys.OemMinus:
                case Keys.Subtract:
                    btnOprtr_Click(btnminus, EventArgs.Empty); // Simulate click on the "-" button
                    break;
                case Keys.Multiply:
                    btnOprtr_Click(btnmultiply, EventArgs.Empty); // Simulate click on the "*" button
                    break;
                case Keys.Divide:
                    btnOprtr_Click(btndivide, EventArgs.Empty); // Simulate click on the "/" button
                    break;
                case Keys.Decimal:
                case Keys.OemPeriod:
                    btndot_Click(btndot, EventArgs.Empty); // Simulate click on the "." (decimal) button
                    break;
                case Keys.Enter:
                    btnequals_Click(btnequals, EventArgs.Empty); // Simulate click on the "=" button
                    break;
                case Keys.Back:
                    btndelete_Click(btndelete, EventArgs.Empty); // Simulate click on the "Delete" button
                    break;
                case Keys.Escape:
                    btnclear_Click_1(btnclear, EventArgs.Empty); // Simulate click on the "Clear" button
                    break;
                default:
                    return base.ProcessCmdKey(ref msg, keyData); // Process other keys normally
            }

            return true; // Indicate that the key press was handled
        }

        #endregion

        #region Buttons
        private void btnequals_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(currentInput))
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
                else
                    return;
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
                        txtDisplay.Text = string.Format("{0:N0}", decimal.Parse(previousInput));
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
                MessageBox.Show(ex.Message + "");
            }
        }
        #endregion
        private void Calculator_Load(object sender, EventArgs e)
        {
            txtPreview.DeselectAll();
        }
    }
}