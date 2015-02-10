using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GenericList
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

            Console.WriteLine("intList Capacity = {0}", intList.Capacity);
            Console.WriteLine("intList count = {0}", intList.Count);
            Console.WriteLine("intList contains numbers {0}", intList);
            Console.WriteLine("intList[1] = {0}", intList[1]);
            intList.Insert(7, 3);
            Console.WriteLine("intlist insert new number and now contains numbers {0}", intList);
            intList.Remove(1);
            Console.WriteLine("intList remove element at index [1] and now contains numbers {0}", intList);
            Console.WriteLine("intList.IndexOf(102) => {0}", intList.IndexOf(102));
            Console.WriteLine("intList.Contains(18) => {0}", intList.Contains(18));
            Console.WriteLine("intList.Contains(100) => {0}", intList.Contains(100));
            int compareNumber = 34;
            Console.WriteLine("Compare intList's elements to number {0}:", compareNumber);
            for (int i = 0; i < intList.Count; i++)
            {
                int min = Min(intList[i], compareNumber);
                int max = Max(intList[i], compareNumber);
                Console.WriteLine("min value = {0}, max value = {1}", min, max);
            }
        }

        // generic method Min()
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

        //generic method Max()
        public static T Max<T>(T first, T second)
            where T : IComparable<T>
        {
            if (first.CompareTo(second) > 0)
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
