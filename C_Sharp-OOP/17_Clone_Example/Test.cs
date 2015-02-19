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

            Console.WriteLine("Initial LinkedList = {0}", initialList);
            Console.WriteLine("Deeply clonning LinkedList = {0}", deeplyClone);

            LinkedList<string> shallowClone = initialList.ShallowCopy(); // muttable
            shallowClone.TValue = "1st value";
            shallowClone.NextNode.TValue = "2nd value";
            shallowClone.NextNode.NextNode.TValue = "3d value";

            Console.WriteLine("Shallow clonning LinkedList = {0}", shallowClone);

            LinkedList<string> memberwiseCopy = initialList.MemberwiseCopy(); // muttable
            memberwiseCopy.TValue = "1st value";
            memberwiseCopy.NextNode.TValue = "2nd value";
            memberwiseCopy.NextNode.NextNode.TValue = "3d value";

            Console.WriteLine("Memberwise clonning LinkedList = {0}", memberwiseCopy);

            if (initialList != deeplyClone)
            {
                Console.WriteLine("initialList != deeplyClone");
            }

            if (initialList == shallowClone)
            {
                Console.WriteLine("initialList == shallowClone");
            }

            if (initialList != memberwiseCopy)
            {
                Console.WriteLine("initialList != memberwiseCopy");
            }

            shallowClone.TValue = "new value";
            Console.WriteLine("shallowClone.TValue = \"new value\" -> print initial LinkedList: {0} -> Initial LinkedList was changed!", 
                initialList);

            //---------//
            Console.WriteLine("---------------------------");
            LinkedList<int> numbers = 
                new LinkedList<int>(100,
                    new LinkedList<int>(200,
                        new LinkedList<int>(300)));

            Console.WriteLine("LinkedList<int> numbers = {0}", numbers);

            LinkedList<int> shallowCloneNumbers = numbers.ShallowCopy();
            shallowCloneNumbers.TValue = 101;
            shallowCloneNumbers.NextNode.TValue = 102;
            shallowCloneNumbers.NextNode.NextNode.TValue = 303;

            Console.WriteLine("numbers.ShallowCopy() = {0}, thеn numbers = {1}", shallowCloneNumbers, numbers);
            if (numbers == shallowCloneNumbers)
            {
                Console.WriteLine("numbers == shallowCloneNumbers");
            }
        }
    }
}
