using System;
using System.Windows.Forms;

namespace TobySMS
{
    public partial class AdminDashboard : Form
    {
        private int secondsRemaining = 60; // Initial countdown time in seconds

        public AdminDashboard()
        {
            InitializeComponent();

        }
        private void Timer_Tick(object sender, EventArgs e)
        {

        }

        public void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void studentRegButton_Click(object sender, EventArgs e)
        {
            dashboardMainPanel.Controls.Clear();
            StudentRegistration studentRegistration = new StudentRegistration();
            studentRegistration.TopLevel = false;
            dashboardMainPanel.Controls.Add(studentRegistration);
            studentRegistration.Dock = DockStyle.Fill;
            studentRegistration.Show();
        }

        private void studentManageButton_Click(object sender, EventArgs e)
        {
            dashboardMainPanel.Controls.Clear();
            StudentManagement bookRegistration = new StudentManagement();
            bookRegistration.TopLevel = false;
            dashboardMainPanel.Controls.Add(bookRegistration);
            bookRegistration.Dock = DockStyle.Fill; bookRegistration.Show();
        }
    }
}
