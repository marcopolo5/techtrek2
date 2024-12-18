using voluntariatApp.controller;

namespace voluntariatApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void likSingUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp signUp1 = new frmSignUp();
            this.Hide();
            signUp1.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!Controller.getInstance().login(txtName.Text, txtPassword.Text))
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }
            txtName.Clear();
            txtPassword.Clear();
            frmUserDashboard dashboard = new frmUserDashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}
