using System;
using System.Collections.Generic;
using System.Linq;

public delegate int StringDelegate<T>(T value);

namespace _13_Multidelegates_Example
{

    public class MultiDelegates
    {
        
        static int PrintStringOne(string strOne)
        {
            Console.WriteLine("{0} print One", strOne);
            return 1;
        }

        int PrintStringTwo(string strTwo)
        {
            Console.WriteLine("{0} print Two", strTwo);
            return 1;
        }

        static int PrintStringThree(string strThree)
        {
            Console.WriteLine("{0} print Three", strThree);
            return 1;
        }

        public static void Main()
        {
            int sumDelegateAddedMethods = 1; // delegate add anonymous method
            StringDelegate<string> multiDelegate = delegate(string str) // short syntax
            {
                Console.WriteLine("\nUpperCase {0}", str.ToUpper());
                return 1;
            };
            // Add more methods (+=)
            multiDelegate += MultiDelegates.PrintStringOne; // static method
            sumDelegateAddedMethods += multiDelegate("PrintStringOne()");

            MultiDelegates instance = new MultiDelegates();
            multiDelegate += instance.PrintStringTwo; // instance method
            sumDelegateAddedMethods += multiDelegate("PrintStringTwo()");

            multiDelegate += MultiDelegates.PrintStringThree; // static method
            sumDelegateAddedMethods += multiDelegate("Print String Three()");
            Console.WriteLine("\nDelegate added {0} methods.", sumDelegateAddedMethods);

            multiDelegate -= MultiDelegates.PrintStringThree;
            Console.Write("\nDelegate removed PrintStringThree ->");
            multiDelegate("Print only:");

        }
    }
}
