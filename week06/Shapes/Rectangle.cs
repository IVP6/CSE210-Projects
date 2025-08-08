using System;

public class Rectangle : Shapes
{
    private double _width;
    private double _length;

    public Rectangle(double width, double length)
    {
        _width = width;
        _length = length;
    }

    public override double GetArea()
    {
        return _width * _length; // Area of a rectangle is width * length
    }
}
