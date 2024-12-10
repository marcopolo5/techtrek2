using System;
using System.Windows.Forms;

namespace voluntariatApp
{
    public partial class frmCompanySearch : Form
    {
        public frmCompanySearch()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmUserDashboard userDashboard = new frmUserDashboard();
            this.Close();
            userDashboard.Show();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            frmEvents events = new frmEvents();
            this.Hide();
            events.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            panelCompanyDetails.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelCompanyDetails.Visible = true;
        }

        private void frmCompanySearch_Load(object sender, EventArgs e)
        {
            panelCompanyDetails.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmCompanySearch search = new frmCompanySearch();
            search.Show();
            this.Close();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            frmRegistration registration = new frmRegistration();
            registration.Show();
            this.Close();
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            frmTasks tasks = new frmTasks();
            tasks.Show();
            this.Close();
        }

        private void btnCertificates_Click(object sender, EventArgs e)
        {
            frmCertificates certificates = new frmCertificates();
            certificates.Show();
            this.Close();
        }
    }
}
