using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SchoolSpace
{
    public class Teacher : People
    {
        private IList<Disciplines> disciplines = new List<Disciplines>();

        public Teacher(string name)
            : base(name)
        {
        }

        public Teacher(string name, IList<Disciplines> disciplines)
            : base(name)
        {
            this.disciplines = disciplines;
        }

        public void AddDiscipline(Disciplines discipline)
        {
            this.disciplines.Add(discipline);
        }

        public override string ToString()
        {
            return base.ToString() + "\n  " +
            string.Join("\n  ", this.disciplines.Select(d => d.ToString()).ToArray());
        }

    }
}
