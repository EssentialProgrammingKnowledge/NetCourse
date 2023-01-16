namespace Inheritance;

public class Vehicle
{
    public string Name { get; set; } = "";
    public int EngineCapacity { get; set; }
    public string Color { get; set; } = "White";
    public int Sound { get; protected set; } = 0;
    protected int vin = 0;

    public Vehicle(string name, int engineCapacity) 
    {
        Name = name;
        EngineCapacity = engineCapacity;
    }

    public virtual void Start()
    {
        Sound = 50;
    }

    public virtual void Stop()
    {
        Sound = 0;
    }

    public override string ToString()
    {
        return $"Name {Name}, EngineCapacity {EngineCapacity}, Color {Color}, Sound {Sound}";
    }
}