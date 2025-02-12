using ConsoleApp.ClassesDemo.Interfaces;

namespace ConsoleApp.ClassesDemo
{
    public class Rectangle : Polygon, I2DShape
    {
        public Rectangle(int width, int length)
        {
            Length = length;
            Width = width;
        }
        public int Length { get; set; }
        public override double Area()
        {
            return Length * Width;
        }

        public double Perimeter()
        {
            return (2 * Length) + (2 * Width);
        }

        public override string GetShapeName()
        {
            return base.GetShapeName();
        }
    }
}
