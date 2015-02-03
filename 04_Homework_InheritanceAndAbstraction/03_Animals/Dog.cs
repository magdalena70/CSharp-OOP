using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int age, Gender Gender)
            : base(name, age, Gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine(" Bauuuu, bauuuuu...");
        }
    }
}
