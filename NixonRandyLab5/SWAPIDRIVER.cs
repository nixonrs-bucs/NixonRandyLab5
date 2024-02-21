using System;
using SWPERSON;
using APIREQUEST;
using System.Net.Http.Json;
using Newtonsoft.Json;
using System.Linq.Expressions;
namespace SWAPIDRIVER
{
	public class SWAPIDRIVER
	{
		public static async Task Main()
		{
			bool APIBOOL = true;
			SWAPIPerson person = new();
			SWAPIREQUEST API = new();
			try
			{
				while (APIBOOL)
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
					Console.WriteLine($"\t0. Clear Screen");
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
					Console.WriteLine($"\t11 Exit");
					Console.WriteLine($"---------------------------------------------------------------------------------------------");
					person.ID = int.Parse(Console.ReadLine());
					if (person.ID == 0)
					{
						Console.Clear();
					}
					else if (person.ID == 1)
					{
						await API.APICall(person.ID);
					}
					else if (person.ID == 2)
					{
						await API.APICall(person.ID);
					}
					else if (person.ID == 3)
					{
						await API.APICall(person.ID);
					}
					else if (person.ID == 3)
					{
						await API.APICall(person.ID);
					}
					else if (person.ID == 4)
					{
						await API.APICall(person.ID);
					}
					else if (person.ID == 5)
					{
						await API.APICall(person.ID);
					}
					else if (person.ID == 6)
					{
						await API.APICall(person.ID);
					}
					else if (person.ID == 7)
					{
						await API.APICall(person.ID);
					}
					else if (person.ID == 8)
					{
						await API.APICall(person.ID);
					}
					else if (person.ID == 9)
					{
						await API.APICall(person.ID);
					}
					else if (person.ID == 10)
					{
						await API.APICall(person.ID);
					}
					else if (person.ID == 11)
					{
						Console.WriteLine($"\tThankyou bounty hunter and good luck hunting$$$");
						Console.WriteLine($"---------------------------------------------------------------------------------------------");
						APIBOOL = false;
					}
					else
					{
						Console.WriteLine($"Number is out of range. Number: {person.ID} when there is only 10 OPTIONS!");
						Console.Beep(500, person.ID);
					}
				}

			}
			catch (Exception ex)
			{
				//Have to practice using exception when things don't go to plan.
				Console.WriteLine(ex.Message);
			}
		}
	}
}

