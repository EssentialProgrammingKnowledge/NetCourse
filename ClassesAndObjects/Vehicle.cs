public class Vehicle
{
    public string Name { get; set; } = "";
    public int EngineCapacity { get; set; }
    public string Color { get; set; } = "White";
    public int Sound { get; private set; } = 0;

    public Vehicle() { }

    public Vehicle(string name, int engineCapacity) 
    {
        Name = name;
        EngineCapacity = engineCapacity;
    }

    public void Start()
    {
        Sound = 100;
    }

    public void Stop()
    {
        Sound = 0;
    }

    public override string ToString()
    {
        return $"Name {Name}, EngineCapacity {EngineCapacity}, Color {Color}, Sound {Sound}";
    }
}