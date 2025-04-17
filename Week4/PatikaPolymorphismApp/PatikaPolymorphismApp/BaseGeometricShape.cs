namespace PatikaPolymorphismApp
{
    public class BaseGeometricShape
    {
        // Properties
        public int Width {  get; set; }
        public int Height { get; set; }

        // Methods
        public virtual void CalculateArea()
        {
            Console.WriteLine($"Area calculated");
        }
    }

    public class Square : BaseGeometricShape
    {
        // Constructor
        public Square(int width) 
        {
            Width = width;
        }

        // Methods
        public override void CalculateArea() 
        {
            Console.WriteLine($"Area: {Width*Width}");
        }
    }

    public class Rectangle : BaseGeometricShape 
    {
        // Constructor
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        // Methods
        public override void CalculateArea()
        {
            Console.WriteLine($"Area: {Width*Height}");
        }
    }

    public class RightTriangle : BaseGeometricShape
    {
        // Constructor
        public RightTriangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        // Methods
        public override void CalculateArea()
        {
            Console.WriteLine($"Area: {(Width * Height)/2}");
        }
    }
}
