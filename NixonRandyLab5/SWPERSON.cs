using System;
using System.Collections.Generic;

namespace SWPERSON
{
	public class SWAPIPerson
	{
		public string name { get; set; }
		public string birth_year { get; set; }
		public string eye_color { get; set; }
		public string gender { get; set; }
		public string hair_color { get; set; }
		public string height { get; set; }
		public string mass { get; set; }
		public string skin_color { get; set; }
		public string homeworld { get; set; }
		public List<string> films { get; set; }
		public List<string> species { get; set; }
		public List<string> starships { get; set; }
		public List<string> vehicles { get; set; }
		public string URL { get; set; }
		public string created { get; set; }
		public string edited { get; set; }

		public override string ToString()
		{
			string _MSG = "";
			_MSG += $"Name: {name}\tBirth Year: {birth_year}\tEye Color: {eye_color}\n";
			_MSG += $"Gender: {gender}\tHair Color: {hair_color}\tHeight: {height}\n";
			_MSG += $"Mass: {mass}\tSkin Color: {skin_color}\tHomeworld: {homeworld}\n";
			return _MSG;
		}
	}
}

