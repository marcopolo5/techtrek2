using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using voluntariatApp.domain;
using voluntariatApp.service;
using voluntariatApp.controller;
using Microsoft.Extensions.Logging;

namespace voluntariatApp
{
	public partial class frmUserDashboard : Form
	{
		// Declare labels for event details
		private Label lblEvent;
		private Label lblData;
		private Label lblLocatie;
		private Label lblDispNo;
		private Label lblDescription;

		public frmUserDashboard()
		{
			InitializeComponent();
		}
		private long eventID; // Variabilă pentru stocarea ID-ului evenimentului selectat

		private void btnSearch_Click(object sender, EventArgs e)
		{
			frmCompanySearch companySearch = new frmCompanySearch();
			this.Hide();
			companySearch.Show();
		}

		private void btnEvents_Click(object sender, EventArgs e)
		{
			frmEvents events = new frmEvents();
			this.Hide();
			events.Show();
		}
		Controller controller = Controller.getInstance();
		private void btnDetalii1_Click(object sender, EventArgs e)
		{
			panelEventDetails.Visible = true;


			var lista = controller.topEvens();

			string result = string.Join(", ", lista);
			MessageBox.Show(result);
		}

		private void frmUserDashboard_Load(object sender, EventArgs e)
		{
			panelEventDetails.Visible = false;
			panelEventRegistration.Visible = false;

			try
			{
				var popularEvents = controller.topEvens();

				// Populate events into FlowLayoutPanel
				LoadEventsIntoFlowLayout(popularEvents);

				// Initialize the event details panel
				InitializeEventDetailsPanel();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Failed to load events: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadEventsIntoFlowLayout(List<Event> events)
		{
			flowLayoutPanel1.Controls.Clear();
			int index = 1; // Initialize index to select the correct image

			foreach (var ev in events)
			{
				Panel eventCard = CreateEventCard(ev, index);
				flowLayoutPanel1.Controls.Add(eventCard);
				index++; // Increment index for each event
			}
		}

		private Panel CreateEventCard(Event ev, int index)
		{
			// Create a container panel for the event card
			Panel eventCard = new Panel
			{
				BorderStyle = BorderStyle.FixedSingle,
				Size = new Size(500, 150),
				Margin = new Padding(10),
				Tag = ev.getId()
			};

			// PictureBox for event image
			PictureBox picture = new PictureBox
			{
				BorderStyle = BorderStyle.FixedSingle,
				Size = new Size(120, 120),
				Location = new Point(10, 10),
				SizeMode = PictureBoxSizeMode.StretchImage // Adjust image size to fit
			};

			// Assign an image based on the index (you can adjust this logic)
			// picture.Image = Image.FromFile($"event_image_{index}.jpg");

			eventCard.Controls.Add(picture);

			// Etichete pentru detalii
			Label lblEventName = CreateLabel($"{ev.Name}", 10, FontStyle.Regular, new Point(140, 10));
			Label lblDate = CreateLabel($"{ev.Period.StartDate:dd/MM/yyyy} - {ev.Period.EndDate:dd/MM/yyyy}", 10, FontStyle.Regular, new Point(140, 35));
			Label lblAvailableSeats = CreateLabel($"{ev.NumberOfParticipants}", 10, FontStyle.Regular, new Point(380, 10));
			Label lblLocation = CreateLabel($"{ev.Location}", 10, FontStyle.Regular, new Point(370, 35));

			// Add labels to event card
			eventCard.Controls.Add(lblEventName);
			eventCard.Controls.Add(lblDate);
			eventCard.Controls.Add(lblAvailableSeats);
			eventCard.Controls.Add(lblLocation);

			// Button for viewing event details
			Button btnDetails = new Button
			{
				Text = "Details",
				Size = new Size(70, 25),
				Location = new Point(400, 100),
				BackColor = Color.LightSeaGreen,
				ForeColor = Color.White
			};

			btnDetails.Click += (s, e) =>
			{
				panelEventDetails.Visible = true;

				// Display event details in the right panel
				lblEvent.Text = ev.Name;
				lblData.Text = $"{ev.Period.StartDate:dd/MM/yyyy} - {ev.Period.EndDate:dd/MM/yyyy}";
				lblLocatie.Text = ev.Location.ToString();
				lblDispNo.Text = $"{ev.NumberOfParticipants} available seats";
				lblDescription.Text = ev.EventDescription ?? "No description available.";
				eventID = ev.getId();
			};

			eventCard.Controls.Add(btnDetails);

			return eventCard;
		}

		// Initialize the event details panel with labels
		private void InitializeEventDetailsPanel()
		{
			// Calculate the center of the panel
			int panelWidth = panelEventDetails.Width;

			// Label width (approximated, you can adjust if needed)
			int labelWidth = 300;

			// Horizontal center of the panel
			int centerX = (panelWidth - labelWidth) / 2;

			// Create and position labels
			lblEvent = new Label
			{
				Location = new Point(centerX, 50),
				Font = new Font("Constantia", 12),
				Width = labelWidth,
				TextAlign = ContentAlignment.MiddleCenter // Center the text horizontally
			};

			lblData = new Label
			{
				Location = new Point(centerX, 80),
				Font = new Font("Constantia", 10),
				Width = labelWidth,
				TextAlign = ContentAlignment.MiddleCenter
			};

			lblLocatie = new Label
			{
				Location = new Point(centerX, 110),
				Font = new Font("Constantia", 10),
				Width = labelWidth,
				TextAlign = ContentAlignment.MiddleCenter
			};

			lblDispNo = new Label
			{
				Location = new Point(centerX, 140),
				Font = new Font("Constantia", 10),
				Width = labelWidth,
				TextAlign = ContentAlignment.MiddleCenter
			};

			lblDescription = new Label
			{
				Location = new Point(centerX, 170),
				Font = new Font("Constantia", 10),
				Width = labelWidth,
				TextAlign = ContentAlignment.MiddleCenter
			};

			// Add labels to the panel
			panelEventDetails.Controls.Add(lblEvent);
			panelEventDetails.Controls.Add(lblData);
			panelEventDetails.Controls.Add(lblLocatie);
			panelEventDetails.Controls.Add(lblDispNo);
			panelEventDetails.Controls.Add(lblDescription);
		}


		// Create a label control with specific properties
		private Label CreateLabel(string text, int fontSize, FontStyle fontStyle, Point location)
		{
			return new Label
			{
				Text = text,
				Font = new Font("Constantia", fontSize, fontStyle),
				AutoSize = true,
				Location = location
			};
		}

		private void btnCloseDetails_Click(object sender, EventArgs e)
		{
			panelEventDetails.Visible = false;
		}

		private void btnInscriere_Click(object sender, EventArgs e)
		{
			panelEventRegistration.Visible = true;
		}

		private void btnQuit_Click(object sender, EventArgs e)
		{
			panelEventRegistration.Visible = false;
		}

		private void btnEventRegistration_Click(object sender, EventArgs e)
		{
			try
			{
				controller.eventRegistration(eventID, txtReason.Text);
				MessageBox.Show("Te-ai înscris cu succes!");
				panelEventRegistration.Visible = false;
			}
			catch
			{
				MessageBox.Show("Sunteti deja inscris la acest eventiment!");
			}
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			frmUserDashboard dashboard = new frmUserDashboard();
			dashboard.Show();
			this.Hide();
		}

		private void btnRegistration_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtReason.Text))
			{
				MessageBox.Show("Vă rugăm să introduceți un motiv pentru înregistrare.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				controller.eventRegistration(eventID, txtReason.Text);
				MessageBox.Show("Înregistrarea a fost efectuată cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
				panelEventRegistration.Visible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"A apărut o eroare la înregistrare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void btnTasks_Click(object sender, EventArgs e)
		{
			frmTasks tasks = new frmTasks();
			tasks.Show();
			this.Hide();
		}

		private void btnCertificates_Click(object sender, EventArgs e)
		{
			frmCertificates certificates = new frmCertificates();
			certificates.Show();
			this.Hide();
		}

		private void panelEventRegistration_Paint(object sender, PaintEventArgs e)
		{
			// You can customize painting here if needed
		}



	}
}
