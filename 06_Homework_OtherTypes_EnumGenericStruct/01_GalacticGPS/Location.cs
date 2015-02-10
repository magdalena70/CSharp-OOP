using System;

namespace _01_GalacticGPS
{
    // Create a struct Location that holds fields of type double latitude and longitude of a given location.
    public struct Location
    {
        // Add an enum field of type Planet. Encapsulate all fields.
        private double latitude;
        private double longitude;
        private Planet planet;

        // Add a constructor that holds 3 parameters: latitude, longitude and planet.
        public Location(double latitude, double longitude, Planet planet)
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public double Latitude
        {
            get
            {
                return this.latitude;
            }
            private set
            {
                this.latitude = value;
            }
        }

        public double Longitude
        {
            get
            {
                return this.longitude;
            }
            private set
            {
                this.longitude = value;
            }
        }

        public Planet Planet
        {
            get
            {
                return this.planet;
            }
            private set
            {
                this.planet = value;
            }
        }

        // Override ToString() to print the current location in the format <latitude>, <longitude> - <location>
        public override string ToString()
        {
            return String.Format("{0}, {1} - {2}",
                this.latitude, this.longitude, this.planet);
        }
    }
}
