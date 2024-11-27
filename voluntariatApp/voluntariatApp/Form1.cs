namespace voluntariatApp
{
    public partial class frmLogare : Form
    {
        public frmLogare()
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
            SignUp1 signUp1 = new SignUp1();
            this.Hide();
            signUp1.Show();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void lblWellcome_Click(object sender, EventArgs e)
        {

        }
    }
}
