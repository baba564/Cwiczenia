using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zadaniaa
{
    internal class Username
    {
        public static bool Validate(string username)
        {
            Regex sampleRegex = new Regex(@"^[A-Za-z]((?=.*[A-Za-z])||(?=.*\d)||(?=.*[_]))[A-Za-z\d_]{4,}$");

            if (!username.EndsWith("_") && sampleRegex.IsMatch(username))

                return true;
            else
               
                return false;
        }
	 
	public static void RunValidate()
        {
            Console.WriteLine(Validate("Mike_Standish")); // Valid username 
            Console.WriteLine(Validate("Mike Standish")); // Invalid username 
        }
    }
}
