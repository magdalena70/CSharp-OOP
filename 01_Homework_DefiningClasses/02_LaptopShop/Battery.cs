using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LaptopShop
{
    class Battery
    {
        //fields
        private double batteryLife;
        private string batteryDescription;

        //properties
        public double BatteryLife
        {
            get 
            { 
                return this.batteryLife; 
            }
            set
            {
                if (value < 0.0d)
                {
                    throw new ArgumentException("Battery Life cannot be negative value.");
                }
                this.batteryLife = value;
            }
        }

        public string BatteryDescription
        {
            get 
            { 
                return this.batteryDescription;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Battery description cannot be empty.");
                }
                this.batteryDescription = value;
            }
        }

        //constructor
        public Battery(string batteryDescription, double batteryLife)
        {
            this.BatteryDescription = batteryDescription;
            this.BatteryLife = batteryLife;
        }
    }
}
