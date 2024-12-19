using System;
using System.Configuration;
using System.Windows.Forms;
using voluntariatApp.controller;
using voluntariatApp.domain;
using voluntariatApp.domain.enums;
using voluntariatApp.service;

namespace voluntariatApp
{
	public partial class frmCompanySearch : Form
	{
		public frmCompanySearch()
		{
			InitializeComponent();

		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			frmUserDashboard userDashboard = new frmUserDashboard();
			this.Close();
			userDashboard.Show();
		}

		private void btnEvents_Click(object sender, EventArgs e)
		{
			frmEvents events = new frmEvents();
			this.Hide();
			events.Show();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			panelCompanyDetails.Visible = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			panelCompanyDetails.Visible = true;
		}

		private void frmCompanySearch_Load(object sender, EventArgs e)
		{
			panelCompanyDetails.Visible = false;

			// Populate the ComboBox with OrganiserType enum values
			cboActivityType.Items.Clear();
			foreach (OrganiserType type in Enum.GetValues(typeof(OrganiserType)))
			{
				cboActivityType.Items.Add(type.ToString());
			}
			LoadCompanies();
		}



		Controller controller = Controller.getInstance();
		private void FilterCompanies(string companyName, OrganiserType? activityType)
		{
			// Clear the current UI list
			mainPanel.Controls.Clear();

			// Fetch all companies from the service
			var companies = controller.GetAllCompanies();

			// Filter companies based on input fields (company name and activity type)
			var filteredCompanies = companies.Where(c =>
				(string.IsNullOrEmpty(companyName) || c.Name.Contains(companyName, StringComparison.OrdinalIgnoreCase)) &&
				// Compare the activity type with c.Field if activityType is not null
				(!activityType.HasValue || string.Equals(c.Field.ToString(), activityType.Value.ToString(), StringComparison.OrdinalIgnoreCase)
)
			).ToList();

			// Loop through the filtered companies and create UI elements
			foreach (var company in filteredCompanies)
			{
				// Create a container for each company
				Panel companyPanel = new Panel
				{
					Size = new Size(306, 125),
					BorderStyle = BorderStyle.FixedSingle
				};

				// Add company name
				Label nameLabel = new Label
				{
					Text = $"{company.Name}",
					Location = new Point(3, 7),
					AutoSize = true,
					Font = new Font("Cooper Black", 10.2f)
				};

				companyPanel.Controls.Add(nameLabel);

				// Add location (or other details)
				Label typeLabel = new Label
				{
					Text = $"Tip Activitate: {company.Field}",
					Location = new Point(3, 37),
					AutoSize = true,
					Font = new Font("Constantia", 10.2f)
				};

				companyPanel.Controls.Add(typeLabel);

				// Add details button
				Button detailsButton = new Button
				{
					Text = "Detalii",
					Location = new Point(219, 83),
					BackColor = Color.FromArgb(171, 215, 206)
				};
				detailsButton.Click += (s, e) => ShowDetails(company);
				companyPanel.Controls.Add(detailsButton);

				// Add the panel to the main container
				mainPanel.Controls.Add(companyPanel);
			}
		}

		private void ShowDetails(Organiser company)
		{
			// Make the panel visible
			panelCompanyDetails.Visible = true;

			// Update the labels in the panel with the company's details
			lblCompany.Text = $"Nume companie: {company.Name}";
			lblCUI.Text = $"CUI: {company.Cui}";
			lblField.Text = $"Tip Activitate: {company.Field}";
			lblDescription.Text = $"Descriere: {company.Description}";
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			frmCompanySearch search = new frmCompanySearch();
			search.Show();
			this.Close();
		}

		private void btnRegistration_Click(object sender, EventArgs e)
		{
			frmRegistration registration = new frmRegistration();
			registration.Show();
			this.Close();
		}

		private void btnTasks_Click(object sender, EventArgs e)
		{
			frmTasks tasks = new frmTasks();
			tasks.Show();
			this.Close();
		}

		private void btnCertificates_Click(object sender, EventArgs e)
		{
			frmCertificates certificates = new frmCertificates();
			certificates.Show();
			this.Close();
		}

		private void panel5_Paint(object sender, PaintEventArgs e)
		{
		}

		private void lblDescription_Click(object sender, EventArgs e)
		{

		}

		private ComboBox GetCboActivityType() => cboActivityType;

		private void btnCompanySearch_Click(object sender, EventArgs e)
		{
			string companyName = txtCompanyName.Text;
			string selectedActivity = cboActivityType.SelectedItem?.ToString();  // Get selected activity as string

			// Convert selected string to OrganiserType if not null
			OrganiserType? activityType = string.IsNullOrEmpty(selectedActivity) ? (OrganiserType?)null : (OrganiserType)Enum.Parse(typeof(OrganiserType), selectedActivity);

			// Filter companies with the name and activity type
			FilterCompanies(companyName, activityType);
		}


		private void LoadCompanies()
		{

			// Fetch all companies from the service
			var companies = controller.GetAllCompanies();

			foreach (var company in companies)
			{

				Panel companyPanel = new Panel
				{
					Size = new Size(306, 125),
					BorderStyle = BorderStyle.FixedSingle
				};

				// Add company name
				Label nameLabel = new Label
				{
					Text = $"{company.Name}",
					Location = new Point(3, 7),
					AutoSize = true,
					Font = new Font("Cooper Black", 10.2f)
				};

				companyPanel.Controls.Add(nameLabel);

				// Add location (or other details)
				Label typeLabel = new Label
				{
					Text = $"Tip Activitate: {company.Field}",
					Location = new Point(3, 37),
					AutoSize = true,
					Font = new Font("Constantia", 10.2f)
				};

				companyPanel.Controls.Add(typeLabel);

				// Add details button
				Button detailsButton = new Button
				{
					Text = "Detalii",
					Location = new Point(219, 83),
					BackColor = Color.FromArgb(171, 215, 206)
				};
				detailsButton.Click += (s, e) => ShowDetails(company);
				companyPanel.Controls.Add(detailsButton);

				// Add the panel to the main container (e.g., a FlowLayoutPanel)
				mainPanel.Controls.Add(companyPanel); // `mainPanel` is a container in your form
			}
		}

	}
}
