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
                    ClearAll();

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
                txtDisplay.Text = "";
                isResultDisplayed = false;
            }
            else if (operatorClicked)
            {
                FormattedPreviousInput();

                txtDisplay.Text = "0";
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

                FormattedPreviousInput();
                txtDisplay.Text = "0";
                txtPreview.Text = previousInput + currentOperator;
            }

            operatorClicked = true;
        }

        private void AppendToInput(string value)
        {
            if (currentInput.Length > 13)
                return;

            if (operatorClicked)
            {
                currentInput = value;
                operatorClicked = false;
            }
            else
                currentInput += value;

            FormattedCurrentInput();
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
        private void FormattedCurrentInput()
        {
            if (currentInput.Contains("."))
            {
                string[] parts = currentInput.Split('.');
                string formattedInput = string.Format("{0:N0}", decimal.Parse(parts[0]));
                txtDisplay.Text = formattedInput + "." + (parts.Length > 1 ? parts[1] : ""); 
            }
            else
                txtDisplay.Text = string.Format("{0:N0}", decimal.Parse(currentInput));
        }

        private void FormattedPreviousInput()
        {
            if (previousInput.Contains("."))
            {
                string[] parts = previousInput.Split('.');
                string formattedPrevInput = string.Format("{0:N0}", decimal.Parse(parts[0]));
                previousInput = formattedPrevInput + "." + (parts.Length > 1 ? parts[1] : "");
            }
            else
                previousInput = string.Format("{0:N0}", decimal.Parse(previousInput));
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    btnNum_Click(btn0, EventArgs.Empty); 
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    btnNum_Click(btn1, EventArgs.Empty); 
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    btnNum_Click(btn2, EventArgs.Empty);
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    btnNum_Click(btn3, EventArgs.Empty); 
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    btnNum_Click(btn4, EventArgs.Empty);
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    btnNum_Click(btn5, EventArgs.Empty);
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    btnNum_Click(btn6, EventArgs.Empty);
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    btnNum_Click(btn7, EventArgs.Empty);
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    btnNum_Click(btn8, EventArgs.Empty);
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    btnNum_Click(btn9, EventArgs.Empty);
                    break;
                case Keys.Oemplus:
                case Keys.Add:
                    btnOprtr_Click(btnplus, EventArgs.Empty); 
                    break;
                case Keys.OemMinus:
                case Keys.Subtract:
                    btnOprtr_Click(btnminus, EventArgs.Empty); 
                    break;
                case Keys.Multiply:
                    btnOprtr_Click(btnmultiply, EventArgs.Empty);
                    break;
                case Keys.Divide:
                    btnOprtr_Click(btndivide, EventArgs.Empty); 
                    break;
                case Keys.Decimal:
                case Keys.OemPeriod:
                    btndot_Click(btndot, EventArgs.Empty); 
                    break;
                case Keys.Enter:
                    btnequals_Click(btnequals, EventArgs.Empty); 
                    break;
                case Keys.Back:
                    btndelete_Click(btndelete, EventArgs.Empty);
                    break;
                case Keys.Escape:
                    btnclear_Click(btnclear, EventArgs.Empty); 
                    break;
                case Keys.N:
                    btnneg_Click(btnneg, EventArgs.Empty);
                    break;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
            return true; 
        }
        #endregion

        #region Buttons
        private void btnequals_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDisplay.Text == "0." || string.IsNullOrEmpty(currentInput) || string.IsNullOrEmpty(previousInput))
                {
                    ClearAll();
                    return;
                }
                else
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

        private void btnclear_Click(object sender, EventArgs e)
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
                    FormattedPreviousInput();
            }
            else if (currentInput.Length > 0)
            {
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
                txtDisplay.Text = currentInput;

                if (string.IsNullOrEmpty(currentInput))
                {
                    txtDisplay.Text = "0";
                    currentInput = "";
                    operatorClicked = true;
                }
                else
                    FormattedCurrentInput();
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
                FormattedCurrentInput();
            }
        }

        private void btnneg_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput) || currentInput.Contains("."))
            {
                double newInput = double.Parse(currentInput);

                if (newInput > 0)
                {
                    newInput = -newInput;
                    currentInput = newInput.ToString();
                }
                else if (newInput < 0)
                {
                    newInput = Math.Abs(newInput);
                    currentInput = newInput.ToString();
                }
                FormattedCurrentInput();
            }
            else return;
        }
        #endregion
    }
}