using voluntariatApp.repo;
using voluntariatApp.test;

namespace voluntariatApp
{
	internal static class Program
	{
		static void Main()
		{
			Tests.TestAll();
			ApplicationConfiguration.Initialize();
			//Application.Run(new frmUserDashboard());
			Application.Run(new frmLogare());
		}
	}
}