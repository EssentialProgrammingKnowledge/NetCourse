namespace Inheritance
{
    public class Car : Vehicle
    {
        public Car(string name, int engineCapacity) : base(name, engineCapacity)
        {
            vin = 10;
        }

        public override void Start()
        {
            Sound = 150;
            for(int i = 0; i < 10000; i++)
            {
            }
            base.Start();
        }

        public override void Stop()
        {
            base.Stop();
        }

        public void SetColor(string color)
        {
            if (color == "Grey")
            {
                return;
            }
            Color = color;
        }
    }
}
