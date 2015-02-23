namespace _19_Using_ref_Example
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestPerson
    {

        public static void Main()
        {
            Person person = new Person("Dimitar Zahariev", 22);
            Console.WriteLine("Name: {0}, Age: {1}", person.Name, person.Age);
            Person.ModifyPerson(person); // not modified
            Console.WriteLine("Name: {0}, Age: {1}", person.Name, person.Age);
            Person.ModifyPersonByRef(ref person); // modified
            Console.WriteLine("Name: {0}, Age: {1}", person.Name, person.Age);
        }
    }
}
