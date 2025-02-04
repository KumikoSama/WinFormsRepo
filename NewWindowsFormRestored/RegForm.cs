using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dashboard
{
    public partial class RegForm : Form
    {
        string gender, fname, lname, age;

        public RegForm()
        {
            InitializeComponent();
            this.AcceptButton = btndone;
        } 

        private void btndone_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Helper.ConnectionString);
                con.Open(); 

                if (string.IsNullOrEmpty(txtbxfname.Text) || string.IsNullOrEmpty(txtbxlname.Text) || string.IsNullOrEmpty(txtbxage.Text))
                    throw new FormatException("One or more fields are empty\nPlease enter a valid input");

                if (!(Helper.ValidateName(txtbxfname.Text) && Helper.ValidateName(txtbxlname.Text)))
                    throw new FormatException("First or last name must not contain number/s or special character/s");
                if (!Helper.ValidateAge(txtbxage.Text))
                    throw new FormatException("Age must not contain letter/s or special character/s");
                else
                {
                    fname = Helper.CapitalizeFirstLetter(txtbxfname.Text);
                    lname = Helper.CapitalizeFirstLetter(txtbxlname.Text);
                    age = txtbxage.Text;
                }

                gender = rdbtnfem.Checked ? "Female" : rdbtnmale.Checked ? "Male" : throw new FormatException("Please check one of the buttons");

                string Query = "INSERT INTO dbTestSchema.UserInfoDBtest (FirstName, LastName, Age, Gender) VALUES ('" + fname + "', '" + lname + "', '" + age + "', '" + gender + "')";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data has been added");
                FrontPage frontPage = new FrontPage();
                frontPage.Show();
                this.Hide();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Helper.ClearAll(txtbxfname, txtbxlname, txtbxage, rdbtnfem, rdbtnmale);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Helper.ClearAll(txtbxfname, txtbxlname, txtbxage, rdbtnfem, rdbtnmale);
            }
        }

        private void btngoback_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbxfname.Text) || !string.IsNullOrEmpty(txtbxlname.Text) || !string.IsNullOrEmpty(txtbxage.Text))
            {
                DialogResult dialogResult = MessageBox.Show("You have unsaved data\nAre you sure you want to go back?", "Warning!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    FrontPage frontPage = new FrontPage();
                    frontPage.Show();
                    this.Hide();
                }
                else
                    return;
            }
            else
            {
                FrontPage frontPage = new FrontPage();
                frontPage.Show();
                this.Hide();
            }
        }

        private void exitappbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearfields_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Helper.ClearAll(txtbxfname, txtbxlname, txtbxage, rdbtnfem, rdbtnmale);
        }
    }
}
