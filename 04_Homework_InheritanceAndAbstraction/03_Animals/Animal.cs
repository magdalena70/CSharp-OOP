using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animals
{

    public enum Gender
    {
        female,
        male
    }
    abstract public class Animal : ISound
    {
        private string name;
        private int age;

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validation.CheckForNullOrEmpty(value, "Name");
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                Validation.CheckForNegativeOrZero(value, "Age");
                this.age = value;
            }
        }

        public Gender Gender { get; set; }

        public abstract void ProduceSound(); 

        public override string ToString()
        {
            return String.Format("I am {0}.I am a {1} {2}...",
                this.Name, this.Gender, (this.GetType().Name).ToLower());
        } 
    }
}
