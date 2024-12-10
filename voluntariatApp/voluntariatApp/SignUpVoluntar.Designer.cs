namespace voluntariatApp
{
    partial class SignUpOrganizator
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
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCUI
            // 
            lblCUI.AutoSize = true;
            lblCUI.Font = new Font("Comic Sans MS", 16.2F);
            lblCUI.Location = new Point(70, 174);
            lblCUI.Name = "lblCUI";
            lblCUI.Size = new Size(70, 39);
            lblCUI.TabIndex = 0;
            lblCUI.Text = "CUI";
            lblCUI.Click += lblCUI_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Comic Sans MS", 16.2F);
            lblName.Location = new Point(70, 218);
            lblName.Name = "lblName";
            lblName.Size = new Size(91, 39);
            lblName.TabIndex = 1;
            lblName.Text = "Nume";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Comic Sans MS", 16.2F);
            lblType.Location = new Point(70, 262);
            lblType.Name = "lblType";
            lblType.Size = new Size(58, 39);
            lblType.TabIndex = 2;
            lblType.Text = "Tip";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Comic Sans MS", 16.2F);
            lblDescription.Location = new Point(70, 309);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(145, 39);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Descriere";
            // 
            // txtCUI
            // 
            txtCUI.Location = new Point(271, 186);
            txtCUI.Name = "txtCUI";
            txtCUI.Size = new Size(163, 27);
            txtCUI.TabIndex = 4;
            // 
            // rtxtDescription
            // 
            rtxtDescription.BorderStyle = BorderStyle.FixedSingle;
            rtxtDescription.Location = new Point(271, 320);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(163, 62);
            rtxtDescription.TabIndex = 5;
            rtxtDescription.Text = "";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(271, 273);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(163, 28);
            cmbType.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(271, 229);
            txtName.Name = "txtName";
            txtName.Size = new Size(163, 27);
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
            panel1.Location = new Point(330, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 550);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(81, 74);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(321, 56);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Creeaza un cont";
            // 
            // btnCreeazaContV
            // 
            btnCreeazaContV.AutoSize = true;
            btnCreeazaContV.BackColor = Color.FromArgb(171, 215, 206);
            btnCreeazaContV.FlatAppearance.BorderColor = Color.FromArgb(241, 201, 212);
            btnCreeazaContV.FlatAppearance.BorderSize = 5;
            btnCreeazaContV.FlatStyle = FlatStyle.Flat;
            btnCreeazaContV.Font = new Font("Comic Sans MS", 13.8F);
            btnCreeazaContV.Location = new Point(169, 416);
            btnCreeazaContV.Name = "btnCreeazaContV";
            btnCreeazaContV.Size = new Size(174, 61);
            btnCreeazaContV.TabIndex = 9;
            btnCreeazaContV.Text = "Creeaza cont";
            btnCreeazaContV.UseVisualStyleBackColor = false;
            btnCreeazaContV.Click += btnCreeazaContV_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(118, 203, 200);
            button1.BackgroundImage = Properties.Resources.BackArrow;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(63, 54);
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SignUpOrganizator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundSignUp;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1180, 707);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SignUpOrganizator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpOrganizator";
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
        private Button button1;
    }
}