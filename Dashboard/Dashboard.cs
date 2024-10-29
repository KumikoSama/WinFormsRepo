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
            string ConnectionString = "Data Source=DESKTOP-LIDTB5Q;Initial Catalog=UserInfoDB;Integrated Security=True;Trust Server Certificate=True";
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
    }
}
