using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Clone_Example
{
    class Test
    {
        public static void Main()
        {
            LinkedList<string> initialList = // recursive
                new LinkedList<string>("John",
                    new LinkedList<string>("Jaga",
                        new LinkedList<string>("Kiro")));

            LinkedList<string> deeplyClone = initialList.Clone();
            deeplyClone.TValue = "1st value";
            deeplyClone.NextNode.TValue = "2nd value";
            deeplyClone.NextNode.NextNode.TValue = "3d value";

            Console.WriteLine("Inicial list = {0}", initialList);
            Console.WriteLine("Deeply clonning list = {0}", deeplyClone);
        }
    }
}
