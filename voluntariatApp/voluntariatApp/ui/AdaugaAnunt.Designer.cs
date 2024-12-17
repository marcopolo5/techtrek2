namespace voluntariatApp
{
    partial class AdaugaAnunt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            txtPhone = new TextBox();
            lblTitle = new Label();
            lblLocation = new Label();
            lblPhone = new Label();
            lblName = new Label();
            btnAdd = new Button();
            txtParticipants = new TextBox();
            txtLocation = new TextBox();
            lblParticipants = new Label();
            txtName = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(118, 203, 200);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(63, 54);
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblLocation);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtParticipants);
            panel1.Controls.Add(txtLocation);
            panel1.Controls.Add(lblParticipants);
            panel1.Controls.Add(txtName);
            panel1.Location = new Point(334, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 550);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(271, 365);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(163, 57);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 369);
            label2.Name = "label2";
            label2.Size = new Size(100, 35);
            label2.TabIndex = 14;
            label2.Text = "Despre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(271, 324);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 27);
            textBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 316);
            label1.Name = "label1";
            label1.Size = new Size(114, 35);
            label1.TabIndex = 12;
            label1.Text = "Conditii";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(271, 277);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(163, 27);
            txtPhone.TabIndex = 7;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Constantia", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(70, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(396, 49);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Adauga un eveniment";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocation.Location = new Point(70, 219);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(103, 35);
            lblLocation.TabIndex = 2;
            lblLocation.Text = "Locatie";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = Color.White;
            lblPhone.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(70, 270);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(119, 35);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Perioada";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(70, 111);
            lblName.Name = "lblName";
            lblName.Size = new Size(89, 35);
            lblName.TabIndex = 0;
            lblName.Text = "Nume";
            lblName.Click += lblName_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(171, 215, 206);
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(241, 201, 212);
            btnAdd.FlatAppearance.BorderSize = 5;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(162, 449);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(174, 61);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Adauga";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtParticipants
            // 
            txtParticipants.Location = new Point(271, 172);
            txtParticipants.Name = "txtParticipants";
            txtParticipants.Size = new Size(163, 27);
            txtParticipants.TabIndex = 5;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(271, 227);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(163, 27);
            txtLocation.TabIndex = 6;
            // 
            // lblParticipants
            // 
            lblParticipants.AutoSize = true;
            lblParticipants.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParticipants.Location = new Point(70, 165);
            lblParticipants.Name = "lblParticipants";
            lblParticipants.Size = new Size(195, 35);
            lblParticipants.TabIndex = 1;
            lblParticipants.Text = "Nr Participanti";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.HighlightText;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(271, 119);
            txtName.Name = "txtName";
            txtName.Size = new Size(163, 27);
            txtName.TabIndex = 4;
            // 
            // AdaugaAnunt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 707);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "AdaugaAnunt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdaugaAnunt";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private TextBox txtPhone;
        private Label lblTitle;
        private Label lblLocation;
        private Label lblPhone;
        private Label lblName;
        private Button btnAdd;
        private TextBox txtParticipants;
        private TextBox txtLocation;
        private Label lblParticipants;
        private TextBox txtName;
        private RichTextBox richTextBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}