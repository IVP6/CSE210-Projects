using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello agent 007, What is your first name?");
        
            string f_name = Console.ReadLine();
        
        
            Console.WriteLine("What is your Last Name?: ");
            string l_name = Console.ReadLine();
        
        
            Console.WriteLine($" Thank you agent 007!");
            Console.WriteLine($"You shall be known as {l_name}, {f_name} {l_name}.");
        
    }
}