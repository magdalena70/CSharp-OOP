using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_HumanStudentWorker
{
    abstract public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot to be empty or null.");
                }

                var regex = new Regex("[A-Za-z]");
                var matches = regex.Matches(value);
                if (value.Length > matches.Count)
                {
                    throw new ArgumentException("Invalid argument. Use only letters.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot to be empty or null.");
                }

                var regex = new Regex("[A-Za-z]");
                var matches = regex.Matches(value);
                if (value.Length > matches.Count)
                {
                    throw new ArgumentException("Invalid argument. Use only letters.");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
