using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using APIREQUEST;
using Newtonsoft.Json;
namespace SWPERSON
{
	public class SWAPIPerson : SWAPIREQUEST
	{
		/// <summary>
		/// ID is the option int var to tell the request which person to get 
		/// </summary>
		public int ID { get; set; }
		/// <summary>
		/// Simply a javascript object notation to apply that this is a property of such json
		/// </summary>
		[JsonProperty]
		public string name { get; set; }
		/// <summary>
		/// Simply a javascript object notation to apply that this is a property of such json
		/// </summary>
		[JsonProperty]
		public string birth_year { get; set; }
		/// <summary>
		/// Simply a javascript object notation to apply that this is a property of such json
		/// </summary>
		[JsonProperty]
		public string eye_color { get; set; }
		/// <summary>
		/// Simply a javascript object notation to apply that this is a property of such json
		/// </summary>
		[JsonProperty]
		public string gender { get; set; }
		/// <summary>
		/// Simply a javascript object notation to apply that this is a property of such json
		/// </summary>
		[JsonProperty]
		public string hair_color { get; set; }
		/// <summary>
		/// Simply a javascript object notation to apply that this is a property of such json
		/// </summary>
		[JsonProperty]
		public string height { get; set; }
		/// <summary>
		/// Simply a javascript object notation to apply that this is a property of such json
		/// </summary>
		[JsonProperty]
		public string mass { get; set; }
		/// <summary>
		/// Simply a javascript object notation to apply that this is a property of such json
		/// </summary>
		[JsonProperty]
		public string skin_color { get; set; }
		/// <summary>
		/// Simply a javascript object notation to apply that this is a property of such json
		/// </summary>
		[JsonProperty]
		public string homeworld { get; set; }
		/// <summary>
		/// Simply a javascript object notation to apply that this is a property of such json
		/// </summary>
		[JsonProperty]
		public List<string> films { get; set; }
		/// <summary>
		/// Simply a javascript object notation to apply that this is a property of such json
		/// </summary>
		[JsonProperty]
		public List<string> species { get; set; }
		/// <summary>
		/// Simply a javascript object notation to apply that this is a property of such json
		/// </summary>
		[JsonProperty]
		public List<string> starships { get; set; }
		/// <summary>
		/// Simply a javascript object notation to apply that this is a property of such json
		/// </summary>
		[JsonProperty]
		public List<string> vehicles { get; set; }
		/// <summary>
		/// Simply a javascript object notation to apply that this is a property of such json
		/// </summary>
		[JsonProperty]
		public string URL { get; set; }
		/// <summary>
		/// Simply a javascript object notation to apply that this is a property of such json
		/// </summary>
		[JsonProperty]
		public string created { get; set; }
		/// <summary>
		/// Simply a javascript object notation to apply that this is a property of such json
		/// </summary>
		[JsonProperty]
		public string edited { get; set; }
		/// <summary>
		/// I've implmented this method because I was tired of don't repeat yourself. So, I got lazy!
		/// </summary>
		/// <param name="URL"></param>
		/// <returns>A string of the url of where to get such resource or simply returns that the being didn't have it or belong to it.</returns>
		public string ReturnAnnoying_Fields(List<string> URL)
		{
			foreach (var Message in URL)
			{
				return Message;
			}
			return "Warning if they're is no result.\n\tThen the character sadly does not have or belong to such item.";
		}
		public override string ToString()
		{
			StringBuilder @string = new StringBuilder();
			
			string _MSG = "";
			_MSG += $"\tName: {name}\tBirth Year: {birth_year}\tEye Color: {eye_color}\n";
			_MSG += $"\tGender: {gender}\tHair Color: {hair_color}\tHeight: {height}\n";
			_MSG += $"\tMass: {mass}\tSkin Color: {skin_color}\tHomeworld: {homeworld}\n";
			_MSG += $"\tFilms: {ReturnAnnoying_Fields(films)}\tSpecies: {ReturnAnnoying_Fields(species)}\tStarships: {ReturnAnnoying_Fields(starships)}\n";
			_MSG += $"\tVehicles: {ReturnAnnoying_Fields(vehicles)}\tURL: {URL}\tCreated: {created}\n";
			_MSG += $"\tEdited: {edited}\tID: {ID}";
			return _MSG;
		}
	}
}

