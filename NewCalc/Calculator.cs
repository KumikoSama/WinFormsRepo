namespace NewCalc
{
    public partial class Calculator : Form
    {
        private string currentInput = "";
        private double result = 0;
        private string currentOperator = "";
        private bool isOperatorClicked = false;

        public Calculator()
        {
            InitializeComponent();
        }
        private void btnNum_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                currentInput += button.Text;
                txtDisplay.Text = currentInput;
            }
        }

        private void btnOprtr_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (!string.IsNullOrEmpty(currentInput))
                {
                    double num;

                    if (double.TryParse(currentInput, out num))
                    {
                        if (isOperatorClicked)
                        {
                            result = num;
                        }
                        else
                        {
                            switch (currentOperator)
                            {
                                case "+":
                                    result += num;
                                    break;
                                case "-":
                                    result -= num;
                                    break;
                                case "*":
                                    result *= num;
                                    break;
                                case "/":
                                    result /= num;
                                    break;
                                default:
                                    result = num;
                                    break;
                            }
                        }

                        txtDisplay.Text = result.ToString();
                        currentInput = "";
                        isOperatorClicked = true;
                    }
                }

                currentOperator = clickedButton.Text;
            }
        }

        private void btnequals_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                double num;

                if (double.TryParse(currentInput, out num))
                {
                    switch (currentOperator)
                    {
                        case "+":
                            result += num;
                            break;
                        case "-":
                            result -= num;
                            break;
                        case "*":
                            result *= num;
                            break;
                        case "/":
                            result /= num;
                            break;
                    }

                    txtDisplay.Text = result.ToString();
                    currentInput = result.ToString();
                    currentOperator = "";
                    isOperatorClicked = false;
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            currentInput = "";
            result = 0;
            currentOperator = "";
            txtDisplay.Clear();
            txtDisplay.Text = "0";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (currentInput.Length > 0)
            {
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
                txtDisplay.Text = currentInput;

                if (currentInput.Length == 0)
                {
                    result = 0;
                    currentOperator = "";
                    isOperatorClicked = false;
                    txtDisplay.Text = "0";
                }
            }
        }

        private void btndot_Click_1(object sender, EventArgs e)
        {
            if (!currentInput.Contains("."))
            {
                currentInput += ".";
                txtDisplay.Text = currentInput;
            }

        }
    }
}