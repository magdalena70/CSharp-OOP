
using RestaurantManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManager.Models
{
    class Restaurant : IRestaurant
    {
        private string name;
        private string location;
        private IList<IRecipe> recipes;

        public Restaurant(string name, string location) 
        {
            this.Name = name;
            this.Location = location;
            this.Recipes = new List<IRecipe>();
        }

        public string Name
        {
            get { return this.name; }
            private set 
            {
                Validation.ForRequiredString(value);
                this.name = value; 
            }
        }

        public string Location
        {
            get { return this.location; }
            private set
            {
                Validation.ForRequiredString(value);
                this.location = value;
            }
        }

        public IList<IRecipe> Recipes
        {
            get { return this.recipes; }
            private set
            {
                this.recipes = value;
            }
        }

        public void AddRecipe(IRecipe recipe)
        {
            this.recipes.Add(recipe);
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            this.recipes.Remove(recipe);
        }

        public string PrintMenu()
        {
            StringBuilder menu = new StringBuilder();
            menu.AppendFormat("{0} {1} - {2} {0}",
                new string('*', 5), this.Name, this.Location);
            if (this.Recipes.Any())
            {
                menu.Append(this.GetMenuGroup("Drink", "drinks"));
                menu.Append(this.GetMenuGroup("Salad", "salads"));
                menu.Append(this.GetMenuGroup("MainCourse", "main courses"));
                menu.Append(this.GetMenuGroup("Dessert", "desserts"));
            }
            else
            {
                menu.Append("\nNo recipes... yet");
            }

            return menu.ToString();
        }

        private string GetMenuGroup(string type, string heading)
        {
            var matchedRecipes = this.Recipes
                .Where(r => r.GetType().Name == type)
                .OrderBy(r => r.Name)
                .ToList();
            if (matchedRecipes.Any())
            {
                string groupTitle = string.Format("\n{0} {1} {0}\n", new string('~', 5), heading.ToUpper());
                groupTitle += string.Join(Environment.NewLine, matchedRecipes);
                return groupTitle;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
