using System;
using System.Collections.Generic;
using System.Linq;
// I have added a max and min output as well as a smallest positive number output.
//I have changed the average to only output 3 decimal places.
// ask user for a series of numbers
// append each one to a list
// stop when they enter 0.
List<int> numbers = new List<int>();
int num_input;


do
{
    Console.Write("Enter a series of numbers (0 to stop): ");
    string inputs = Console.ReadLine();
    num_input = int.Parse(inputs);
    
    if (num_input != 0)
    {
        numbers.Add(num_input);   
    }

    

} while (num_input != 0);
if (numbers.Count > 0)
{
    int total = numbers.Sum();
    float average = (float)numbers.Average();
    int max = numbers.Max();
    int min = numbers.Min();
    int smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty().Min();

    numbers.Sort();
    numbers.Reverse();

    Console.WriteLine($"Your total is: {total}");
    Console.WriteLine($"Your average is: {average:F3}");
    Console.WriteLine($"Your maximum is: {max}");
    Console.WriteLine($"Your minimum is: {min}");
    if (smallestPositive > 0)
        Console.WriteLine($"Your smallest positive number is: {smallestPositive}");
    else
        Console.WriteLine("There are no positive numbers.");
    Console.WriteLine("Numbers in reverse order:");
    foreach (int n in numbers)
    {
        Console.WriteLine(n);
    }
}
else
{
    Console.WriteLine("No numbers were entered.");
}