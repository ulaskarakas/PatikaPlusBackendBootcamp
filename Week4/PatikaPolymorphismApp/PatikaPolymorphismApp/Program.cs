using PatikaPolymorphismApp;

internal class Program
{
    static void Main(string[] args)
    {
        BaseGeometricShape shapeSquare = new Square(5);
        BaseGeometricShape shapeRectangle = new Rectangle(5, 3);
        BaseGeometricShape shapeRightTriangle = new RightTriangle(5, 12);

        shapeSquare.CalculateArea();
        shapeRectangle.CalculateArea();
        shapeRightTriangle.CalculateArea();
    }
}