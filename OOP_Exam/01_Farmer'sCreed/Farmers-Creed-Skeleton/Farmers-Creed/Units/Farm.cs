namespace FarmersCreed.Units
{
    using System;
    using System.Collections.Generic;
    using FarmersCreed.Interfaces;
    using System.Linq;
    using System.Text;

    public class Farm : GameObject, IFarm
    {
        public Farm(string id)
            : base(id)
        {
            this.Plants = new List<Plant>();
            this.Animals = new List<Animal>();
            this.Products = new List<Product>();
        }

        public List<Plant> Plants { get; private set; }
        public List<Animal> Animals { get; private set; }
        public List<Product> Products { get; private set; }

        /// <summary>
        /// If a product with a given Id is added to the farm 
        /// and another product with the same Id already exists, 
        /// only the quantity of the existing product is increased.
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product)
        {
            var foundProduct = this.Products
                .FirstOrDefault(p => p.Id == product.Id);
            if (foundProduct != null)
            {
                foundProduct.Quantity += product.Quantity;
            }
            else
            {
                this.Products.Add(product);
            }          
        }

        /// <summary>
        /// exploit animal/plant (animalId/plantId) – 
        /// exploits (gets the product from) an animal/plant and adds the product to the farm
        /// </summary>
        /// <param name="productProducer"></param>
        public void Exploit(IProductProduceable productProducer)
        {
            var product = productProducer.GetProduct();
            this.AddProduct(product);
        }

        /// <summary>
        /// feed (animalId) (foodId) (quantity) – 
        /// feeds animal animalId with quantity of food foodId and reduces the food's quantity
        /// </summary>
        /// <param name="animal"></param>
        /// <param name="edibleProduct"></param>
        /// <param name="productQuantity"></param>
        public void Feed(Animal animal, IEdible edibleProduct, int productQuantity)
        {
            animal.Eat(edibleProduct, productQuantity);

            var foundProduct = this.Products
                .FirstOrDefault(p => p == edibleProduct); // check for existence by reference
            if (foundProduct != null)
            {

                if (foundProduct.Quantity < productQuantity)
                {
                    throw new ArgumentOutOfRangeException("Incufficient quantity.");
                }

                foundProduct.Quantity -= productQuantity; // current quantity -= eaten quantity
            }
            else
            {
                throw new ArgumentException("Farm does not contain such product.");
            }
        }

        /// <summary>
        /// water (plantId) – waters plant plantId
        /// </summary>
        /// <param name="plant"></param>
        public void Water(Plant plant)
        {
            plant.Water();
        }

        /// <summary>
        /// Live animals starve and live plants grow or wither each time a command is processed, 
        /// except for status commands. 
        /// (See FarmSimulator for details on how it works). 
        /// Edit: Use the UpdateFarmState() method for this purpose.
        /// </summary>
        public void UpdateFarmState()
        {
            foreach (var plant in this.Plants)
            {
                if (plant.HasGrown)
                {
                    plant.Wither();
                }
                else
                {
                    plant.Grow();
                }
            }

            foreach (var animal in this.Animals)
            {
                animal.Starve();
            }
        }

        public override string ToString()
        {
            StringBuilder farmInfo = new StringBuilder();
            farmInfo.AppendLine();

            var animalIsAlive = this.Animals
                .Where(a => a.IsAlive)
                .OrderBy(a => a.Id);
            foreach (var animal in animalIsAlive)
            {
                farmInfo.AppendLine(animal.ToString());
            }

            var plantIsAlive = this.Plants
                .Where(p => p.IsAlive)
                .OrderBy(p => p.Health)
                .ThenBy(p => p.Id);
            foreach (var plant in plantIsAlive)
            {
                farmInfo.AppendLine(plant.ToString());
            }

            var orderedProducts = this.Products
                .OrderBy(pr => pr.ProductType.ToString())
                .ThenByDescending(pr => pr.Quantity)
                .ThenBy(pr => pr.Id);
            foreach (var product in orderedProducts)
            {
                farmInfo.AppendLine(product.ToString());
            }

            return base.ToString() + farmInfo.ToString();
        }
    }
}
