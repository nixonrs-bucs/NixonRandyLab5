// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using SWPERSON;
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
		/// <summary>
		/// SWAPI is the url to get or obtain such object while the ID is which charater/person to get
		/// </summary>
		[JsonProperty]
		private string SWAPI = "https://swapi.dev/api/people/";
		/// <summary>
		/// This is async method that needs alittle more time to get info compared to the rest.
		/// </summary>
		/// <param name="ID"></param>
		/// <returns></returns>
		public async Task APICall(int ID)
		{
			///<summary>
			///httpClient sends out a request to such resource and receives a HTTP response. 
			///</summary>
			using (var httpClient = new HttpClient())
			{
				
				try
				{
	
					///<summary>
					///<see cref="Message" gets the response message from <see cref="httpClient"/>/>
					///</summary>
					HttpResponseMessage Message = await httpClient.GetAsync($"{SWAPI}{ID}/");
					if (Message.IsSuccessStatusCode)
					{
						string responseContent = await Message.Content.ReadAsStringAsync();
						SWAPIPerson person = JsonConvert.DeserializeObject<SWAPIPerson>(responseContent);
						Console.WriteLine(person);
					}
					else
					{
						Console.WriteLine($"Connection failed {Message.StatusCode}");
					
					}
				}
				catch (HttpRequestException ex)
				{
					Console.WriteLine($"HTTP request failed: {ex.Message}");
				}
				catch (JsonException ex)
				{
					Console.WriteLine($"JSON deserialization failed: {ex.Message}");
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
		}
		public override string ToString()
		{
			return this.SWAPI;
		}
	}
}
