using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TobySMS
{
    public partial class AdminLogin : Form
    {

        public DateTime startTime = DateTime.Now;

        SqlConnection dbConnect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kelvn\source\repos\LibraryManagementSystem\LibraryManagementSystem\StudentMgmtSystem.mdf;Integrated Security=True");
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {

            if (adminNameTextBox.Text == ""
                || adminPwdTxtBox.Text == ""

                )
            {
                MessageBox.Show("Please fill in all the blank Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dbConnect.State == ConnectionState.Closed)
                {
                    try
                    {

                        dbConnect.Open();
                        string selectData = "SELECT * FROM adminTable WHERE adminName = @username AND adminPwd = @password";

                        using (SqlCommand cmd = new SqlCommand(selectData, dbConnect))
                        {
                            cmd.Parameters.AddWithValue("@username", adminNameTextBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", adminPwdTxtBox.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login Successful", "Information Message!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                AdminDashboard dashboard = new AdminDashboard();
                                dashboard.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        dbConnect.Close();
                    }
                }

            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {


        }


    }
}
