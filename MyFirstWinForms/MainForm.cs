using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MyFirstWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        public void UpdateLabel(string input)
        {
            lbldisplayname.Text = input;
        }

        public void ReceiveData(string name, string username, string gender, string birthday)
        {
            updatelblname.Text = name;
            updatelbluser.Text = username;
            updatelblgender.Text = gender;
            updatelblbirth.Text = birthday;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Logging out");
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
