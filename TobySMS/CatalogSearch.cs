using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TobySMS
{

    public partial class CatalogSearch : Form
    {   //TODO:Pass data between forms on call
        public static CatalogSearch Instance = new CatalogSearch();
        public TextBox bTitleTextbox;
        public TextBox authorTxtBox;
        readonly SqlConnection dbConnect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kelvn\source\repos\LibraryManagementSystem\LibraryManagementSystem\StudentMgmtSystem.mdf;Integrated Security=True");
        public CatalogSearch()
        {
            InitializeComponent();
            Instance = this;
            bTitleTextbox = studentNameTxtBox;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CatalogSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StudentMangementSysDataSet.studentTable' table. You can move, or remove it, as needed.

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
                    cmd.Parameters.AddWithValue("@name", studentNameTxtBox.Text.Trim());
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
        private void SearchbyAuthorBtn_Click(object sender, EventArgs e)
        {
            //retrieve the SQL Server instance version
            string authorsearch = @"SELECT * from studentTable where charindex(@author,author)>0;";
            try
            {
                //sql connection object
                using (SqlCommand checkUser = new SqlCommand(authorsearch, dbConnect))
                {
                    //define the SqlCommand object
                    SqlCommand cmd = new SqlCommand(authorsearch, dbConnect);

                    //Set the SqlDataAdapter object
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                    cmd.Parameters.AddWithValue("@name", studentNameTxtBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@author", authorTxtBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@publishDate", publishTxtBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@category", categoryTxtBox.Text.Trim());

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
        private void SearchbyISBNBtn_Click(object sender, EventArgs e)
        {

            //retrieve the SQL Server instance version
            string isbnsearch = @"SELECT * from studentTable where charindex(@admNo,author)>0;";
            try
            {
                //sql connection object
                using (SqlCommand checkUser = new SqlCommand(isbnsearch, dbConnect))
                {
                    //define the SqlCommand object
                    SqlCommand cmd = new SqlCommand(isbnsearch, dbConnect);

                    //Set the SqlDataAdapter object
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                    cmd.Parameters.AddWithValue("@admNo", isbnoTxtBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", studentNameTxtBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@author", authorTxtBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@publishDate", publishTxtBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@category", categoryTxtBox.Text.Trim());

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
        private void SearchByPublishBtn_Click(object sender, EventArgs e)
        {
            //retrieve the SQL Server instance version
            string isbnsearch = @"SELECT * from studentTable where charindex(@publishDate,publishDate)>0;";
            try
            {
                //sql connection object
                using (SqlCommand checkUser = new SqlCommand(isbnsearch, dbConnect))
                {
                    //define the SqlCommand object
                    SqlCommand cmd = new SqlCommand(isbnsearch, dbConnect);
                    //Set the SqlDataAdapter object
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                    cmd.Parameters.AddWithValue("@admNo", isbnoTxtBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", studentNameTxtBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@author", authorTxtBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@publishDate", publishTxtBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@category", categoryTxtBox.Text.Trim());

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
        private void SearchByCategoryBtn_Click(object sender, EventArgs e)
        {
            //retrieve the SQL Server instance version
            string categorysearch = @"SELECT * from studentTable where charindex(@category,category)>0;";
            try
            {
                //sql connection object
                using (SqlCommand checkUser = new SqlCommand(categorysearch, dbConnect))
                {
                    //define the SqlCommand object
                    SqlCommand cmd = new SqlCommand(categorysearch, dbConnect);
                    //Set the SqlDataAdapter object
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                    cmd.Parameters.AddWithValue("@admNo", isbnoTxtBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", studentNameTxtBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@author", authorTxtBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@publishDate", publishTxtBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@category", categoryTxtBox.Text.Trim());

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


        private void BacktoDash_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void IssueBookBtn_Click(object sender, EventArgs e)
        {
            StudentRegistration issueBook = new StudentRegistration();
            issueBook.Show();
            this.Hide();
        }

        private void CatalogDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DashLogOutBtn_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }
    }
}
