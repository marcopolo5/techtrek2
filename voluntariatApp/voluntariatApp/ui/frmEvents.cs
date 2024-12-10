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
    public partial class frmEvents : Form
    {
        public frmEvents()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmUserDashboard userDashboard = new frmUserDashboard();
            this.Close();
            userDashboard.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmCompanySearch companySearch = new frmCompanySearch();
            this.Hide();
            companySearch.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelEventDetails.Visible = true;
        }

        private void btnCloseDetails_Click(object sender, EventArgs e)
        {
            panelEventDetails.Visible = false;
        }

        private void frmEvents_Load(object sender, EventArgs e)
        {
            panelEventDetails.Visible = false;
            panelEventRegistration.Visible = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            panelEventRegistration.Visible = false;
            panelEventDetails.BackColor = Color.White;
        }

        private void btnEventRegistration_Click(object sender, EventArgs e)
        {
            panelEventRegistration.Visible = false;
            panelEventDetails.BackColor = Color.White;
        }

        private void btnInscriere_Click(object sender, EventArgs e)
        {
            panelEventRegistration.Visible = true;
            panelEventDetails.BackColor = Color.DarkGray;
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
