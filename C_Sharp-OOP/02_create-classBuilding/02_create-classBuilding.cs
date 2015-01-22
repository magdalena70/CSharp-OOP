using System;

public class Building // class declaration
{
    //fields -> (if use auto property do not write fields)
    private string address;
    private int floors;
    private double size;

    //properties ->

    //public string Address { get; set; } -> auto property = fields + property
    public string Address // handmade property -> have to write fields before
    {
        get
        {
            return this.address;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Address cannot be empty");
            }
            else
            {
                this.address = value;
            }
        }
    }
    //public int Floors { get; private set; } -> auto property
    public int Floors // handmade property
    {
        get
        {
            return this.floors;
        }
    }
    //public double Size { get; private set; } -> auto property
    public double Size // handmade property
    {
        get
        {
            return this.size;
        }
    }
    //dinamic property -> (has no field about it)
    public double Length
    {
        get
        {
            return this.floors * this.size;
        }
    }
    //readonly property ->
    //public readonly double Length;


    //constructor 1 -> (if use auto property have to uppercase -> this.Address) ->
    public Building(string address, int floors, double size) // by 3 parametres
    {
        this.address = address;
        this.floors = floors;
        this.size = size;
        //this.Length = this.floors * this.size; // the value can not change after,becouse is readonly
    }

    //constructor 2 ->
    public Building(string address)
        : this(address, 0, 0.0) // only by address
    {
    }

    //toString ->
    public override string ToString()
    {
        return String.Format("Address: {0}, Floors: {1}, Size: {2}",
            this.address, this.floors, this.size);
    }
}

public class PlayWithBuildings
{
    //create new building ->
    static void Main()
    {
        Building softUni = new Building("15-17 Tintyava", 3, 1200.20);
        Building parkHotelMoscow = new Building("bul.Bulgaria", 14, 3200.00);

        softUni.Address = "new address"; // change address by setter in property Address
        Console.WriteLine(softUni);
        Console.WriteLine(parkHotelMoscow);

        Building pancharevo = new Building("Pancharewo");

        Console.WriteLine(pancharevo);
    }
}

