// See https://aka.ms/new-console-template for more information
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace APIREQUEST
{
	public class SWAPIREQUEST
	{
		const string SWAPI = @"https://swapi.dev/api/people/";
		public override string ToString()
		{
			return SWAPI;
		}
	}
}
