using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SchoolSpace
{
    public class Class : School
    {
        private string uniqueTextIdentifier;
        private IList<Teacher> teachers = new List<Teacher>();
        private IList<Student> students = new List<Student>();

        public Class(string uniqueTextIdentifier)
        {
            this.uniqueTextIdentifier = uniqueTextIdentifier;
        }

        public Class(string uniqueTextIdentifier, IList<Teacher> teachers)
            :this(uniqueTextIdentifier)
        {
            this.teachers = teachers;
        }

        public string UniqueTextIdentifier
        {
            get
            {
                return this.uniqueTextIdentifier;
            }
            set
            {
                this.uniqueTextIdentifier = value;
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public override string ToString()
        {
            return "Class " + this.uniqueTextIdentifier + ":\n\nTeacher: " +
            string.Join("\nTeacher: ", this.teachers.Select(t => t.ToString()).ToArray()) + "\n";
        }
    }
}
