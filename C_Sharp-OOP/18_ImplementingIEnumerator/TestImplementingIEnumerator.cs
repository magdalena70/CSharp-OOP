namespace _18_ImplementingIEnumerator
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class TestImplementingIEnumerator
    {
        public static void Main()
        {
            LinkedList<string> ienumerableLinkedList = 
                new LinkedList<string> ("First element",
                    new LinkedList<string> ("Second element",
                        new LinkedList<string> ("Third element")));
            foreach (var element in ienumerableLinkedList)
            {
                Nullable<decimal> number = null;
                Console.WriteLine("LinkedList -> {0},\nNullable -> {1}", 
                    element, number.GetValueOrDefault());
            }

            Console.WriteLine();
            ValueType valType = 10;
            Console.WriteLine("ValueType valType = {0}, {0} is {1}",valType, valType.GetType());
            valType = 6.3;
            Console.WriteLine("valType = {0}, {0} is {1}", valType, valType.GetType());
            valType = 10000000000000000000;
            Console.WriteLine("valType = {0}, {0} is {1}", valType, valType.GetType());
            decimal numDec = 100;
            valType = numDec; // boxing (stak -> heap)
            Console.WriteLine("decimal numDec = {0}, valType = numDec, valType is {1}", numDec, valType.GetType());
            //int numInt = (int)valType; // return InvalidCastException
            int numInt = (int)(decimal)valType; // unboxing (heap -> stak)
            Console.WriteLine("int numInt = (int)(decimal)valType, numInt = {0}", numInt);
        }
    }
}
