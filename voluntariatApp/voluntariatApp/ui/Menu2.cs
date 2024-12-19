using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using voluntariatApp.controller;
using voluntariatApp.domain;
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
            Adeverinte adev = new Adeverinte();
            this.Hide();
            adev.Show();
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
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var ev = (Event)button.Tag;
            panel5.Controls.Clear();

            // Dimensiuni și spațiere
            int labelWidth = 120; // Lățimea etichetei
            int textBoxWidth = 250; // Lățimea TextBox-ului
            int controlHeight = 40; // Înălțimea fiecărui control
            int spacing = 20; // Spațiul dintre rânduri
            int startX = 50; // Poziția X de început
            int startY = 50; // Poziția Y de început
            var properties = new List<(string Name, string Value)>
            {
                ("Nume",ev.Name),
                ("Nr Participanti", ev.NumberOfParticipants.ToString()),
                ("Locatie", ev.Location.ToString()),
                ("Perioada", $"{ev.Period.StartDate:yyyy-MM-dd} to {ev.Period.EndDate:yyyy-MM-dd}"),
                ("Descriere",ev.EventDescription)
            };
            for (int i = 0; i < properties.Count; i++)
            {
                var property = properties[i];
                string propertyName = property.Name;
                string propertyValue = property.Value;

                // Create Label
                Label label = new Label();
                label.Text = propertyName; // Label text
                label.Font = new Font("Constantia", 14);
                label.Size = new System.Drawing.Size(labelWidth, controlHeight); // Dimensions
                label.Location = new System.Drawing.Point(startX, startY + i * (controlHeight + spacing)); // Position
                panel5.Controls.Add(label); // Add to panel

                if (propertyName == "Descriere")
                {
                    // Create TextBox
                    RichTextBox textBox = new RichTextBox();
                    textBox.ReadOnly = true; // Read-only
                    textBox.Text = propertyValue; // Default text
                    textBox.Font = new Font("Constantia", 14);
                    textBox.Size = new System.Drawing.Size(textBoxWidth, controlHeight+50); // Dimensions
                    textBox.Location = new System.Drawing.Point(startX + labelWidth + spacing, startY + i * (controlHeight + spacing)); // Position
                    panel5.Controls.Add(textBox); // Add to panel
                }
                else
                {
                    // Create TextBox
                    TextBox textBox = new TextBox();
                    textBox.ReadOnly = true; // Read-only
                    textBox.Text = propertyValue; // Default text
                    textBox.Font = new Font("Constantia", 14);
                    textBox.Size = new System.Drawing.Size(textBoxWidth, controlHeight); // Dimensions
                    textBox.Location = new System.Drawing.Point(startX + labelWidth + spacing, startY + i * (controlHeight + spacing)); // Position
                    panel5.Controls.Add(textBox); // Add to panel
                }
            }
        }
        private void SalveazaBtn(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var ev = (Event)button.Tag;
        }
        private void Button_Click2(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var ev = (Event)button.Tag;
            panel5.Controls.Clear();

            // Dimensiuni și spațiere
            int labelWidth = 120; // Lățimea etichetei
            int textBoxWidth = 250; // Lățimea TextBox-ului
            int controlHeight = 40; // Înălțimea fiecărui control
            int spacing = 20; // Spațiul dintre rânduri
            int startX = 50; // Poziția X de început
            int startY = 50; // Poziția Y de început
            var properties = new List<(string Name, string Value)>
            {
                ("Nume",ev.Name),
                ("Nr Participanti", ev.NumberOfParticipants.ToString()),
                ("Locatie", ev.Location.ToString()),
                ("Perioada", $"{ev.Period.StartDate:yyyy-MM-dd} to {ev.Period.EndDate:yyyy-MM-dd}"),
                ("Descriere",ev.EventDescription)
            };
            for (int i = 0; i < properties.Count; i++)
            {
                var property = properties[i];
                string propertyName = property.Name;
                string propertyValue = property.Value;

                // Create Label
                Label label = new Label();
                label.Text = propertyName; // Label text
                label.Font = new Font("Constantia", 14);
                label.Size = new System.Drawing.Size(labelWidth, controlHeight); // Dimensions
                label.Location = new System.Drawing.Point(startX, startY + i * (controlHeight + spacing)); // Position
                panel5.Controls.Add(label); // Add to panel

                if (propertyName == "Descriere")
                {
                    // Create TextBox
                    RichTextBox textBox = new RichTextBox();
                    textBox.Name = propertyName;
                    textBox.Text = propertyValue; // Default text
                    textBox.Font = new Font("Constantia", 14);
                    textBox.Size = new System.Drawing.Size(textBoxWidth, controlHeight + 50); // Dimensions
                    textBox.Location = new System.Drawing.Point(startX + labelWidth + spacing, startY + i * (controlHeight + spacing)); // Position
                    panel5.Controls.Add(textBox); // Add to panel
                }
                else
                {
                    // Create TextBox
                    TextBox textBox = new TextBox();
                    textBox.Name = propertyName;
                    textBox.Text = propertyValue; // Default text
                    textBox.Font = new Font("Constantia", 14);
                    textBox.Size = new System.Drawing.Size(textBoxWidth, controlHeight); // Dimensions
                    textBox.Location = new System.Drawing.Point(startX + labelWidth + spacing, startY + i * (controlHeight + spacing)); // Position
                    panel5.Controls.Add(textBox); // Add to panel
                }
            }
            Button salveaza = new Button();
            salveaza.Size = new Size(200, 50);
            salveaza.FlatStyle = FlatStyle.Flat;
            salveaza.Location = new Point(startX + labelWidth + spacing, 420);
            salveaza.Text = "Salveaza";
            salveaza.Tag=ev;
            salveaza.Click += new EventHandler(SalveazaBtn);
            panel5.Controls.Add(salveaza);
        }
        private void Button_Click3(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var ev = (Event)button.Tag;
            Controller.getInstance().deleteEvent(ev.getId());
            Menu2_Load(sender, e);
        }
        private void Menu2_Load(object sender, EventArgs e)
        {
            var yourEvents = Controller.getInstance().organizationEvents();
            for (int i = 0; i < yourEvents.Count; i++)
            {
                var ev = yourEvents[i];

                Panel panel = new Panel();
                panel.Size = new Size(350, 130);
                panel.BackColor = Color.FromArgb(255, 255, 255);
                panel.BorderStyle = BorderStyle.None;
                panel.Location = new Point(200, 85+i*150);

                Label label = new Label();
                label.Size = new Size(130, 20);
                label.BorderStyle = BorderStyle.None;
                label.Location = new Point(107, 24 );
                label.Text = $"{ev.Name}";

                Label label2 = new Label();
                label2.Size = new Size(130, 20);
                label2.BorderStyle = BorderStyle.None;
                label2.Location = new Point(107, 60);
                label2.Text = $"Capacitate:{ev.NumberOfParticipants}";

            Label label3 = new Label();
                label3.Size = new Size(130, 20);
                label3.BackColor = Color.FromArgb(255, 255, 255);
                label3.BorderStyle = BorderStyle.None;
                label3.Location = new Point(107, 95);
            label3.Text = "Interval Eveniment";

            Label label4 = new Label();
            label4.Size = new Size(50, 20);
            label4.BorderStyle = BorderStyle.None;
            label4.Location = new Point(39, 13);
            label4.Text = "Activ";
            
            Button button = new Button();
            button.Size = new Size(80, 30);
            button.FlatStyle = FlatStyle.Flat;
            button.Location = new Point(257, 15);
            button.Text = "Preview";
            button.Tag = ev;
            button.Click += new EventHandler(Button_Click);

            Button button2 = new Button();
            button2.Size = new Size(80, 30);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(257, 51);
            button2.Text = "Editeaza";
            button2.Tag = ev;
            button2.Click += new EventHandler(Button_Click2);

            Button button3 = new Button();
            button3.Size = new Size(80, 30);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(257, 85);
            button3.Text = "Sterge";
            button3.Tag = ev;
            button3.Click += new EventHandler(Button_Click3);


                panel.Controls.Add(button);
            panel.Controls.Add(button2);
            panel.Controls.Add(button3);
            panel.Controls.Add(label4);
            panel.Controls.Add(label);
            panel.Controls.Add(label2);
            panel.Controls.Add(label3);
            
            this.Controls.Add(panel);
            }
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
