using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Homework_DefiningClasses
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        // Define property that accept non-empty name.
        public string Name
        {
            get 
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Address cannot be empty");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        // Define property that accept age in the range [1...100].
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be out of range [1...100]. ");
                }
                else
                {
                    this.age = value;
                }
            }
        }
        //Define a property for the email that accepts either null or non-empty string containing '@'. 
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if(value != null && !value.Contains("@"))
                {
                    throw new ArgumentException("Invalid Email");
                }
                else
                {
                    this.email = value;
                }
            }
        }

        //First constructor should take name, age and email.The name and age are mandatory. The email is optional. 
        public Person(string name, int age, string email = null)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        //Second constructor should take name and age only and call the first constructor.
        public Person(string name, int age):this(name, age, null)
        {
        }

        //Implement the ToString() method to enable printing persons at the console.
        public override string ToString()
        {
            string result = String.Format("Person's name is: {0}, age is {1} ", this.Name, this.Age);
            if (this.Email != null)
            {
                result += String.Format("email is {0}", this.Email);
            }
            return result;
        }
    }
}
