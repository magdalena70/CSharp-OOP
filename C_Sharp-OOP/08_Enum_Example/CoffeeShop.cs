using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Enum_Example
{
    public class CoffeeShop
    {
        static void Main()
        {
            Coffee smallCoffee = new Coffee(CofeeSize.Small);
            Coffee normalCoffee = new Coffee(CofeeSize.Normal);
            Coffee doubleCoffee = new Coffee(CofeeSize.Double);
            // Coffee unknoun = new Coffee((CofeeSize)Enum.Parse(typeof(CofeeSize), "unknoun")); // return Exeption

            Console.WriteLine("The {0} coffee is {1} ml.",
                smallCoffee.Size, (int)smallCoffee.Size);
            Console.WriteLine("The {0} coffee is {1} ml.",
                normalCoffee.Size, (int)normalCoffee.Size);
            Console.WriteLine("The {0} coffee is {1} ml.",
                doubleCoffee.Size, (int)doubleCoffee.Size);
        }
    }
}
