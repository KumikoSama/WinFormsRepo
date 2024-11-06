namespace Dashboard
{
    public partial class FrontPage : Form
    {
        public FrontPage()
        {
            InitializeComponent();
        }
        private void btnaddnew_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.Show();
            this.Hide();
        }
        private void btnviewall_Click(object sender, EventArgs e)
        {
            Dashboard dashBoard = new Dashboard();
            dashBoard.Show();
            this.Hide();
        }
        private void exitappbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
