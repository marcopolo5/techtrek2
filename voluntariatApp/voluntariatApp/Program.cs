using voluntariatApp.repo;
using voluntariatApp.test;

namespace voluntariatApp
{
	internal static class Program
	{
		static void Main()
		{
			Tests.TestAll();
			var print = Tests.TestRepositoryUser();
			ApplicationConfiguration.Initialize();
			Application.Run(new Form1(print));
		}
	}
}