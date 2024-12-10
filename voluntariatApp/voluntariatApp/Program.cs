using voluntariatApp.repo;
using voluntariatApp.test;

namespace voluntariatApp
{
	internal static class Program
	{
		static void Main()
		{
			var print = Tests.TestAll();
			ApplicationConfiguration.Initialize();
			Application.Run(new frmUserDashboard());
		}
	}
}