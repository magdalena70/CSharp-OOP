using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Generic_Example
{
    class TestGenericList
    {
        static void Main()
        {
            // declare list of type int
            GenericList<int> intList = new GenericList<int>();
            intList.Add(102);
            intList.Add(2);
            intList.Add(18);
            intList.Add(4);
            intList.Add(22);
            intList.Add(309);
            
            int sum = 0;
            Console.WriteLine("intList contains {0} elements: ", intList.Count);
            for (int i = 0; i < intList.Count; i++)
            {
                // intList[intList.Count - 1] += intList[i]; // using setter of indexator
                sum += intList[i];
                Console.WriteLine(" {0}, ", intList[i]);
            }

            Console.WriteLine("Sum of numbers = {0}\n", sum);

            // declare variable of type int and compare numbers
            int intVariableToCompare = 10;
            for (int i = 0; i < intList.Count; i++)
            {
                int minValue = Min(intList[i], intVariableToCompare);
                Console.WriteLine("number {0}.Compare to number {1} => min value is {2}",
                    intList[i], intVariableToCompare, minValue);
            }

            // declare list of type string
            GenericList<string> strList = new GenericList<string>();
            strList.Add("One");
            strList.Add("Two");
            strList.Add("Three");
            strList.Add("the End");

            Console.WriteLine("\nstrList contains {0} elements:", strList.Count);
            for (int i = 0; i < strList.Count; i++)
            {
                Console.WriteLine(strList[i]);
            }

            Console.WriteLine();
            // declare variable of type string and compare strings
            string strVariableToCompare = "Two";
            for (int i = 0; i < strList.Count; i++)
            {
                string minValueStr = Min(strList[i], strVariableToCompare);
                Console.WriteLine("string '{0}'.Compare to string '{1}' => min value is '{2}'",
                    strList[i], strVariableToCompare, minValueStr);
            }
        }

        // generic method
        public static T Min<T>(T first, T second)
            where T : IComparable<T>
        {
            if (first.CompareTo(second) <= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
