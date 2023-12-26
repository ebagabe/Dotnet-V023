class Car
{
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public int Year {
        get => Year;

        set
        {
            if(value < 1960 || value > 2023)
            {
                Console.WriteLine("Enter a value between 1963 and 2023");
            } else
            {
                Year = value;
            }
        }
    }
    public int PortsNumber { get; set; }
    public int Speed { get; set; }
    public string DetailedDescription => 
        $"The car was manufactured by {Manufacturer}, your model is {Model} and it was released in {Year}";

    public void ViewInformation()
    {
        Console.WriteLine(DetailedDescription);
    }

    public void SpeedUp()
    {
        Console.WriteLine("Speeding up");

        if (Speed < 100)
        {
            Speed += 5;
        }
    }

    public void Brake()
    {
        Console.WriteLine("Braking");

        if (Speed > 0)
        {
            Speed -= 5;
        }
    }

    public void Honk()
    {
        Console.WriteLine("Beep! Beep!");
    }
}