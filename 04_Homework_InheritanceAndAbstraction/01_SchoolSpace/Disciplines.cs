using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SchoolSpace
{
    public class Disciplines : School
    {
        private string name;
        private int numberOfLectures;
        private IList<Student> students = new List<Student>();
        private string details;

        public Disciplines(string name)
        {
            this.Name = name;
        }

        public Disciplines(string name, int numberOfLectures, string details)
            : this(name)
        {
            this.NumberOfLectures = numberOfLectures;
            this.Details = details;

        }

        public Disciplines(string name, int numberOfLectures, string details, IList<Student> students)
            :this(name, numberOfLectures, details)
        {
            this.students = students;

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }

                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of lectures cannot be negative.");
                }

                this.numberOfLectures = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                this.details = value;
            }
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public override string ToString()
        {
            return "Discipline: " + this.Name + " -> " + this.Details + "\n" +
            string.Join("",
                this.students.OrderBy(x => x.UniqueClassNumber).Select(s => s.ToString() + "\n").ToArray());
        }
    }
}
