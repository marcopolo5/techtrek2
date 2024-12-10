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
    public partial class SignUp1 : Form
    {
        public SignUp1()
        {
            InitializeComponent();
        }

        private void SignUp1_Load(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogare form1 = new frmLogare();
            this.Close();
            form1.Show();
        }

        private void btnOrganizator_Click(object sender, EventArgs e)
        {
            SignUpOrganizator form1 = new SignUpOrganizator();
            this.Close();
            form1.Show();
        }

        private void btnVoluntar_Click(object sender, EventArgs e)
        {
            SignUpVoluntar2 form1 = new SignUpVoluntar2();
            this.Close();
            form1.Show();
        }
    }
}
