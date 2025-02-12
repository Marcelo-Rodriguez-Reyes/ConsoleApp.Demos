namespace ConsoleApp.ClassesDemo
{
    public class Triangle : Polygon
    {
        public Triangle(int height, int @base)
        {
            Height = height;
            Base = @base;
        }
        public int Height { get; set; }
        public int Base { get; set; }
        public override double Area()
        {
            return (Height * Base) / 2;
        }
    }
}
