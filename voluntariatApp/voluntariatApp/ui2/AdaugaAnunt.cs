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
    public partial class AdaugaAnunt : Form
    {
        public AdaugaAnunt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu2 dashboard = new Menu2();
            this.Hide();
            dashboard.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Menu2 dashboard = new Menu2();
            this.Hide();
            dashboard.Show();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
