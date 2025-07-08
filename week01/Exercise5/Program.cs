using System;

class Program
{
   
   static void DisplayWelcom()
    {
        Console.WriteLine("Welcome to the Program!");
    }
   static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    { 
        Console.Write("Please enter your favorite integer number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    { 
       // Console.Write("Give me a number to square: ");
       // int number = int.Parse(Console.ReadLine());
        return number * number;
    }
   
    static void DisplayResult(string name, int favoriteNumber, int number, int squaredNumber)
    {
        Console.WriteLine($"Hello {name}, your favorite number is {favoriteNumber} and your number: {number} squared is {squaredNumber}.");
    }

    static void Main(string[] args)
    {
        DisplayWelcom();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        Console.Write("Give me a number to square: ");
        int number = int.Parse(Console.ReadLine());
        int squaredNumber = SquareNumber(number);
        DisplayResult(userName, favoriteNumber, number, squaredNumber);
    }
}