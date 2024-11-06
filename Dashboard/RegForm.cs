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
        string gender, fname, lname;
        int age;

        public RegForm()
        {
            InitializeComponent();
        }
        private void btndone_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = "Data Source=DESKTOP-LIDTB5Q;Initial Catalog=UserInfoDB;Integrated Security=True;Trust Server Certificate=True";
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                fname = txtbxfname.Text;
                lname = txtbxlname.Text;
                age = int.Parse(txtbxage.Text);

                if (age > 110 || age <= 0)
                    throw new FormatException();

                if (rdbtnfem.Checked)
                    gender = "Female";
                else if (rdbtnmale.Checked)
                    gender = "Male";

                string Query = "INSERT INTO dbTestSchema.UserInfoDBtest (FirstName, LastName, Age, Gender) VALUES ('" + fname + "', '" + lname + "', '" + age + "', '" + gender + "')";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data has been added");
                FrontPage frontPage = new FrontPage();
                frontPage.Show();
                this.Hide();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input\nPlease try again");
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearAll();
            }
        }
        private void ClearAll()
        {
            fname = "";
            lname = "";
            gender = "";
            age = 0;
            txtbxfname.Clear();
            txtbxlname.Clear();
            txtbxage.Clear();
            rdbtnfem.Checked = false;
            rdbtnmale.Checked = false;
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
