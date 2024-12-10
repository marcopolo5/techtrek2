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
            frmSignUpOrganizator form1 = new frmSignUpOrganizator();
            this.Close();
            form1.Show();
        }
    }
}
