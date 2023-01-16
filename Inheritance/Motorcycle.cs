namespace Inheritance
{
    public class Motorcycle : Vehicle
    {
        

        public Motorcycle(string name, int engineCapacity) : base(name, engineCapacity)
        {
            vin = 100;
        }

        public override void Start()
        {
            Sound = 40;
        }

        public void SetColor(string color)
        {
            Color = color;
        }
    }
}
