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
    public partial class SignUpOrganizator : Form
    {
        public SignUpOrganizator()
        {
            InitializeComponent();
        }

        private void lblCUI_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp1 signUp1 = new SignUp1();
            this.Close();
            signUp1.Show();
        }

        private void btnCreeazaContV_Click(object sender, EventArgs e)
        {
            frmLogare form1 = new frmLogare();
            this.Close();
            form1.Show();
        }
    }
}
