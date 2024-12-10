using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voluntariatApp
{
    public partial class frmTasks : Form
    {
        public frmTasks()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmUserDashboard userDashboard = new frmUserDashboard();
            userDashboard.Show();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmCompanySearch search = new frmCompanySearch();
            search.Show();
            this.Close();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            frmEvents events = new frmEvents();
            events.Show();
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
