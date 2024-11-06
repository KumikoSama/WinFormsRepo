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
        string ConnectionString = "Data Source=DESKTOP-LIDTB5Q;Initial Catalog=UserInfoDB;Integrated Security=True;Trust Server Certificate=True";

        public UpdateForm(int userID, string firstName, string lastName, int age, string gender)
        {
            InitializeComponent();
            lbluserinfo.Text = ($"{firstName.ToUpper()}'s INFORMATION");
            lbluserid.Text = ($"USER ID#: {userID.ToString()}");

            this.userID = userID;
            txtbxfname.Text = firstName;
            txtbxlname.Text = lastName;
            txtbxage.Text = age.ToString();

            if (gender == "Female")
                rdbtnfem.Checked = true;
            else if (gender == "Male")
                rdbtnmale.Checked = true;
        }

        private void btndone_Click(object sender, EventArgs e)
        {
            try
            {
                string updatedfname = txtbxfname.Text;
                string updatedlname = txtbxlname.Text;
                int updatedage = int.Parse(txtbxage.Text);
                string updatedgender = rdbtnfem.Checked ? "Female" : rdbtnmale.Checked ? "Male" : null;

                using (SqlConnection conn = new SqlConnection(ConnectionString))
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
                MessageBox.Show("Invalid input\nPlease try again");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
    }
}
