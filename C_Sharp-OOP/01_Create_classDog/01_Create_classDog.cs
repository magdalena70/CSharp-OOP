using System;
    //create basic class Dog
    class Dog
    {
        //fields
        private string name;
        private string breed;

        //empty constructor(parameterless)
        public Dog()
        {
        }

        //constructor with parameters
        public Dog(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }

        //properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Breed
        {
            get
            {
                return this.breed;
            }
            set
            {
                this.breed = value;
            }
        }

        //create method for all of dogs
        public void SayBau()
        {
            Console.WriteLine("{0} said Bauuuuuu",
            this.name ?? "[unnamed dog]");
        }

    }
    //create next class DogMeeting,that using class Dog
    class DogMeeting
    {
        static void Main()
        {
            //create first dog
            Console.Write("Enter first dog's name: ");
            string dogName = Console.ReadLine();
            Console.Write("Enter first dog's breed: ");
            string dogBreed = Console.ReadLine();
            //use the Dog constructor to assigne name and breed
            Dog firstDog = new Dog(dogName, dogBreed);

            //use parameterless Dog constructor to create a second dog
            Dog secondDog = new Dog();
            //use properties to assine name and breed
            Console.Write("Enter second dog's name: ");
            secondDog.Name = Console.ReadLine();
            Console.Write("Enter second dog's breed: ");
            secondDog.Breed = Console.ReadLine();

            //create third dog with no name and breed by parameterless Dog constructor
            Dog thirdDog = new Dog();

            //save the dogs in an array
            Dog[] dogs = new Dog[] { firstDog, secondDog, thirdDog };
            foreach (Dog dog in dogs)
            {
                dog.SayBau();
            }

        }
    }

