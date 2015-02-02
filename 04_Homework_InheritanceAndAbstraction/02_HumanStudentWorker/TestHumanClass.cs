using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_HumanStudentWorker
{
    public class TestHumanClass : Human
    {
        public static void Main()
        {
            IList<Student> students = new List<Student> 
            {
                new Student("Ivan", "Ivanov", "128rt3"),
                new Student("Georgi", "Stoev", "e8rt3"),
                new Student("Ivan", "Vasilev", "1id7t3"),
                new Student("Hristo", "Ivanov", "1a28r9t3"),
                new Student("Dimitar", "Peshev", "128003"),
                new Student("Ignat", "Ivanchev", "128rt3"),
                new Student("Gergana", "Ivanova", "1348rt3"),
                new Student("Ivanka", "Peneva", "1280v3"),
                new Student("Ignat", "marinov", "12trt30000"),
                new Student("Irina", "Momchilova", "100rt37")
            };
            var sortedStudents = students.OrderBy(s => s.FacultyNumber);
            Console.WriteLine("Students ordered by faculty number ascending:\n");
            Console.WriteLine("\t" + string.Join("\n\t",sortedStudents.Select(s => s.ToString())));

            IList<Worker> workers = new List<Worker> 
            {
                new Worker("Ginka", "Stankova", 100, 8),
                new Worker("Ivan", "Ignatov", 220, 12),
                new Worker("valeri", "Ivanov", 120, 8),
                new Worker("Rosen", "Iliev", 200, 8),
                new Worker("Nadia", "Ivanova", 100, 4),
                new Worker("Evgeni", "Kolev", 250, 8),
                new Worker("Stoian", "Ivanov", 180, 9),
                new Worker("Radostina", "Ilieva", 200, 10),
                new Worker("Elena", "Vasileva", 300, 8),
                new Worker("Stoimen", "Kamenov", 300, 6)
            };
            var sortedWorkers = workers.OrderByDescending(w => w.MoneyPerHour());
            Console.WriteLine("\nWorkers ordered by money per hour descending:\n");
            Console.WriteLine("\t" + string.Join("\n\t", sortedWorkers.Select(w => w.ToString())));
            
            var humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);
            Console.WriteLine("\nHumans ordered by first and last name:\n");
            var sortHumans = humans.OrderBy(h => h.FirstName).ThenBy(h => h.LastName)
            .Select(h => h.FirstName + " " + h.LastName + " - -> " + h.GetType());
            Console.WriteLine("\n\t" + string.Join("\n\t", sortHumans));
        }
    }
}
