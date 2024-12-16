using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using voluntariatApp.test;

namespace voluntariatApp
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin form1 = new frmLogin();
            this.Close();
            form1.Show();
        }

        private void btnOrganizator_Click(object sender, EventArgs e)
        {
            Controller controller = Controller.getInstance();

            controller.addData(new List<string> { txtUsername.Text, txtPassword.Text, txtPhone.Text, txtEmail.Text });

            frmSignUpOrganizator signup = new frmSignUpOrganizator();
            this.Hide();
            signup.Show();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnVoluntar_Click(object sender, EventArgs e)
        {

            Controller controller = Controller.getInstance();

            controller.addData(new List<string> { txtUsername.Text, txtPassword.Text, txtPhone.Text, txtEmail.Text });

            frmSignUpVoluntar signUpVoluntar = new frmSignUpVoluntar();
            this.Close();
            signUpVoluntar.Show();
        }
    }
}
