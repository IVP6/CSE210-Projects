using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        // Example usage of the shapes
        Circle circle = new Circle(5);
        Console.WriteLine($"Circle Area: {circle.GetArea():F3}");

        Square square = new Square(4);
        Console.WriteLine($"Square Area: {square.GetArea()}");

        Rectangle rectangle = new Rectangle(3, 6);
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
    }
}