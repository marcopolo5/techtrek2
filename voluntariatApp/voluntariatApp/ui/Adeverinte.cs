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
    public partial class Adeverinte : Form
    {
        public Adeverinte()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu2 evenimente = new Menu2();
            this.Hide();
            evenimente.Show();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            // Dimensiuni și spațiere
            int labelWidth = 120; // Lățimea etichetei
            int textBoxWidth = 250; // Lățimea TextBox-ului
            int controlHeight = 40; // Înălțimea fiecărui control
            int spacing = 20; // Spațiul dintre rânduri
            int startX = 50; // Poziția X de început
            int startY = 50; // Poziția Y de început
            List<String> labels = new List<String> { "Nume", "Nume2", "Nume3", "Nume4", "Nume5" };
            for (int i = 0; i < 5; i++)
            {
                // Creare Label
                Label label = new Label();
                label.Text = labels[i]; // Textul etichetei
                label.Font = new Font("Constantia", 14);
                label.Size = new System.Drawing.Size(labelWidth, controlHeight); // Dimensiuni
                label.Location = new System.Drawing.Point(startX, startY + i * (controlHeight + spacing)); // Poziție
                panel5.Controls.Add(label); // Adăugare în panel

                // Creare TextBox
                Button textBox = new Button();
                textBox.Text = "Elibereaza"; // Text implicit
                textBox.Font = new Font("Constantia", 14);
                textBox.Size = new System.Drawing.Size(textBoxWidth, controlHeight); // Dimensiuni
                textBox.Location = new System.Drawing.Point(startX + labelWidth + spacing, startY + i * (controlHeight + spacing)); // Poziție
                panel5.Controls.Add(textBox); // Adăugare în panel
            }
        }

        private void Adeverinte_Load(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.Size = new Size(350, 130);
            panel.BackColor = Color.FromArgb(0, 255, 0);
            panel.BorderStyle = BorderStyle.None;
            panel.Location = new Point(200, 85);

            Label label = new Label();
            label.Size = new Size(122, 20);
            label.BorderStyle = BorderStyle.None;
            label.Location = new Point(171, 13);
            label.Text = "Nume Eveniment";

            Label label4 = new Label();
            label4.Size = new Size(50, 20);
            label4.BorderStyle = BorderStyle.None;
            label4.Location = new Point(39, 13);
            label4.Text = "Activ";

            Button button3 = new Button();
            button3.Size = new Size(168, 50);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(148, 51);
            button3.Text = "Elibereaza adeverinte";
            button3.Click += new EventHandler(Button_Click);

            panel.Controls.Add(button3);
            panel.Controls.Add(label4);
            panel.Controls.Add(label);
            this.Controls.Add(panel);
        }
    }
}
