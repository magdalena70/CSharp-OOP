using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animals
{
    public class TestAnimals
    {
        public static void Main()
        {
            Cat cat = new Cat("Macana", 2, Gender.female);
            Kitten kitten = new Kitten("", 1);
            Tomcat tomcat = new Tomcat("Tom", 4);
            Dog dog = new Dog("Rex", 6, Gender.male);
            Frog frog = new Frog("Kikirana", 2, Gender.female);

            var animals = new Animal[]
            {
                cat,
                kitten,
                tomcat,
                dog,
                frog
            };

            foreach (var animal in animals)
            {
                Console.Write("{0}",animal);
                animal.ProduceSound();
            }
            
            var groupedAnimalsByType = animals.GroupBy(GetAnimalType,
           (t, a) => new { type = t, averageAge = a.Average(animal => animal.Age) });

            foreach (var group in groupedAnimalsByType)
            {
                Console.WriteLine("The average age of {0}s is {1:f2}.", group.type, group.averageAge);
            }
        }

        public static string GetAnimalType(Animal animal)
        {
            //Console.WriteLine("animal.GetType().BaseType.Name = {0}", animal.GetType().BaseType.Name);
        string type = "";
        if (animal.GetType().BaseType.Name != "Animal")
        {
            type = animal.GetType().BaseType.Name;
        }
        else
        {
            type = animal.GetType().Name;
        }

        return type;
        }
        
    }
}
