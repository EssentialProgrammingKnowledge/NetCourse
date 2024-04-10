namespace CreateAndManipulateObjects
{
    internal class Car
    {
        public string Name { get; set; }
        public int EngineCapacity { get; set; }

        public Car(string name, int engineCapacity)
        {
            Name = name;
            EngineCapacity = engineCapacity;
        }

        public override string ToString()
        {
            return $"Name: {Name}, EngineCapacity: {EngineCapacity}";
        }
    }

    internal class CarWithPrimaryConstructor(string name, int engineCapacity)
    {
        public string Name { get; set; } = name;
        public int EngineCapacity { get; set; } = engineCapacity;
        public string Color { get; set; } = "";

        public CarWithPrimaryConstructor(string name, int engineCapacity, string color)
            : this(name, engineCapacity)
        {
            Color = color;
        }

        public override string ToString()
        {
            return $"Name: {Name}, EngineCapacity: {EngineCapacity}, Color: {Color}";
        }
    }
}
