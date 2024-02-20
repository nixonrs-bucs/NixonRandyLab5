// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace APIREQUEST
{
	internal class SWAPIREQUEST
	{
		[JsonProperty]
		internal string SWAPI = "https://swapi.dev/api/people/";
		
		public override string ToString()
		{
			return this.SWAPI;
		}
	}
}
