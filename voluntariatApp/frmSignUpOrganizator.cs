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
            frmLogin form1 = new frmLogin();
            this.Close();
            form1.Show();
        }

        private void frmSignUpOrganizator_Load(object sender, EventArgs e)
        {

        }
    }
}
