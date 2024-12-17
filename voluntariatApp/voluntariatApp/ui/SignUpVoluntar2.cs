using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using voluntariatApp.controller;

namespace voluntariatApp
{
    public partial class SignUpVoluntar2 : Form
    {
        public SignUpVoluntar2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            controller.signUpUser(new List<string> { txtCNP.Text,txtName.Text,cmbOccupation.Text});

            frmLogin form1 = new frmLogin();
            this.Close();
            form1.Show();
        }
    }
}
