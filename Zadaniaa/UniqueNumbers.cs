using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaniaa
{
    internal class UniqueNumbers
    {
        public static IEnumerable<int> FindUniqueNumbers(IEnumerable<int> numbers)
        {
            IEnumerable<int> result = new List<int>();
                            var wynik =
                    from n in numbers
                    group n by n into nGroup
                    where nGroup.Count() == 1
                    select nGroup.Key;
                    
            result=wynik.ToList();

            return result;
        }

        public static void WywolajUnikalneLiczby()
        {
            int[] numbers = new int[] { 1, 2, 1, 3 };
            foreach (var number in FindUniqueNumbers(numbers))
                Console.WriteLine(number);
        }
    }
}
