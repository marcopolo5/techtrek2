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
<<<<<<< HEAD
			Application.Run(new frmUserDashboard());
=======
			Application.Run(new frmLogare());
>>>>>>> andrei
		}
	}
}