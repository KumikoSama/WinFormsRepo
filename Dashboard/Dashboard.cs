using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Dashboard : Form
    {
        string ConnectionString = "Data Source=DESKTOP-LIDTB5Q;Initial Catalog=UserInfoDB;Integrated Security=True;Trust Server Certificate=True";
        
        public Dashboard()
        {
            InitializeComponent();
            LoadDb();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadDb();
        }

        private void LoadDb()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM dbTestSchema.UserInfoDBtest";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dbtable.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Occurred: {ex.Message}");
                }
            }
        }

        private void btngoback_Click(object sender, EventArgs e)
        {
            FrontPage frontPage = new FrontPage();
            frontPage.Show();
            this.Hide();
        }

        private void exitappbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dbtable.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Proceed deleting selected row/s?", "Delete Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    List<int> selectedIDs = new List<int>();
                    foreach (DataGridViewRow row in dbtable.SelectedRows)
                    {
                        int selectID = Convert.ToInt32(row.Cells["UserID"].Value);
                        selectedIDs.Add(selectID);
                    }
                    foreach (int id in selectedIDs)
                    {
                        DataDelete(id);
                    }
                    foreach (DataGridViewRow row in dbtable.SelectedRows)
                    {
                        dbtable.Rows.Remove(row);
                    }
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            else
                return;
        }

        private void DataDelete(int selectID)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "DELETE FROM dbTestSchema.UserInfoDBtest WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", selectID);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                        MessageBox.Show("Error: No record found to delete.");
                }
            }
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dbtable.SelectedRows.Count == 1)
            {
                int selectedID = Convert.ToInt32(dbtable.SelectedRows[0].Cells["UserID"].Value);
                string firstName = dbtable.SelectedRows[0].Cells["FirstName"].Value.ToString();
                string lastName = dbtable.SelectedRows[0].Cells["LastName"].Value.ToString();
                int age = Convert.ToInt32(dbtable.SelectedRows[0].Cells["Age"].Value);
                string gender = dbtable.SelectedRows[0].Cells["Gender"].Value.ToString();

                UpdateForm updateForm = new UpdateForm(selectedID, firstName, lastName, age, gender);
                updateForm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Select one row to update");
        }
    }
}
