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

namespace Dashboard
{
    public partial class UpdateForm : Form
    {
        int userID;
        string updatedfname, updatedlname, updatedage;

        public UpdateForm(int userID, string firstName, string lastName, string age, string gender)
        {
            InitializeComponent();
            this.AcceptButton = btnupdate;

            lbluserinfo.Text = ($"{firstName.ToUpper()}'s INFORMATION");
            lbluserid.Text = ($"USER ID#: {userID.ToString()}");

            this.userID = userID;
            txtbxfname.Text = firstName;
            txtbxlname.Text = lastName;
            txtbxage.Text = age;

            if (gender == "Female")
                rdbtnfem.Checked = true;
            else if (gender == "Male")
                rdbtnmale.Checked = true;
        }

        private void btndone_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtbxfname.Text) || string.IsNullOrEmpty(txtbxlname.Text) || string.IsNullOrEmpty(txtbxage.Text))
                    throw new FormatException("One or more fields are empty\nPlease enter a valid input");

                if (!(Helper.ValidateName(txtbxfname.Text) && Helper.ValidateName(txtbxlname.Text)))
                    throw new FormatException("Input must not contain number/s or special character/s");
                if (!Helper.ValidateAge(txtbxage.Text))
                    throw new FormatException("Input must not contain letter/s or special character/s");
                else
                {
                    updatedfname = Helper.CapitalizeFirstLetter(txtbxfname.Text);
                    updatedlname = Helper.CapitalizeFirstLetter(txtbxlname.Text);
                    updatedage = txtbxage.Text;
                }

                string updatedgender = rdbtnfem.Checked ? "Female" : rdbtnmale.Checked ? "Male" : throw new FormatException();

                using (SqlConnection conn = new SqlConnection(Helper.ConnectionString))
                {
                    conn.Open();
                    string query = "UPDATE dbTestSchema.UserInfoDBtest SET FirstName = @FirstName, LastName = @LastName, Age = @Age, Gender = @Gender WHERE UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", updatedfname); 
                        cmd.Parameters.AddWithValue("@LastName", updatedlname);
                        cmd.Parameters.AddWithValue("@Age", updatedage);
                        cmd.Parameters.AddWithValue("@Gender", updatedgender);
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data updated successfully");
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitappbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngoback_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("You have unsaved changes\nAre you sure you want to go back", "Unsaved Changes",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question); 

            if (dialog == DialogResult.Yes)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else if (dialog == DialogResult.No)
                return;
        }

        private void clearfields_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Helper.ClearAll(txtbxfname, txtbxlname, txtbxage, rdbtnfem, rdbtnmale);
        }
    }
}
