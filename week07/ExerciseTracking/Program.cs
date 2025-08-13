using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Running
        Running run = new Running("Morning Run", DateTime.Now, 30.00, 3.00);
        Console.WriteLine(run.GetSummary());

        // Create an instance of Cycling
        Cycling cycle = new Cycling("Stationary Bicycling", DateTime.Now, 45.00, 10.00);
        Console.WriteLine(cycle.GetSummary());

        // Create an instance of Swimming
        Swimming swim = new Swimming("Pool Session", DateTime.Now, 60.00, 20);
        Console.WriteLine(swim.GetSummary());

    }
}