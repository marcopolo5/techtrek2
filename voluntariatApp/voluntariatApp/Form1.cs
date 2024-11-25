
using IronXL;

namespace voluntariatApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			this.loadDb();

		}

		private void loadDb()
		{
			WorkBook wb = WorkBook.Load(@"Q:\info\ProiectTechTrek\voluntariatApp\voluntariatApp\Baza de date.xlsx");
			var sheet1 = wb.GetWorkSheet("Logins");

			this.showDataLabel.Text = sheet1.Rows[1].Columns[0].ToString();

		}
	}
}
