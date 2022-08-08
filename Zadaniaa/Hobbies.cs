using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaniaa
{
    internal class Hobbies
    {
		private readonly Dictionary<string, string[]> hobbies = new Dictionary<string, string[]>();

		public void Add(string hobbyist, params string[] hobbies)
		{
			this.hobbies.Add(hobbyist, hobbies);
		}

		public List<string> FindAllHobbyists(string hobby)
		{
			List<string> list = new List<string>();
			
			foreach (var pair in hobbies)
			{
				foreach (var item in pair.Value)
                {
					if (item.Equals(hobby))
						list.Add(pair.Key);
				}

			}	

			
			return list;
		}

		public static void WywolajHobbi()
		{
			Hobbies hobbies = new Hobbies();
			hobbies.Add("Steve", "Fashion", "Piano", "Reading");
			hobbies.Add("Patty", "Drama", "Magic", "Pets");
			hobbies.Add("Chad", "Puzzles", "Pets", "Yoga");

			hobbies.FindAllHobbyists("Yoga").ForEach(item => Console.WriteLine(item));
		
		}
	}
}
