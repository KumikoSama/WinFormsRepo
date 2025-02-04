using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinForms
{
    public partial class RegistrationForm : Form
    {
        string gender;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            DateTime dateTime = birthdayset.Value;
            string birthdaySet = dateTime.ToString("MMMM dd, yyyy");

            if (rbtnfemale.Checked)
            {
                gender = "Female";
            }
            else if (rbtnmale.Checked)
            {
                gender = "Male";
            }

            if (!string.IsNullOrWhiteSpace(txtbxfname.Text) && !string.IsNullOrWhiteSpace(txtbxlname.Text) && !string.IsNullOrWhiteSpace(txtbxsetuser.Text) && !string.IsNullOrWhiteSpace(txtbxsetpass.Text) && rbtnfemale.Checked || rbtnmale.Checked)
            {
                UserInfo newUser = new UserInfo(txtbxfname.Text, txtbxlname.Text, gender, txtbxsetuser.Text, txtbxsetpass.Text, birthdaySet);
                LoginForm loginForm = new LoginForm();
                loginForm.UserData(newUser.firstname, newUser.lastname, newUser.gender, newUser.birthday, newUser.username, newUser.password);

                MessageBox.Show("Registration complete\nRedirecting to Log in form");
                loginForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incomplete details\nTry again");
            }
        }

        private void linklbllogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtbxfname.Clear();
            txtbxlname.Clear();
            txtbxsetuser.Clear();
            txtbxsetpass.Clear();
        }

        private void chckshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chckshowpass.Checked)
            {
                txtbxsetpass.PasswordChar = '\0';
            }
            else
            {
                txtbxsetpass.PasswordChar = '*';
            }
        }

        private void lbllname_Click(object sender, EventArgs e)
        {

        }
    }
}
