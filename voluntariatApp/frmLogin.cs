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
            frmUserDashboard dashboard = new frmUserDashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}
