using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SchoolSpace
{
    public class TestSchool : School
    {
        public static void Main()
        {
            IList<Student> studentsCSharp = new List<Student>
            {
                new Student("Angel Petrov", 1),
                new Student("Victor Vasilev", 4),
                new Student("Boris Ignatiev", 2),
                new Student("Borislav Dimitrov", 3)
            };

            var oopCSharp = new Disciplines("OOP C#", 4, "Monday - 6.00 PM, Wednesday - 6.00 PM ", studentsCSharp);
            var oopCSharpTeacher = new Teacher("Ivan Ivanov");
            oopCSharpTeacher.AddDiscipline(oopCSharp);
            //Console.WriteLine(oopCSharpTeacher);

            IList<Student> studentsJava = new List<Student>
            {
                new Student("Angel Petrov", 1),
                new Student("Victor Vasilev", 5),
                new Student("Borislav Dimitrov", 3),
                new Student("Emil Stefanov", 4),
                new Student("Boris Ignatiev", 2)
            };

            var oopJava = new Disciplines("OOP Java", 5, "Friday - 10.00 AM, Sunday - 10.00 AM", studentsJava);
            //Console.WriteLine(oopJava);
            var oopJavaTeacher = new Teacher("Petar Petrov");
            oopJavaTeacher.AddDiscipline(oopJava);

            var oopPHP = new Disciplines("OOP PHP", 2, "Satursday - 4.30 PM");
            oopPHP.AddStudent(studentsCSharp[0]);
            oopPHP.AddStudent(studentsJava[4]);
            var oopPHPTeacher = new Teacher("Evlogi Manov");
            oopPHPTeacher.AddDiscipline(oopPHP);

            var classOOP = new Class("OOP", new List<Teacher> {oopCSharpTeacher, oopJavaTeacher, oopPHPTeacher});
            //Console.WriteLine(classOOP);

            
            studentsCSharp.Add(new Student("Zlatko Zlatkov", 6));
            oopPHP.AddStudent(new Student("Zlatko Zlatkov", 6));
            Console.WriteLine("Class OOP add new student:");
            Console.WriteLine(classOOP);
        }
    }
}
