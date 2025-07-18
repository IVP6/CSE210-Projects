using System.Diagnostics;
using System.Dynamic;

public class Fraction
{

    private int _top;
    private int _bottom;
    //// Constructors
    /// 
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string fractionText = $"{_top}/{_bottom}";
        return fractionText;
    }


    public double GetDecimalValue()
    {
        double value = (double)_top / (double)_bottom;
        return value;
    }
     
}