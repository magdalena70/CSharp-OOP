using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_LINQ_Example
{
    class LinqQuery
    {
        
        static void Main(string[] args)
        {
            // -----------1---------- //

            Console.WriteLine("Enter some integer number: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = { 1, 7, 8, 65, 2, 44, 20 };
            var numberLessThanFive =
                (from number in numbers
                where number < n
                orderby number descending
                select number).ToArray();
            Console.Write("Numbers less than {0}: ", n);
            foreach (var num in numberLessThanFive)
            {
                Console.Write(num.ToString() + " ");
            }


            // -----------2---------- //
            // Nested queries:
            /*
            string[] towns = {"Varna", "Ruse", "Sofia", "Burgas", "Plovdiv", "Stara Zagora"};
            var selectedTowns =
                from firstTown in towns
                    from secondTown in towns
                    where firstTown != secondTown
                    orderby firstTown, secondTown descending
                    select new { T1 = firstTown, T2 = secondTown };
            foreach (var town in selectedTowns)
            {
                Console.WriteLine("{0}, {1}", town.T1, town.T2);
                //Console.WriteLine(town);
            }

            var firstLetterOfName = towns
                .Where(town => town.Length > 3)
                .OrderByDescending(town => town)
                .Select(town => town[0]);
            foreach (var town in firstLetterOfName)
            {
                Console.Write(town + " ");
            }
            Console.WriteLine();
            */

            // -----------3--------- //
            // Find town.StartsWith("S") with lambda expression
            /* 
             List<string> townsList = new List<string>() { "Sofia", "Plovdiv", "Varna", "Sopot", "Silistra" };
             List<string> townsWithS = townsList.FindAll((town) => town.StartsWith("S"));

             foreach (string town in townsWithS)
             {
                 Console.WriteLine(town);
             }
            */

            // -----------4--------- //
            // Counting the Words in a String 
            /*
            string text = "Some text, any words...words, words!";
            string searchTerm = "words";
            string[] splittedText = text.Split(
                new char[] { ' ', ',', '.', '!', '?', ':', ';', '-'},
                StringSplitOptions.RemoveEmptyEntries);
            var matchQuery =
                from word in splittedText
                where word.ToLower() == searchTerm.ToLower() // to match 'words' and 'Words'
                select word;
            int count1 = matchQuery.Count();
            Console.WriteLine(count1);
            // count1 == count2 -> different syntax
            int count2 = splittedText.Where(w => w.ToLower() == searchTerm.ToLower()).Count();
            Console.WriteLine(count2);
            */

            // -----------5----------- //
            // Counting the non-letter characters in a String
            /*
            string thisText = "It is actually a collection, because it implements IEnumerable<char>";
            var countNonLetter =
              (from c in thisText
               where !Char.IsLetter(c)
               select c).Count();
            Console.WriteLine("\nNon-letter characters in this text are: {0}.", countNonLetter);
            */
        }
    }
}
