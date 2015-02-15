using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_LINQAggregationMethods_Example
{
    class LINQAggregationMethods
    {
        static void Main(string[] args)
        {

            double[] temperatures = { 28.0, 19.5, 32.3, 33.6, 26.5, 29.7 };
            foreach (var t in temperatures)
            {
                Console.Write("{0} ", t);
            }

            // reverse array
            Console.WriteLine("\nReversed array:");
            foreach (var t in temperatures.Reverse())
            {
                Console.Write("{0} ", t);
            }
            Console.WriteLine();

            // array to List
            List<double> tempList = temperatures.ToList();
            Console.WriteLine("Array: {0}\nList: {1}", temperatures, tempList);

            // ordered array
            Console.WriteLine("\nOrdered by descending array:");
            foreach (var t in temperatures.OrderByDescending(t => t))
            {
                Console.Write("{0:f2} ", t);
            }
            Console.WriteLine();

            // some LINQ methods
            double maxTemp = temperatures.Max();
            double minTemp = temperatures.Min();
            double sum = temperatures.Sum();
            var highTemp =
              (from p in temperatures
               where p > 30
               select p).Count();
            double avgTemp = temperatures.Average();
            Console.WriteLine(
                "Max(): {0:F2}\nMin(): {1:F2}\nSum(): {2:F2}\n(value > 30).Count(): {3:F2}\nAverage(): {4:F2}",
                maxTemp, minTemp, sum, highTemp, avgTemp);

            double firstOrFefault = temperatures.FirstOrDefault();
            double first = temperatures.First(t => t > 30);
            double lastOrDefault = temperatures.LastOrDefault();
            double last = temperatures.Last(t => t > 30);
            Console.WriteLine(
                "FirstOrDefault(): {0:f2}\nFirst(t => t > 30): {1:F2}\nLastOrDefault(): {2:F2}\nLast(t => t > 30): {3:F2}", 
                firstOrFefault, first, lastOrDefault, last);

            bool isThereEvenIntNum = temperatures.Any(t => (int)t % 2 == 0);
            Console.WriteLine("Is there even number in array after parse to Int? -> {0}", 
                isThereEvenIntNum);
            var evenNum =
                (from t in temperatures
                 where (int)t % 2 == 0
                 select t);
            foreach (var t in evenNum)
            {
                Console.Write("{0}; ", (int)t);
            }

            bool checkAll = temperatures.All(t => t > 29);
            Console.WriteLine("\nAll(t => t > 29): {0}", checkAll);
        }
    }
}
