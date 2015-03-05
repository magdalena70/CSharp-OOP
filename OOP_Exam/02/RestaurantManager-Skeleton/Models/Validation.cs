using System;

namespace RestaurantManager.Models
{
    public static class Validation
    {
        private const int MaxDrinkCalories = 100;
        public const int MaxTimeToPrepareDrink = 20;

        public static void ForRequiredString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Parameter is required.");
            }
        }

        public static void ForPositiveNumber(decimal number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Parameter cannot be negative.");
            }
        }

        public static void ForDrinkCalories(int calories)
        {
            if (calories > MaxDrinkCalories)
            {
                throw new ArgumentException("Calories in a drink cannot be more than " + 
                    MaxDrinkCalories + ".");
            }
        }

        public static void ForDrinkTimeToPrepare(int time)
        {
            if (time > MaxTimeToPrepareDrink)
            {
                throw new ArgumentException("Time to prepare a drink cannot be more than " + 
                    MaxTimeToPrepareDrink +" min.");
            }
        }
    }
}
