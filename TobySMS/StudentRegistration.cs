using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TobySMS
{

    public partial class StudentRegistration : Form
    {
        readonly SqlConnection dbConnect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kelvn\source\repos\LibraryManagementSystem\LibraryManagementSystem\StudentMgmtSystem.mdf;Integrated Security=True");
        public StudentRegistration()
        {
            InitializeComponent();
        }
        private void RegisterStudentBtn_Click(object sender, EventArgs e)
        {
            if (studentNameTxtBox.Text == ""
                || studentAdmNoTxtBox.Text == "" || studentSNameTxtBox.Text == ""

                )
            {
                MessageBox.Show("Please fill in all the blank Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dbConnect.State != ConnectionState.Open)
                {
                    try
                    {
                        dbConnect.Open();
                        //TO CHECK IF ADMIN IS EXISTING ALREADY
                        string checkId = "SELECT COUNT (id) FROM studentTable WHERE id = @uid AND adminName=@name";
                        using (SqlCommand checkUser = new SqlCommand(checkId, dbConnect))
                        {
                            checkUser.Parameters.AddWithValue("@name", studentNameTxtBox.Text.Trim());
                            checkUser.Parameters.AddWithValue("@uid", studentAdmNoTxtBox.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();
                            if (count >= 1)
                            {
                                MessageBox.Show("UID: " + studentNameTxtBox.Text.Trim() + " name: " + studentNameTxtBox.Text.Trim() + "  is already registered", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else//TO ADD NEW Student USER
                            {
                                DateTime today = DateTime.Today;
                                //string checkAdminRecord = " ";
                                string insertdata = "INSERT INTO adminTable" + "(admNo,FirstName,LastName,Gender,Age,Email,Phone,Course)" + "VALUES(@uid,@name,@adminPwd,@phoneNumber)";
                                using (SqlCommand cmd = new SqlCommand(insertdata, dbConnect))
                                {
                                    cmd.Parameters.AddWithValue("@uid", studentAdmNoTxtBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@name", studentNameTxtBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@sname", studentSNameTxtBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", studentSNameTxtBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@age", studentSNameTxtBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@email", studentSNameTxtBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@phoneNumber", adminPhoneNumberTxtBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@course", adminPhoneNumberTxtBox.Text.Trim());
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    AdminDashboard adminDashboard = new AdminDashboard();
                                    adminDashboard.Show();
                                    this.Hide();
                                }
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

        private void DeregisterAdminBtn_Click(object sender, EventArgs e)
        {
            if (studentAdmNoTxtBox.Text == "" || studentNameTxtBox.Text == "")
            {
                MessageBox.Show("Must fill ID and Name textboxes ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dbConnect.State != ConnectionState.Open)
                {
                    try
                    {
                        dbConnect.Open();
                        //TO CHECK IF USER IS EXISTING ALREADY
                        string checkId = "SELECT COUNT (id) FROM student Table WHERE id = @uid";
                        using (SqlCommand checkUser = new SqlCommand(checkId, dbConnect))
                        {
                            checkUser.Parameters.AddWithValue("@name", studentNameTxtBox.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();
                            if (count < 1)
                            {
                                MessageBox.Show(studentNameTxtBox.Text.Trim() + "Does not exist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else//TO DELETE USER
                            {
                                DateTime today = DateTime.Today;
                                string deletedata = "DELETE FROM adminTable WHERE name =@name AND id = @uid;";

                                using (SqlCommand cmd = new SqlCommand(deletedata, dbConnect))
                                {
                                    cmd.Parameters.AddWithValue("@admno", studentAdmNoTxtBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@name", studentNameTxtBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@adminPwd", adminPwdTxtBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@phoneNumber", adminPhoneNumberTxtBox.Text.Trim());
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Deregistered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
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

        private void AdminRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManagementSystemDataSet.studentTable' table. You can move, or remove it, as needed.
            this.studentTableTableAdapter.Fill(this.studentManagementSystemDataSet.studentTable);

        }

        public void DashLogOutBtn_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void clearAdminFieldsBtn_Click(object sender, EventArgs e)
        {
            studentAdmNoTxtBox.Clear();
            studentAdmNoTxtBox.Clear();
            studentNameTxtBox.Clear();
            studentSNameTxtBox.Clear();
            adminPhoneNumberTxtBox.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adminIdTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

