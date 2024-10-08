namespace CalcTest01
{
    public partial class Form1 : Form
    {
        Decimal num1, num2, result;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (txtDisplay.Text == "0")
                num1 = Convert.ToDecimal(txtDisplay.Text);
                txtDisplay.Clear();



            txtDisplay.Text += button.Text;
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            txtDisplay.Text += add.Text;
            txtDisplay.Text = $"{num1} {add}";

            txtDisplay.Clear();

            txtDisplay.Text += (Button)sender;
            
            
            //num2 = decimal.Parse(txtDisplay.Text);
                
            result = num1 + num2;

            txtDisplay.Text = result.ToString();
        }
    }
}
