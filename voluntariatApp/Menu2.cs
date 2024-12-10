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
    public partial class Menu2 : Form
    {
        public Menu2()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogare signUp1 = new frmLogare();
            this.Hide();
            signUp1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmLogare signUp1 = new frmLogare();
            this.Hide();
            signUp1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Menu2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            CautareUseri cautari = new CautareUseri();
            this.Hide();
            cautari.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inscrieri inscrieri = new Inscrieri();
            this.Hide();
            inscrieri.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdaugaAnunt adaugaAnunt = new AdaugaAnunt();
            this.Hide();
            adaugaAnunt.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();

            // Dimensiuni și spațiere
            int labelWidth = 120; // Lățimea etichetei
            int textBoxWidth = 250; // Lățimea TextBox-ului
            int controlHeight = 40; // Înălțimea fiecărui control
            int spacing = 20; // Spațiul dintre rânduri
            int startX = 50; // Poziția X de început
            int startY = 50; // Poziția Y de început
            List<String> labels = new List<String> { "Nume", "Nr Participanti", "Perioada", "Conditii", "Despre" };
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
                TextBox textBox = new TextBox();
                textBox.ReadOnly = true; // Doar citire
                textBox.Text = $"ReadOnly {i + 1}"; // Text implicit
                textBox.Font = new Font("Constantia", 14);
                textBox.Size = new System.Drawing.Size(textBoxWidth, controlHeight); // Dimensiuni
                textBox.Location = new System.Drawing.Point(startX + labelWidth + spacing, startY + i * (controlHeight + spacing)); // Poziție
                panel5.Controls.Add(textBox); // Adăugare în panel
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();

            // Dimensiuni și spațiere
            int labelWidth = 120; // Lățimea etichetei
            int textBoxWidth = 250; // Lățimea TextBox-ului
            int controlHeight = 40; // Înălțimea fiecărui control
            int spacing = 20; // Spațiul dintre rânduri
            int startX = 50; // Poziția X de început
            int startY = 50; // Poziția Y de început
            List<String> labels = new List<String> { "Nume", "Nr Participanti", "Perioada", "Conditii", "Despre" };
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
                TextBox textBox = new TextBox();
                textBox.Text = $"ReadOnly {i + 1}"; // Text implicit
                textBox.Font = new Font("Constantia", 14);
                textBox.Size = new System.Drawing.Size(textBoxWidth, controlHeight); // Dimensiuni
                textBox.Location = new System.Drawing.Point(startX + labelWidth + spacing, startY + i * (controlHeight + spacing)); // Poziție
                panel5.Controls.Add(textBox); // Adăugare în panel
            }
            Button button = new Button();
            button.Text = "Salveaza";
            button.Size = new System.Drawing.Size(174, 61);
            button.FlatStyle = FlatStyle.Flat;
            button.Location = new System.Drawing.Point(200, 400);
            button.FlatAppearance.BorderSize = 5;
            button.FlatAppearance.BorderColor = Color.FromArgb(241, 201, 212);
            button.BackColor = Color.FromArgb(171, 215, 206);
            button.Font = new Font("Constantia", 16); // Create a new Font object with the desired properties
            panel5.Controls.Add(button);
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
