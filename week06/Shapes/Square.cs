using System;

public class Square : Shapes
{
    private double _side;
    public Square(double side)
    {
        _side = side;
    }
    public override double GetArea()
    {
        return _side * _side; // Area of a square is side^2
    }
}


