namespace voluntariatApp
{
    partial class frmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignUp));
            lblUsername = new Label();
            lblPassword = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            btnVoluntar = new Button();
            btnOrganizator = new Button();
            lblTitle = new Label();
            panel1 = new Panel();
            label1 = new Label();
            btnArrow = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Constantia", 16.2F);
            lblUsername.Location = new Point(70, 173);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(136, 35);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Constantia", 16.2F);
            lblPassword.Location = new Point(70, 219);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 35);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Parola";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Constantia", 16.2F);
            lblEmail.Location = new Point(70, 263);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(84, 35);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = Color.White;
            lblPhone.Font = new Font("Constantia", 16.2F);
            lblPhone.Location = new Point(70, 309);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(104, 35);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Telefon";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.HighlightText;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(271, 187);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(163, 27);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(271, 229);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(163, 27);
            txtPassword.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(271, 273);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(163, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(271, 320);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(163, 27);
            txtPhone.TabIndex = 7;
            // 
            // btnVoluntar
            // 
            btnVoluntar.BackColor = Color.FromArgb(171, 215, 206);
            btnVoluntar.FlatAppearance.BorderColor = Color.FromArgb(241, 201, 212);
            btnVoluntar.FlatAppearance.BorderSize = 5;
            btnVoluntar.FlatStyle = FlatStyle.Flat;
            btnVoluntar.Font = new Font("Comic Sans MS", 13.8F);
            btnVoluntar.Location = new Point(271, 417);
            btnVoluntar.Name = "btnVoluntar";
            btnVoluntar.Size = new Size(174, 61);
            btnVoluntar.TabIndex = 8;
            btnVoluntar.Text = "Voluntar";
            btnVoluntar.UseVisualStyleBackColor = false;
            btnVoluntar.Click += btnVoluntar_Click;
            // 
            // btnOrganizator
            // 
            btnOrganizator.AutoSize = true;
            btnOrganizator.BackColor = Color.FromArgb(171, 215, 206);
            btnOrganizator.FlatAppearance.BorderColor = Color.FromArgb(241, 201, 212);
            btnOrganizator.FlatAppearance.BorderSize = 5;
            btnOrganizator.FlatStyle = FlatStyle.Flat;
            btnOrganizator.Font = new Font("Comic Sans MS", 13.8F);
            btnOrganizator.Location = new Point(66, 417);
            btnOrganizator.Name = "btnOrganizator";
            btnOrganizator.Size = new Size(185, 68);
            btnOrganizator.TabIndex = 9;
            btnOrganizator.Text = "Organizator";
            btnOrganizator.UseVisualStyleBackColor = false;
            btnOrganizator.Click += btnOrganizator_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Constantia", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(81, 75);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(327, 54);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Creeaza un cont";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(btnVoluntar);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(btnOrganizator);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Location = new Point(330, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 550);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 387);
            label1.Name = "label1";
            label1.Size = new Size(320, 28);
            label1.TabIndex = 14;
            label1.Text = "Ce tip de cont dorești să creezi?";
            // 
            // btnArrow
            // 
            btnArrow.BackColor = Color.FromArgb(118, 203, 200);
            btnArrow.BackgroundImageLayout = ImageLayout.Stretch;
            btnArrow.FlatAppearance.BorderSize = 0;
            btnArrow.FlatStyle = FlatStyle.Flat;
            btnArrow.Location = new Point(11, 12);
            btnArrow.Name = "btnArrow";
            btnArrow.Size = new Size(63, 53);
            btnArrow.TabIndex = 13;
            btnArrow.UseVisualStyleBackColor = false;
            btnArrow.Click += button1_Click;
            // 
            // frmSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1179, 707);
            Controls.Add(btnArrow);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += frmSignUp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private Label lblEmail;
        private Label lblPhone;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Button btnVoluntar;
        private Button btnOrganizator;
        private Label lblTitle;
        private Panel panel1;
        private Button btnArrow;
        private Label label1;
    }
}