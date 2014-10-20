using System;
using voyagerlib;
using System.Reflection;

namespace boopserver
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// create server
			Server server = new Server (Assembly.GetExecutingAssembly(), 1337);

			// start
			server.Start ();
		}
	}
}
