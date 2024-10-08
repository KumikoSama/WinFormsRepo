using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyFirstWinForms
{
    public partial class LoginForm : Form
    {
        string validuser, validpass, name, gender, birthday;
        private bool isDarkMode = false;

        public LoginForm()
        {
            InitializeComponent();
            InitializeTheme();
        }

        #region ModesClass
        private void InitializeTheme()
        {
            if (isDarkMode)
            {
                DarkMode();
            }
            else
            {
                LightMode();
            }
        }

        private void DarkMode()
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.Black;

            togglebtn.Image = Properties.Resources.lightmode;
            catpicture.Image = Properties.Resources.white_cat;
            usericon.Image = Properties.Resources.user_white;
            lockicon.Image = Properties.Resources.lock_white;
            lbluser.ForeColor = Color.White;
            lblpass.ForeColor = Color.White;
        }

        private void LightMode()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.White;

            togglebtn.Image = Properties.Resources.darkmode;
            catpicture.Image = Properties.Resources.cat_solid;
            usericon.Image = Properties.Resources.user_solid;
            lockicon.Image = Properties.Resources.lock_solid;
            lbluser.ForeColor = Color.Black;
            lblpass.ForeColor = Color.Black;
        }

        private void togglebtn_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;
            InitializeTheme();
        }

        #endregion

        public void UserData(string fname, string lname, string _gender, string _birthday, string username, string password)
        {
            name = $"{fname} {lname}";
            gender = _gender;
            birthday = _birthday;
            validuser = username;
            validpass = password;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtbxpass.Text == validpass && txtbxuser.Text == validuser)
            {
                MainForm mainForm = new MainForm();
                mainForm.UpdateLabel(txtbxuser.Text);
                mainForm.ReceiveData(name, validuser, gender, birthday);

                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid password/username\nPlease try again");
            }

        }
        public void linklblreg_LinkClicked(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }

        private void chckshowpass_CheckedChanged(object sender, EventArgs e)
        {

            if (isDarkMode)
            {
                if (chckshowpass.Checked)
                {
                    txtbxpass.PasswordChar = '\0';
                    lockicon.Image = Properties.Resources.unlock_white;
                }
                else
                {
                    txtbxpass.PasswordChar = '*';
                    lockicon.Image = Properties.Resources.lock_white;
                } 
            }
            else
            {
                if (chckshowpass.Checked)
                {
                    txtbxpass.PasswordChar = '\0';
                    lockicon.Image = Properties.Resources.unlock_solid;
                }
                else
                {
                    txtbxpass.PasswordChar = '*';
                    lockicon.Image = Properties.Resources.lock_solid;
                }
            }
        }

    }
}
