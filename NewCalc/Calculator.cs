namespace NewCalc
{
    public partial class Calculator : Form
    {
        private string currentInput;
        private string previousInput;
        private string currentOperator;
        private bool operatorClickedAgain = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            txtDisplay.Clear();
            if (button != null)
            {
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
            if (operatorClickedAgain)
            {
                currentOperator = operatorSymbol;
                txtPreview.Text = previousInput + currentOperator;
            }
            else
            {
                previousInput = currentInput;
                currentOperator = operatorSymbol;
                currentInput = "";
                txtPreview.Text = previousInput + currentOperator;
                txtDisplay.Clear();
                txtDisplay.Text = "0";
            }

            operatorClickedAgain = true;
        }

        private void AppendToInput(string value)
        {
            if (operatorClickedAgain)
            {
                currentInput = value;
                operatorClickedAgain = false;
            }
            else
            {
                currentInput += value;
            }

            txtDisplay.Text = currentInput;
        }
        private void ClearAll()
        {
            currentInput = "";
            previousInput = "";
            currentOperator = "";
            txtDisplay.Clear();
            txtPreview.Clear();
        }
        #endregion

        private void btnequals_Click(object sender, EventArgs e)
        {
            try
            {
                double result = 0;
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

                txtDisplay.Text = result.ToString();
                txtPreview.Text = $"{num1} {currentOperator} {num2} =";
                previousInput = result.ToString();

            }
            catch (DivideByZeroException ex)
            {
                ClearAll();
                txtDisplay.Text = ex.Message;
            }
            catch (Exception ex)
            {
                ClearAll();
                txtDisplay.Text = ex.Message;
            }

        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (currentInput.Length > 0)
            {
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
                txtDisplay.Text = currentInput;

                if (currentInput.Length == 0)
                {
                    txtDisplay.Clear();
                    txtDisplay.Text = "0";
                }
            }
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (!currentInput.Contains("."))
            {
                currentInput += ".";
                txtDisplay.Text = currentInput;
            }
        }

        private void btnneg_Click(object sender, EventArgs e)
        {
            try
            {
                decimal newInput = decimal.Parse(currentInput);

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
            }

        }

    }
}