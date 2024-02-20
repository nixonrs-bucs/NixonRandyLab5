using System;
using SWPERSON;
using APIREQUEST;
using System.Net.Http.Json;
using Newtonsoft.Json;
namespace SWAPIDRIVER
{
	public class SWAPIDRIVER
	{
		public static async Task Main()
		{
			bool APIBOOL = true;
			SWAPIPerson person = new();
			SWAPIREQUEST API = new();
			//person.ID = 1;
			while(APIBOOL)
			{
				Console.WriteLine($"---------------------------------------------------------------------------------------------\n");
				Console.WriteLine($"  ********      ************     **     ***    ***    *** " +
							    $"\n ***********    ************    ****     ***   ***   ***  " +
						        $"\n ******              ***       **  **     ***  ***  ***   " +
						        $"\n     ******          ***      ********     *** *** ***    " +
						        $"\n ********            ***     **      **     ** *** **     " +
						        $"\n  ******             ***    **        **     * *** *    \n");

				Console.WriteLine($" ***    ***    ***    **      **********     ********     " +
								$"\n  ***   ***   ***    ****     **       **   ***********   " +
								$"\n   ***  ***  ***    **  **    **       **   ******        " +
								$"\n    *** *** ***    ********   ************      ******    " +
								$"\n     ** *** **    **      **  **       ***  ********      " +
								$"\n      * *** *    **        ** **       ***   ******     \n");
				Console.WriteLine($"---------------------------------------------------------------------------------------------");
				Console.WriteLine($"\tGreetings bounty hunter, which hero/villan\n\twould you like to collect a bounty on?");
				Console.WriteLine($"\t1. Luke Skywalker, $100,000,000");
				Console.WriteLine($"\t2. C-3PO, $100,000");
				Console.WriteLine($"\t3. R2-D2, $100,000");
				Console.WriteLine($"\t4. Darth Vader, $100,000,000,000");
				Console.WriteLine($"\t5. Leia Organa, $100,000,000");
				Console.WriteLine($"\t6. Owen Lars, $100,000");
				Console.WriteLine($"\t7. Beru Whitesun Lars, $100,000");
				Console.WriteLine($"\t8. R5-D4, $100,000");
				Console.WriteLine($"\t9. Biggs Darklighter, $100,000,000");
				Console.WriteLine($"\t10. Obi-Wan Kenobi Ben $100,000,000,000");
				Console.WriteLine($"---------------------------------------------------------------------------------------------");
				person.ID = int.Parse(Console.ReadLine());
				if(person.ID == 1)
				{
					using (var httpClient = new HttpClient())
					{
						try
						{
							HttpResponseMessage Message = await httpClient.GetAsync($"{API.SWAPI}{person.ID}/");
							if (Message.IsSuccessStatusCode)
							{
								string responseContent = await Message.Content.ReadAsStringAsync();
								SWAPIPerson n = JsonConvert.DeserializeObject<SWAPIPerson>(responseContent);
								Console.WriteLine(n);
							}
							else
							{
								Console.WriteLine($"Connection failed {Message.StatusCode}");
							}
						}
						catch (Exception ex)
						{
							Console.WriteLine(ex.ToString());
						}

					}
				}
				else if(person.ID == 2)
				{
					using (var httpClient = new HttpClient())
					{
						try
						{
							HttpResponseMessage Message = await httpClient.GetAsync($"{API.SWAPI}{person.ID}/");
							if (Message.IsSuccessStatusCode)
							{
								string responseContent = await Message.Content.ReadAsStringAsync();
								SWAPIPerson n = JsonConvert.DeserializeObject<SWAPIPerson>(responseContent);
								Console.WriteLine(n);
							}
							else
							{
								Console.WriteLine($"Connection failed {Message.StatusCode}");
							}
						}
						catch (Exception ex)
						{
							Console.WriteLine(ex.ToString());
						}

					}
				}
				else if(person.ID == 3)
				{
					using (var httpClient = new HttpClient())
					{
						try
						{
							HttpResponseMessage Message = await httpClient.GetAsync($"{API.SWAPI}{person.ID}/");
							if (Message.IsSuccessStatusCode)
							{
								string responseContent = await Message.Content.ReadAsStringAsync();
								SWAPIPerson n = JsonConvert.DeserializeObject<SWAPIPerson>(responseContent);
								Console.WriteLine(n);
							}
							else
							{
								Console.WriteLine($"Connection failed {Message.StatusCode}");
							}
						}
						catch (Exception ex)
						{
							Console.WriteLine(ex.ToString());
						}

					}
				}
			}
		}
	}
}

