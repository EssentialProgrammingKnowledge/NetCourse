namespace SOLID
{
    public class PerimeterCalculator
    {
        public int Calculate(Shape shape)
        {
            return shape.Perimeter();
        }
    }
}
