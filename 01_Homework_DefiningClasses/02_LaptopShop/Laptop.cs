using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LaptopShop
{
    //Define a class Laptop that holds the following information about a laptop device: 
    //model, manufacturer, processor, RAM, graphics card, HDD, screen, battery, battery life in hours and price.
    class Laptop
    {
        //fields
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hDD;
        private string screen;
        private decimal price;
        //Define two separate classes: a class Laptop holding an instance of class Battery.
        private Battery batteryModel;

        //Put validation in all property setters and constructors. 
        //String values cannot be empty, and numeric data cannot be negative. 
        //Throw exceptions when improper data is entered.
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model's value cannot be empty.");
                }
                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
               if (value < 0.0m){
                   throw new ArgumentException("Numeric data cannot be negative.");
               }
               this.price = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Manufacturer's value cannot be empty.");
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set 
            {
                if (value == "")
                {
                    throw new ArgumentException("Processor's value cannot be empty.");
                }
                this.processor = value;
            }
        }

        public string Ram
        {
            get { return this.ram; }
            set 
            {
                if (value == "")
                {
                    throw new ArgumentException("RAM cannot be empty.");
                }
                this.ram = value; 
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set 
            {
                if (value == "")
                {
                    throw new ArgumentException("Graphics Card cannot be empty.");
                }
                this.graphicsCard = value; 
            }
        }

        public string HDD
        {
            get { return this.hDD; }
            set 
            {
                if (value == "")
                {
                    throw new ArgumentException("Graphics Card cannot be empty.");
                }
                this.hDD = value; 
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set 
            {
                if (value == "")
                {
                    throw new ArgumentException("Graphics Card cannot be empty.");
                }
                this.screen = value; 
            }
        }

        public Battery BatteryModel
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }
        }

        //The model and price are mandatory. All other values are optional.
        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
            
        }

        public Laptop(string model, decimal price, Battery batteryModel)
            :this(model, price)
        {
            this.BatteryModel = batteryModel;
        }

        public Laptop(string model, decimal price, Battery batteryModel, string manufacturer = null,
                    string processor = null, string ram = null, string graphicsCard = null,
                    string hDD = null, string screen = null)
            :this(model, price, batteryModel)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.HDD = hDD;
            this.Screen = screen;
        }

        //Add a method in the Laptop class that displays information about the given instance.
        public override string ToString()
        {
            string laptopDescr = String.Format("Sample laptop description (mandatory properties only):\r\n"+
                "model: {0} \r\nprice: {1:f2}lv.\r\n",
                this.Model, this.Price);
            if (this.BatteryModel != null)
            {
                laptopDescr = String.Format("Sample laptop description (mandatory properties + battery):\r\n" +
                    "model: {0} \r\nprice: {1:f2} lv. \r\nbattery: {2} \r\nbattery life: {3} hours\r\n",
                    this.Model, this.Price, this.BatteryModel.BatteryDescription, this.BatteryModel.BatteryLife);
            }
            if (!string.IsNullOrEmpty(this.Manufacturer) &&
                !string.IsNullOrEmpty(this.Processor) &&
                !string.IsNullOrEmpty(this.Ram) &&
                !string.IsNullOrEmpty(this.GraphicsCard) &&
                !string.IsNullOrEmpty(this.HDD) &&
                !string.IsNullOrEmpty(this.Screen))
            {
                laptopDescr = String.Format("Sample laptop description (full):\r\n" +
                    "model: {0} \r\nmanufacturer: {1} \r\nprocessor: {2} \r\nRAM: {3}\r\n"+
                    "grphics card: {4}\r\nHDD: {5}\r\nscreen: {6}\r\n"+
                    "battery: {7} \r\nbattery life: {8} hours \r\nprice: {9:f2}lv.\r\n\r\n",
                    this.Model, this.Manufacturer, this.Processor, this.Ram, 
                    this.GraphicsCard, this.HDD, this.Screen,
                    this.BatteryModel.BatteryDescription, this.BatteryModel.BatteryLife, this.Price);
            }

            return laptopDescr;
        }
    }
}
