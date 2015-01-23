using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Homework_DefiningClasses
{
    class TestPerson
    {
        //test class Person and print result
        static void Main()
        {
            Person firstPerson = new Person(name: "Todor", age: 101, email: "todor@abv.bg");
            Console.WriteLine(firstPerson);
            Person secondPerson = new Person(name: "Vasil", age: 12);
            Console.WriteLine(secondPerson);
        }

    }
}
