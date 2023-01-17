namespace Polymorphism
{
    public abstract class Vehicle
    {
        public void Run()
        {
            Console.WriteLine("Implementation");
            Prepare();
        }

        public abstract void Prepare();
    }
}
