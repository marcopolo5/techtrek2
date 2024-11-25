using IronXL;

namespace voluntariatApp
{
	internal static class Program
	{
		static void Main()
		{


			ApplicationConfiguration.Initialize();
			Application.Run(new Form1());
		}
	}
}