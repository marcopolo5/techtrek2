﻿namespace voluntariatApp
{
    partial class frmSignUpOrganizator
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignUpOrganizator));
			lblCUI = new Label();
			lblName = new Label();
			lblType = new Label();
			lblDescription = new Label();
			txtCUI = new TextBox();
			rtxtDescription = new RichTextBox();
			cmbType = new ComboBox();
			txtName = new TextBox();
			panel1 = new Panel();
			lblTitle = new Label();
			btnCreeazaContV = new Button();
			btnArrow = new Button();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// lblCUI
			// 
			lblCUI.AutoSize = true;
			lblCUI.Font = new Font("Constantia", 16.2F);
			lblCUI.Location = new Point(61, 130);
			lblCUI.Name = "lblCUI";
			lblCUI.Size = new Size(49, 27);
			lblCUI.TabIndex = 0;
			lblCUI.Text = "CUI";
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Font = new Font("Constantia", 16.2F);
			lblName.Location = new Point(61, 164);
			lblName.Name = "lblName";
			lblName.Size = new Size(71, 27);
			lblName.TabIndex = 1;
			lblName.Text = "Nume";
			// 
			// lblType
			// 
			lblType.AutoSize = true;
			lblType.Font = new Font("Constantia", 16.2F);
			lblType.Location = new Point(61, 196);
			lblType.Name = "lblType";
			lblType.Size = new Size(44, 27);
			lblType.TabIndex = 2;
			lblType.Text = "Tip";
			// 
			// lblDescription
			// 
			lblDescription.AutoSize = true;
			lblDescription.Font = new Font("Constantia", 16.2F);
			lblDescription.Location = new Point(61, 232);
			lblDescription.Name = "lblDescription";
			lblDescription.Size = new Size(103, 27);
			lblDescription.TabIndex = 3;
			lblDescription.Text = "Descriere";
			// 
			// txtCUI
			// 
			txtCUI.Font = new Font("Constantia", 16.2F);
			txtCUI.Location = new Point(237, 127);
			txtCUI.Margin = new Padding(3, 2, 3, 2);
			txtCUI.Name = "txtCUI";
			txtCUI.Size = new Size(143, 34);
			txtCUI.TabIndex = 4;
			// 
			// rtxtDescription
			// 
			rtxtDescription.BorderStyle = BorderStyle.FixedSingle;
			rtxtDescription.Font = new Font("Constantia", 16.2F);
			rtxtDescription.Location = new Point(237, 227);
			rtxtDescription.Margin = new Padding(3, 2, 3, 2);
			rtxtDescription.Name = "rtxtDescription";
			rtxtDescription.Size = new Size(143, 48);
			rtxtDescription.TabIndex = 5;
			rtxtDescription.Text = "";
			// 
			// cmbType
			// 
			cmbType.Font = new Font("Constantia", 16.2F);
			cmbType.FormattingEnabled = true;
			cmbType.Location = new Point(237, 192);
			cmbType.Margin = new Padding(3, 2, 3, 2);
			cmbType.Name = "cmbType";
			cmbType.Size = new Size(143, 35);
			cmbType.TabIndex = 6;
			// 
			// txtName
			// 
			txtName.Font = new Font("Constantia", 16.2F);
			txtName.Location = new Point(237, 160);
			txtName.Margin = new Padding(3, 2, 3, 2);
			txtName.Name = "txtName";
			txtName.Size = new Size(143, 34);
			txtName.TabIndex = 7;
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(txtName);
			panel1.Controls.Add(lblTitle);
			panel1.Controls.Add(cmbType);
			panel1.Controls.Add(rtxtDescription);
			panel1.Controls.Add(txtCUI);
			panel1.Controls.Add(lblDescription);
			panel1.Controls.Add(lblType);
			panel1.Controls.Add(lblName);
			panel1.Controls.Add(lblCUI);
			panel1.Controls.Add(btnCreeazaContV);
			panel1.Location = new Point(289, 59);
			panel1.Margin = new Padding(3, 2, 3, 2);
			panel1.Name = "panel1";
			panel1.Size = new Size(448, 413);
			panel1.TabIndex = 13;
			// 
			// lblTitle
			// 
			lblTitle.Font = new Font("Constantia", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblTitle.Location = new Point(-1, 56);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(448, 42);
			lblTitle.TabIndex = 11;
			lblTitle.Text = "Creeaza un cont";
			lblTitle.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnCreeazaContV
			// 
			btnCreeazaContV.AutoSize = true;
			btnCreeazaContV.BackColor = Color.FromArgb(171, 215, 206);
			btnCreeazaContV.FlatAppearance.BorderColor = Color.FromArgb(241, 201, 212);
			btnCreeazaContV.FlatAppearance.BorderSize = 5;
			btnCreeazaContV.FlatStyle = FlatStyle.Flat;
			btnCreeazaContV.Font = new Font("Constantia", 16.2F);
			btnCreeazaContV.Location = new Point(137, 305);
			btnCreeazaContV.Margin = new Padding(3, 2, 3, 2);
			btnCreeazaContV.Name = "btnCreeazaContV";
			btnCreeazaContV.Size = new Size(164, 47);
			btnCreeazaContV.TabIndex = 9;
			btnCreeazaContV.Text = "Creeaza cont";
			btnCreeazaContV.UseVisualStyleBackColor = false;
			btnCreeazaContV.Click += btnCreeazaContV_Click;
			// 
			// btnArrow
			// 
			btnArrow.BackColor = Color.FromArgb(118, 203, 200);
			btnArrow.BackgroundImageLayout = ImageLayout.Stretch;
			btnArrow.FlatAppearance.BorderSize = 0;
			btnArrow.FlatStyle = FlatStyle.Flat;
			btnArrow.Location = new Point(10, 9);
			btnArrow.Margin = new Padding(3, 2, 3, 2);
			btnArrow.Name = "btnArrow";
			btnArrow.Size = new Size(55, 40);
			btnArrow.TabIndex = 14;
			btnArrow.UseVisualStyleBackColor = false;
			btnArrow.Click += button1_Click;
			// 
			// frmSignUpOrganizator
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(1032, 530);
			Controls.Add(btnArrow);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmSignUpOrganizator";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "SignUpOrganizator";
			Load += frmSignUpOrganizator_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label lblCUI;
        private Label lblName;
        private Label lblType;
        private Label lblDescription;
        private TextBox txtCUI;
        private RichTextBox rtxtDescription;
        private ComboBox cmbType;
        private TextBox txtName;
        private Panel panel1;
        private Label lblTitle;
        private Button btnCreeazaContV;
        private Button btnArrow;
    }
}