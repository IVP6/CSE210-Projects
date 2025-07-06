using System;

class Program
{
    static void Main(string[] args)
    {
        int rand_number = new Random().Next(1, 101);
        int guess;
        int attempts = 0;

        do
        {
            Console.WriteLine($"Guess a number between 1 and 100:");
            guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess < rand_number)
            {
                Console.WriteLine("Too low! \nGuess Higher.");
            }
            else if (guess > rand_number)
            {
                Console.WriteLine("Too high! \nGuess Lower.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the magic number!");
            }
        } while (guess != rand_number);

        Console.WriteLine($"Thank you for playing! You guessed it in {attempts} attempts.");
        Console.Write("Would you like to play again? (yes/no): ");
        string response = Console.ReadLine().ToLower();

        if (response == "yes" || response == "y")
        {
            // Restart the game
            Main(args);
        }
        else
        {
            Console.WriteLine("Thank you for playing, Goodbye!");
        }
    }
}