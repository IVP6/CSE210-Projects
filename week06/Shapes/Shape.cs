using System;
using System.Dynamic;



public class Shapes
{
    public string _color;
    public Shapes() { }
    public string GetColor() { return _color; }
    public void SetColor(string color) { _color = color; }
    public virtual double GetArea()
    {
        return 0.0; // Default implementation, can be overridden
    }
}