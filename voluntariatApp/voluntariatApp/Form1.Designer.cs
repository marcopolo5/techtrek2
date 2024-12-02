namespace voluntariatApp
{
	partial class Form1
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
		private void InitializeComponent(string print)
		{
			showDataLabel = new Label();
			SuspendLayout();
			// 
			// showDataLabel
			// 
			showDataLabel.AutoSize = true;
			showDataLabel.Location = new Point(224, 183);
			showDataLabel.Name = "showDataLabel";
			showDataLabel.Size = new Size(38, 15);
			showDataLabel.TabIndex = 0;
			showDataLabel.Text = print;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(showDataLabel);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label showDataLabel;
	}
}
