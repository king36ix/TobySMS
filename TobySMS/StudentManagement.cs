using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TobySMS
{
    public partial class StudentManagement : Form
    {
        readonly SqlConnection dbConnect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kelvn\source\repos\LibraryManagementSystem\LibraryManagementSystem\StudentMgmtSystem.mdf;Integrated Security=True");
        public StudentManagement()
        {
            InitializeComponent();
        }

        private void BookRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StudentMangementSysDataSet.studentTable' table. You can move, or remove it, as needed.

        }

        private void registerAdminBtn_Click(object sender, EventArgs e)
        {

        }



        private void StudentNameSearch_Click(object sender, EventArgs e)
        {
            //retrieve the SQL Server instance version
            string titlesearch = @"SELECT * from studentTable where charindex(@name,name)>0;";
            try
            {
                //sql connection object
                using (SqlCommand checkUser = new SqlCommand(titlesearch, dbConnect))
                {


                    //define the SqlCommand object
                    SqlCommand cmd = new SqlCommand(titlesearch, dbConnect);

                    //Set the SqlDataAdapter object
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                    //cmd.Parameters.AddWithValue("@name", studentNameTxtBox.Text.Trim());
                    //define dataset
                    DataSet ds = new DataSet();

                    //fill dataset with query results
                    dAdapter.Fill(ds);

                    //set DataGridView control to read-only
                    catalogDataGridView.ReadOnly = true;

                    //set the DataGridView control's data source/data table
                    catalogDataGridView.DataSource = ds.Tables[0];


                    //close connection
                    dbConnect.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}
