using System;

class Program
{
    static void Main(string[] args)
    {
        //base object creation
        Assignment a1 = new Assignment("John Doe", "Addition");
        Console.WriteLine(a1.GetSummary());

        // create WritingAssignment object
        WritingAssignment w1 = new WritingAssignment("Jane Smith", "History", "The Rise and Fall of Empires");
        Console.WriteLine(w1.GetWritingInformation());
        // create MathAssignment object
        MathAssignment m1 = new MathAssignment("Alice Johnson", "Algebra", "Chapter 5", "1-10");
        Console.WriteLine(m1.GetHomeworkList());

    }
}