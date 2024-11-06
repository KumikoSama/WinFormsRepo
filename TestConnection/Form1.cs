using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestConnection
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Server=.;Trusted_Connection=True;TrustServerCertificate=True;";
        private SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            LoadDatabases();
        }

        private void LoadDatabases()
        {
            try
            {
                cmbDatabases.Items.Clear();
                using (SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases WHERE database_id > 4", connection))
                {
                    connection.Open();
                    MessageBox.Show("Connection opened successfully.");  // Debug message

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string dbName = reader["name"].ToString();
                            MessageBox.Show($"Database found: {dbName}");  // Debug message for each database found
                            cmbDatabases.Items.Add(dbName);  // Add the database to combo box
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading databases: {ex.Message}");  // Show error message
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

                MessageBox.Show("Connection closed.");  // Ensure connection is closed
            }
        }

        private void cmbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDatabases.SelectedItem != null)
            {
                string selectedDatabase = cmbDatabases.SelectedItem.ToString();
                connectionString = $@"Server=.;Database={selectedDatabase};Trusted_Connection=True;TrustServerCertificate=True;";
                connection = new SqlConnection(connectionString);  // Recreate connection with selected database
                MessageBox.Show($"Switched to database: {selectedDatabase}");  // Debug message
                LoadTables();  // Load tables for the selected database
            }
        }

        private void LoadTables()
        {
            try
            {
                cmbTables.Items.Clear();
                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT TABLE_NAME 
                    FROM INFORMATION_SCHEMA.TABLES 
                    WHERE TABLE_TYPE = 'BASE TABLE'", connection))
                {
                    connection.Open();
                    MessageBox.Show("Connection opened to load tables.");  // Debug message

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tableName = reader["TABLE_NAME"].ToString();
                            MessageBox.Show($"Table found: {tableName}");  // Debug message for each table
                            cmbTables.Items.Add(tableName);  // Add the table name to combo box
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tables: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

                MessageBox.Show("Connection closed after loading tables.");  // Ensure connection is closed
            }
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTables.SelectedItem != null)
            {
                LoadTableData(cmbTables.SelectedItem.ToString());
            }
        }

        private void LoadTableData(string tableName)
        {

            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM {tableName}", connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    MessageBox.Show($"Data loaded for table: {tableName}");  // Debug message
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading table data: {ex.Message}");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (cmbTables.SelectedItem != null)
            {
                LoadTableData(cmbTables.SelectedItem.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //LoadTableData();
        }
    }
}
