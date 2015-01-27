using System;
using Newtonsoft.Json;

namespace TestNuGetAndShippable
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			Console.WriteLine ("Test: {0}", JsonConvert.SerializeObject(new {test = 3}));
		}
	}
}
