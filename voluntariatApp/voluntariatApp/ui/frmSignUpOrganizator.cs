using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using voluntariatApp.domain.enums;
using voluntariatApp.test;

namespace voluntariatApp
{
    public partial class frmSignUpOrganizator : Form
    {
        public frmSignUpOrganizator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSignUp signUp1 = new frmSignUp();
            this.Close();
            signUp1.Show();
        }

        private void btnCreeazaContV_Click(object sender, EventArgs e)
        {
            Controller controller = Controller.getInstance();
            controller.signUpOrganizator(new List<string> { txtCUI.Text, txtName.Text, cmbType.Text, rtxtDescription.Text });
            MessageBox.Show("Contul a fost creat cu succes!");
            frmLogin form1 = new frmLogin();
            this.Close();
            form1.Show();
        }

        private void frmSignUpOrganizator_Load(object sender, EventArgs e)
        {
            cmbType.DataSource = Enum.GetValues(typeof(OrganiserType));
        }
    }
}
