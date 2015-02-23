namespace _19_Using_ref_Example
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // by reference
        public static void ModifyPersonByRef(ref Person person)
        {
            person = new Person("Modified Name by ref", person.Age);
        }

        public static void ModifyPerson(Person person)
        {
            person = new Person("Modified Name without ref", person.Age);
        }
    }
}
