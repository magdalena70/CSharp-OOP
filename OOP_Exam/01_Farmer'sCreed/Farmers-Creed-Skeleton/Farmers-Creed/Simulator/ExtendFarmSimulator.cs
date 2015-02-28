using FarmersCreed.Interfaces;
using FarmersCreed.Units;
namespace FarmersCreed.Simulator
{
    public class ExtendFarmSimulator : FarmSimulator
    {
        /// <summary>
        /// The add commands should be implemented:
        /// add CherryTree (id) – adds a new CherryPlant to the farm
        /// add TobaccoPlant (id) – adds a new TobaccoPlant to the farm
        /// add Cow (id) – adds a new Cow to the farm
        /// add Swine (id) – adds a new Swine to the farm
        /// </summary>
        /// <param name="inputCommands"></param>
        protected override void AddObjectToFarm(string[] inputCommands)
        {
            string farmUnit = inputCommands[1];
            string id = inputCommands[2];

            switch (farmUnit)
            {
                case "CherryTree": var cherryTree = new CherryTree(id);
                    this.farm.Plants.Add(cherryTree);
                    break;
                case "TobaccoPlant": var tobaccoPlant = new TobaccoPlant(id);
                    this.farm.Plants.Add(tobaccoPlant);
                    break;
                case "Cow": var cow = new Cow(id);
                    this.farm.Animals.Add(cow);
                    break;
                case "Swine": var swine = new Swine(id);
                    this.farm.Animals.Add(swine);
                    break;
                default: base.AddObjectToFarm(inputCommands);
                    break;
            }
        }

        /// <summary>
        /// The following commands should be implemented:
        /// 1. feed (animalId) (foodId) (quantity) – 
        /// feeds animal animalId with quantity of food foodId and reduces the food's quantity
        /// 2. water (plantId) – waters plant plantId
        /// 3. exploit animal/plant (animalId/plantId) – 
        /// exploits (gets the product from) an animal/plant and adds the product to the farm
        /// </summary>
        /// <param name="input"></param>
        protected override void ProcessInput(string input)
        {
            string[] commandArgs = input.Split(' ');
            string command = commandArgs[0];
            switch (command)
            {
                case "feed":
                    string animalId = commandArgs[1];
                    string foodId = commandArgs[2];
                    int quantity = int.Parse(commandArgs[3]);

                    var animal = this.GetAnimalById(animalId);
                    var food = this.GetProductById(foodId) as IEdible;
                    this.farm.Feed(animal, food, quantity);
                    break;
                case "water":
                    string plantId = commandArgs[1];

                    var plant = this.GetPlantById(plantId);
                    this.farm.Water(plant);
                    break;
                case "exploit":
                    string unitType = commandArgs[1];
                    string unitId = commandArgs[2];

                    if (unitType == "animal")
                    {
                        var typeAnimal = this.GetAnimalById(unitId);
                        this.farm.Exploit(typeAnimal);
                    }
                    else
                    {
                        var typePlant = this.GetPlantById(unitId);
                        this.farm.Exploit(typePlant);
                    }
                    break;
                default:
                    break;
            }
            base.ProcessInput(input);
        }
    }
}
