using System;

class Program
{
    static void Main(string[] args)
    {
        //output a fraction and a decimal
        Fraction first = new Fraction();
        Console.WriteLine(first.GetFractionString());
        Console.WriteLine(first.GetDecimalValue());
        //output a new instance of fraction and a decimal

        Fraction second = new Fraction(5);
        Console.WriteLine(second.GetFractionString());
        Console.WriteLine(second.GetDecimalValue());

        Fraction third = new Fraction(3, 4);
        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());

        Fraction fourth = new Fraction(1, 3);
        Console.WriteLine(fourth.GetFractionString());
        Console.WriteLine(fourth.GetDecimalValue());

    }
    
}