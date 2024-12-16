﻿namespace voluntariatApp
{
	partial class frmLogin
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			lblWellcome = new Label();
			lblUser = new Label();
			lblPassword = new Label();
			txtName = new TextBox();
			txtPassword = new TextBox();
			likSingUp = new LinkLabel();
			btnLogin = new Button();
			btnExit = new Button();
			pictureBox1 = new PictureBox();
			panel1 = new Panel();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// lblWellcome
			// 
			lblWellcome.Font = new Font("Constantia", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblWellcome.Location = new Point(-1, 19);
			lblWellcome.Name = "lblWellcome";
			lblWellcome.Size = new Size(512, 69);
			lblWellcome.TabIndex = 0;
			lblWellcome.Text = "Bine ai venit!";
			lblWellcome.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblUser
			// 
			lblUser.AutoSize = true;
			lblUser.Font = new Font("Constantia", 16.2F);
			lblUser.Location = new Point(70, 263);
			lblUser.Name = "lblUser";
			lblUser.Size = new Size(70, 35);
			lblUser.TabIndex = 1;
			lblUser.Text = "User";
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.Font = new Font("Constantia", 16.2F);
			lblPassword.Location = new Point(70, 309);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(91, 35);
			lblPassword.TabIndex = 2;
			lblPassword.Text = "Parola";
			// 
			// txtName
			// 
			txtName.Font = new Font("Constantia", 16.2F);
			txtName.Location = new Point(271, 259);
			txtName.Name = "txtName";
			txtName.Size = new Size(163, 40);
			txtName.TabIndex = 3;
			// 
			// txtPassword
			// 
			txtPassword.Font = new Font("Constantia", 16.2F);
			txtPassword.Location = new Point(271, 304);
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '*';
			txtPassword.Size = new Size(163, 40);
			txtPassword.TabIndex = 4;
			// 
			// likSingUp
			// 
			likSingUp.AutoSize = true;
			likSingUp.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			likSingUp.Location = new Point(187, 491);
			likSingUp.Name = "likSingUp";
			likSingUp.Size = new Size(113, 24);
			likSingUp.TabIndex = 5;
			likSingUp.TabStop = true;
			likSingUp.Text = "Creare cont";
			likSingUp.LinkClicked += likSingUp_LinkClicked;
			// 
			// btnLogin
			// 
			btnLogin.BackColor = Color.FromArgb(171, 215, 206);
			btnLogin.FlatAppearance.BorderColor = Color.FromArgb(241, 201, 212);
			btnLogin.FlatAppearance.BorderSize = 5;
			btnLogin.FlatStyle = FlatStyle.Flat;
			btnLogin.Font = new Font("Constantia", 16.2F);
			btnLogin.Location = new Point(271, 417);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(174, 61);
			btnLogin.TabIndex = 6;
			btnLogin.Text = "Logare";
			btnLogin.UseVisualStyleBackColor = false;
			btnLogin.Click += btnLogin_Click;
			// 
			// btnExit
			// 
			btnExit.BackColor = Color.FromArgb(171, 215, 206);
			btnExit.FlatAppearance.BorderColor = Color.FromArgb(241, 201, 212);
			btnExit.FlatAppearance.BorderSize = 5;
			btnExit.FlatStyle = FlatStyle.Flat;
			btnExit.Font = new Font("Constantia", 16.2F);
			btnExit.Location = new Point(66, 417);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(174, 61);
			btnExit.TabIndex = 7;
			btnExit.Text = "Iesire";
			btnExit.UseVisualStyleBackColor = false;
			btnExit.Click += btnExit_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(165, 107);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(182, 121);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 8;
			pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(lblWellcome);
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(lblUser);
			panel1.Controls.Add(btnExit);
			panel1.Controls.Add(lblPassword);
			panel1.Controls.Add(btnLogin);
			panel1.Controls.Add(txtName);
			panel1.Controls.Add(likSingUp);
			panel1.Controls.Add(txtPassword);
			panel1.Location = new Point(334, 77);
			panel1.Name = "panel1";
			panel1.Size = new Size(512, 550);
			panel1.TabIndex = 13;
			// 
			// frmLogin
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoValidate = AutoValidate.EnablePreventFocusChange;
			BackColor = Color.White;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(1179, 707);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "frmLogin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Logare";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label lblWellcome;
        private Label lblUser;
        private Label lblPassword;
        private TextBox txtName;
        private TextBox txtPassword;
        private LinkLabel likSingUp;
        private Button btnLogin;
        private Button btnExit;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
