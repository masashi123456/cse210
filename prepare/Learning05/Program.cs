using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {   
        List<Shape> shape = new List<Shape>();

        Square square = new Square("Blue", 4);
        shape.Add(square);

        Rectangle rectangle = new Rectangle("Yellow", 5, 6);
        shape.Add(rectangle);

        Circle circle = new Circle("red", 3);
        shape.Add(circle);

        foreach (Shape s in shape){
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color}shape has {area}.");
        }

    }

}