using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent
{
    class TestStudents
    {
        static void Main()
        {
            var students = new List<Student>
            {
                new Student(
                    "Milena",
                    "Kirova", 
                    21, 
                    215314, 
                    "+359 2 77 123 888", 
                    "email@gfg.bg", 
                    new List<int>{5, 2, 5, 4}, 
                    2),
                new Student(
                    "Stefan", 
                    "Popov", 
                    32, 
                    203114, 
                    "0885 123 321", 
                    "email@abv.bg", 
                    new List<int>{6, 6, 5, 6}, 
                    2),
                new Student(
                    "Asya", 
                    "Manova", 
                    28, 
                    203314, 
                    "0888 778 888", 
                    "email@abv.bg", 
                    new List<int>{3, 3, 6, 4}, 
                    4),
                new Student(
                    "Diana", 
                    "Petrova", 
                    22, 
                    203914, 
                    "02 888 000 788", 
                    "email@abv.bg", 
                    new List<int>{5, 2, 5, 2}, 
                    1),
                new Student(
                    "Ivan", 
                    "Ivanov", 
                    22, 
                    203814, 
                    "02 887 000 788", 
                    "email@abv.bg", 
                    new List<int>{5, 2, 3, 2}, 
                    1)
            };

            // Print all students from group number 2. Use a LINQ query.
            Console.WriteLine("Students by Group ->\n---------");
            var selectedStudents = students.Where(s => s.GroupNumber == 2)
                .Select(s => string.Format("{0} {1} - {2}", s.FirstName, s.LastName, s.GroupNumber));
            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            // Print all students whose first name is before their last name alphabetically.
            Console.WriteLine("Students by First and Last Name:\n---------");
            selectedStudents = students.Where(s => string.Compare(s.FirstName, s.LastName) == -1)
                .Select(s => string.Format("{0} {1}", s.FirstName, s.LastName));
            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            // Write a LINQ query that finds the first name and last name of all students with age between 18 and 24. 
            // The query should return only the first name, last name and age.
            Console.WriteLine("Students by Age:\n---------");
            var selectedStudentsByAge = students.Where(s => s.Age >= 18 && s.Age <= 24)
                .Select(s => new { FirstName = s.FirstName, LastName = s.LastName, Age = s.Age });
            foreach (var student in selectedStudentsByAge)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            // Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by 
            // first name and last name in descending order. 
            Console.WriteLine("Sorted students by first name and last name in descending order:\n---------");
            var sortStudents = students.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName)
                .Select(s => new { FirstName = s.FirstName, LastName = s.LastName });
            foreach (var student in sortStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine("\nRewrite the same with LINQ query syntax.");

            var querySortStudents =
                from s in students
                orderby s.FirstName + s.LastName descending
                select new { FirstName = s.FirstName, LastName = s.LastName, Age = s.Age };

            foreach (var student in querySortStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine();

            // Print all students that have email @abv.bg. Use LINQ.
            Console.WriteLine("Students by Email:\n---------");
            var filterStudentsByEmail = students.Where(s => s.Email.Contains("@abv.bg"))
                .Select(s => new { FirstName = s.FirstName, LastName = s.LastName, Age = s.Email });
            foreach (var student in filterStudentsByEmail)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            // Print all students with phones in Sofia (starting with 02 / +3592 / +359 2). Use LINQ.
            Console.WriteLine("Students by Phone:\n---------");
            var filterStudentsByPhone = students
                .Where(s => s.Phone.IndexOf("02") == 0 || 
                        s.Phone.IndexOf("+3592") == 0 || 
                        s.Phone.IndexOf("+359 2") == 0)
                .Select(s => string.Format("{0} {1} - {2}", s.FirstName, s.LastName, s.Phone));
            foreach (var student in filterStudentsByPhone)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            // Print all students that have at least one mark Excellent (6). 
            //Using LINQ first select them into a new anonymous class that holds { FullName + Marks}.
            Console.WriteLine("Excellent Students:\n---------");
            var excellentStudents = students
                .Select(s => new { FullName = s.FirstName + " " + s.LastName, Marks = s.Marks })
                .Where(s => s.Marks.IndexOf(6) >= 0);
            foreach (var student in excellentStudents)
            {
                Console.WriteLine(student.FullName);
            }

            Console.WriteLine();

            // Write a similar program to the previous one to extract the students with exactly two marks "2". 
            //Use extension methods.
            Console.WriteLine("Weak Students:\n---------");
            var weakStudents = students
                .Where(s => s.Marks.Aggregate(0, (counter, mark) => counter + (mark == 2 ? 1 : 0)) == 2)
                .Select(s => s.FirstName + " " + s.LastName);
            foreach (var student in weakStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            // Extract and print the Marks of the students that enrolled in 2014 
            // (the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber).
            Console.WriteLine("Students Enrolled in 2014:\n---------");
            var studentsEnroled2014 = students
                .Where(s => s.FacultyNumber % 100 == 14)
                .Select(s => s.FirstName + " " + s.LastName + " - " + s.FacultyNumber);
            foreach (var student in studentsEnroled2014)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            // Add a GroupName property to Student. 
            // Write a program that extracts all students grouped by GroupName and then prints them on the console. 
            // Print all group names along with the students in each group. Use the "group by into" LINQ operator.
            Console.WriteLine("Students by Groups:\n---------");
            var studentsByGroups = students
                .GroupBy(s => s.GroupNumber, (g, s) => s);
            foreach (var studentsGroup in studentsByGroups)
            {
                Console.WriteLine("Group number {0} ->", studentsGroup.First().GroupNumber);

                foreach (var student in studentsGroup)
                {
                    Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            // Create a list of student specialties, where each specialty corresponds to a certain student 
            // (via the faculty number). Print all student names alphabetically along with their faculty number 
            // and specialty name. Use the "join" LINQ operator.
            Console.WriteLine("Students Joined To Specialties:\n---------");
            var studentSpecialties = new List<StudentSpecialty>
            {
                new StudentSpecialty("Web Developer", 203314),
                new StudentSpecialty("Web Developer", 203114),
                new StudentSpecialty("PHP Developer", 203814),
                new StudentSpecialty("PHP Developer", 203914),
                new StudentSpecialty("QA Engineer", 203314),
                new StudentSpecialty("Web Developer", 203914),
            };

            var studentsJoinedToSpecialties = students
                .Join(studentSpecialties,
                student => student.FacultyNumber,
                specialty => specialty.FacultyNumber,
                (student, specialty) =>
                new { 
                    StudentName = student.FirstName + " " + student.LastName,
                    StudentNumber = student.FacultyNumber,
                    Specialty = specialty.SpecialtyName
                })
                .OrderBy(student => student.StudentName);

            foreach (var s in studentsJoinedToSpecialties)
            {
                Console.WriteLine("{0} - {1} - {2}", s.StudentName, s.StudentNumber, s.Specialty);
            }
        }
    }
}
