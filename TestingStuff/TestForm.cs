namespace TestingStuff
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                MessageBox.Show("3/3! Way to go!");
            }
            else if (checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked)
            {
                MessageBox.Show("2/3? Go to sleep!!");
            }
            else if (checkBox1.Checked && !checkBox2.Checked && checkBox3.Checked)
            {
                MessageBox.Show("2/3? Drink water!!");
            }
            else if (!checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                MessageBox.Show("2/3? Eat something!!");
            }
            else
            {
                MessageBox.Show("Tsk tsk tsk! Take care of yourself");
            }
        }
    }
}
