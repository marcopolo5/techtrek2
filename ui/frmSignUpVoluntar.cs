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
using voluntariatApp.domain.enums;
using voluntariatApp.test;

namespace voluntariatApp
{
    public partial class frmSignUpVoluntar : Form
    {
        public frmSignUpVoluntar()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSignUp signUp = new frmSignUp();
            this.Close();
            signUp.Show();
        }

        private void btnCreeazaContV_Click(object sender, EventArgs e)
        {
            Controller controller = Controller.getInstance();
            controller.signUpUser(new List<string> { txtCNP.Text, txtName.Text, cmbOccupation.Text });
            MessageBox.Show("Contul a fost creat cu succes!");

            frmLogin form1 = new frmLogin();
            this.Close();
            form1.Show();

        }

        private void SignUpVoluntar_Load(object sender, EventArgs e)
        {
            cmbOccupation.DataSource = Enum.GetValues(typeof(Occupation));
        }
    }
}
