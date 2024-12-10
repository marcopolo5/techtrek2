using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voluntariatApp
{
    public partial class Inscrieri : Form
    {
        public Inscrieri()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu2 evenimente = new Menu2();
            this.Hide();
            evenimente.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CautareUseri evenimente = new CautareUseri();
            this.Hide();
            evenimente.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            List<String> labels = new List<String> { "Nume", "Ocupatie"};
            List<String> buttonText=new List<String> { "Accepta", "Respinge" };
            for (int i = 1; i <= 2; i++)
            {
                Panel panel = new Panel();
                panel.Size = new System.Drawing.Size(500, 100); // Set the size of the panel
                panel.Location = new System.Drawing.Point(10, (i - 1) * 110 + 20); // Adjusted spacing between panels
                panel.BorderStyle = BorderStyle.FixedSingle;

                for (int j = 1; j <= 2; j++)
                {
                    Label label = new Label();
                    label.Text = labels[j - 1];
                    label.Font = new Font("Constantia", 14);
                    label.Size = new System.Drawing.Size(150, 50);
                    label.Location = new System.Drawing.Point(10, (j - 1) * 50 + 10); // Position labels within the panel
                    panel.Controls.Add(label);

                    TextBox textBox = new TextBox();
                    textBox.Text = "Dani";
                    textBox.ReadOnly = true;
                    textBox.Font = new Font("Constantia", 14);
                    textBox.Size = new System.Drawing.Size(150, 50);
                    textBox.Location = new System.Drawing.Point(160, (j - 1) * 50 + 10); // Position labels within the panel
                    panel.Controls.Add(textBox);

                    Button button = new Button();
                    button.Text = buttonText[j - 1];
                    button.Font = new Font("Constantia", 14);
                    button.Size = new System.Drawing.Size(130, 40);
                    button.Location= new System.Drawing.Point(350, (j - 1) * 50+7);
                    button.FlatStyle = FlatStyle.Flat;
                    button.BackColor = Color.FromArgb(171, 215, 206);
                    panel.Controls.Add(button);
                }
                panel5.Controls.Add(panel);
            }
        }
    }
}
