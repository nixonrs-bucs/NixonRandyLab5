using System;
using SWPERSON;
using APIREQUEST;
namespace SWAPIDRIVER
{
	public class SWAPIDRIVER
	{
		public static void Main()
		{
			SWAPIPerson person = new();
			SWAPIREQUEST API = new();
			Console.WriteLine(API);

		}
	}
}

