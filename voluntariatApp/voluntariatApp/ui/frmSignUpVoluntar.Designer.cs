namespace voluntariatApp
{
    partial class frmSignUpVoluntar
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
            txtName = new TextBox();
            lblTitle = new Label();
            cmbOccupation = new ComboBox();
            txtCNP = new TextBox();
            lblOccupation = new Label();
            lblName = new Label();
            lblCNP = new Label();
            btnCreeazaContV = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(118, 203, 200);
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(cmbOccupation);
            panel1.Controls.Add(txtCNP);
            panel1.Controls.Add(lblOccupation);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblCNP);
            panel1.Controls.Add(btnCreeazaContV);
            panel1.Location = new Point(334, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 550);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // txtName
            // 
            txtName.Location = new Point(271, 229);
            txtName.Name = "txtName";
            txtName.Size = new Size(163, 27);
            txtName.TabIndex = 7;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Constantia", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(81, 74);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(295, 49);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Creeaza un cont";
            // 
            // cmbOccupation
            // 
            cmbOccupation.FormattingEnabled = true;
            cmbOccupation.Location = new Point(271, 273);
            cmbOccupation.Name = "cmbOccupation";
            cmbOccupation.Size = new Size(163, 28);
            cmbOccupation.TabIndex = 6;
            // 
            // txtCNP
            // 
            txtCNP.Location = new Point(271, 186);
            txtCNP.Name = "txtCNP";
            txtCNP.Size = new Size(163, 27);
            txtCNP.TabIndex = 4;
            // 
            // lblOccupation
            // 
            lblOccupation.AutoSize = true;
            lblOccupation.Font = new Font("Constantia", 16.2F);
            lblOccupation.Location = new Point(70, 262);
            lblOccupation.Name = "lblOccupation";
            lblOccupation.Size = new Size(127, 35);
            lblOccupation.TabIndex = 2;
            lblOccupation.Text = "Ocupatie";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Constantia", 16.2F);
            lblName.Location = new Point(70, 218);
            lblName.Name = "lblName";
            lblName.Size = new Size(89, 35);
            lblName.TabIndex = 1;
            lblName.Text = "Nume";
            // 
            // lblCNP
            // 
            lblCNP.AutoSize = true;
            lblCNP.Font = new Font("Constantia", 16.2F);
            lblCNP.Location = new Point(70, 174);
            lblCNP.Name = "lblCNP";
            lblCNP.Size = new Size(70, 35);
            lblCNP.TabIndex = 0;
            lblCNP.Text = "CNP";
            // 
            // btnCreeazaContV
            // 
            btnCreeazaContV.AutoSize = true;
            btnCreeazaContV.BackColor = Color.FromArgb(171, 215, 206);
            btnCreeazaContV.FlatAppearance.BorderColor = Color.FromArgb(241, 201, 212);
            btnCreeazaContV.FlatAppearance.BorderSize = 5;
            btnCreeazaContV.FlatStyle = FlatStyle.Flat;
            btnCreeazaContV.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreeazaContV.Location = new Point(169, 416);
            btnCreeazaContV.Name = "btnCreeazaContV";
            btnCreeazaContV.Size = new Size(174, 61);
            btnCreeazaContV.TabIndex = 9;
            btnCreeazaContV.Text = "Creeaza cont";
            btnCreeazaContV.UseVisualStyleBackColor = false;
            btnCreeazaContV.Click += btnCreeazaContV_Click;
            // 
            // SignUpVoluntar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1180, 707);
            Controls.Add(panel1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SignUpVoluntar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpVoluntar";
            Load += SignUpVoluntar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private TextBox txtName;
        private Label lblTitle;
        private ComboBox cmbOccupation;
        private TextBox txtCNP;
        private Label lblOccupation;
        private Label lblName;
        private Label lblCNP;
        private Button btnCreeazaContV;
    }
}