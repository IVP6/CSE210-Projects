using System;

Console.Write("Enter your grade percentage:");
string user_input = Console.ReadLine();
int grade = int.Parse(user_input);


int a = 90;
int b = 80;
int c = 70;
int d = 60;

if (grade > 100 || grade < 0)
{
    Console.WriteLine("Wrong input.");
}
else if (grade >= a)
{
    string ltr_Grade = "A";
    if (grade >= 93 && grade < 97)
    {
        ltr_Grade = "A-";
    }
    else if (grade >= 97)
    {
        ltr_Grade = "A+";
     }

    Console.Write("Congratulations! you have passed the class,");
    Console.WriteLine($"Your letter grade is: {ltr_Grade}");

}
else if (grade >= b)
{
    string ltr_Grade = "B";
    if (grade >= 83 && grade < 87)
    {
        ltr_Grade = "B-";
    }
    else if (grade >= 87 && grade < 90)
    {
        ltr_Grade = "B+";
     }
    Console.Write("Congratulations! you have passed the class,");
    Console.WriteLine($"Your letter grade is: {ltr_Grade}");

}
else if (grade >= c)
{
    string ltr_Grade = "C";
    if (grade >= 73 && grade < 77)
    {
        ltr_Grade = "C-";
    }
    else if (grade >= 77 && grade < 80)
    {
        ltr_Grade = "C+";
     }
    Console.Write("Congratulations! you have passed the class,");
    Console.WriteLine($"Your letter grade is: {ltr_Grade}");

}
else if (grade >= d)
{
    string ltr_Grade = "D";
    if (grade >= 63 && grade < 67)
    {
        ltr_Grade = "D-";
    }
    else if (grade >= 67 && grade < 70)
    {
        ltr_Grade = "D+";
     }
    Console.WriteLine("Studying in quiet places and taking strategic breaks increase retention.");
    Console.Write("Unfortunately you did not get a 'C' to pass, ");
    Console.WriteLine($"your letter grade is: {ltr_Grade}");
}
