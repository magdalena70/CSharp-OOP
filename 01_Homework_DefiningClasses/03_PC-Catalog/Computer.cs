using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PC_Catalog
{
    class Computer
    {
        private string computerName;
        private decimal computerPrice;
        private Component processor;
        private Component graphicsCard;
        private Component motherboard;

        public string ComputerName
        {
            get
            {
                return this.computerName;
            }
            set
            {
                this.computerName = value;
            }
        }

        public decimal ComputerPrice
        {
            get 
            {
                return Processor.Price + GraphicsCard.Price + Motherboard.Price; 
            }
            set
            {
                this.computerPrice = value;
            }
        }

        public Component Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                this.processor = value;
            }
        }

        public Component GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                this.graphicsCard = value;
            }
        }

        public Component Motherboard
        {
            get
            {
                return this.motherboard;
            }
            set
            {
                this.motherboard = value;
            }
        }

        public Computer(
            string computerName, Component processor = null, 
            Component graphicsCard = null, Component motherboard = null)
        {
            this.ComputerName = computerName;
            this.Processor = processor;
            this.GraphicsCard = graphicsCard;
            this.Motherboard = motherboard;
        }


        public override string ToString()
        {
            StringBuilder printComputer = new StringBuilder();
            printComputer.AppendLine("Computer name: " + this.computerName);
            printComputer.AppendLine("Processor name: " + this.Processor.Name);
            printComputer.AppendLine("Processor price: " + this.Processor.Price + "lv.");
            printComputer.AppendLine("Graphic card name: " + this.GraphicsCard.Name);
            printComputer.AppendLine("Graphic card price: " + this.GraphicsCard.Price + "lv.");
            printComputer.AppendLine("Motherboard name: " + this.Motherboard.Name);
            printComputer.AppendLine("Motherboard price: " + this.Motherboard.Price + "lv.");
            printComputer.AppendLine("Computer total price: " + ComputerPrice + "lv.");
     
            return printComputer.ToString();
        }
    }


}
