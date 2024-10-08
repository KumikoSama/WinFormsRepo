namespace BasicCalc
{
    public partial class Calcu : Form
    {
        decimal num1, num2, result;
        string opertr;
        bool opertrClick;
        bool autoCompu;

        public Calcu()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (txtDisplay.Text == "0")
                txtDisplay.Clear();

            txtDisplay.Text += button.Text;
        }


        private void btndot_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
                txtDisplay.Text += ".";
        }

        private decimal Compute(decimal num1, decimal num2, string operatr)
        {
            decimal result = 0;

            try
            {
                switch (operatr)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                }
            }
            catch (Exception e)
            {
                txtDisplay.Text = "Syntax Error";
                num1 = 0;
                num2 = 0;
                result = 0;
            }
            return result;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.Text = "0";
            num1 = 0;
            num2 = 0;
            result = 0;
        }

        private void btnOprtr_Click(object sender, EventArgs e)
        {
            
            opertrClick = true;

            Button button = (Button)sender;

            txtDisplay.Text = $"{num1} {opertr}";

            if (autoCompu)
            {
                num2 = decimal.Parse(txtDisplay.Text);

                result = Compute(num1, num2, opertr);

                txtDisplay.Text = result.ToString();

                num1 = result;
                opertrClick = true;
                autoCompu = false;
                return;
            }

            num1 = Convert.ToDecimal(txtDisplay.Text);
        }

        private void btnequals_Click(object sender, EventArgs e)
        {
            num2 = decimal.Parse(txtDisplay.Text);
            result = Compute(num1, num2, opertr);

            txtDisplay.Text = result.ToString();

            txtDisplay.Text = $"{num1} {opertr} {num2}";
            txtpreview.Text = $"{num1} {opertr} {num2}";
            txtDisplay.Clear(); txtDisplay.Text = "0";
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDisplay_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
