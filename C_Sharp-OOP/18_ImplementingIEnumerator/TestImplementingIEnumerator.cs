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
                Console.WriteLine(element);
            }
        }
    }
}
