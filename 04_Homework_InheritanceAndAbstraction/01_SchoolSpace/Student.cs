using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SchoolSpace
{
    public class Student : People
    {
        private int uniqueClassNumber;

        public Student(string name, int uniqueClassNumber)
            : base(name)
        {
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public int UniqueClassNumber
        {
            get
            {
                return this.uniqueClassNumber;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Unique Class Number cannot be negative or zero.");
                }

                this.uniqueClassNumber = value;
            }
        }

        public override string ToString()
        {
            return String.Format("N{0} - {1}", this.UniqueClassNumber, base.ToString());
        }
    }
}
