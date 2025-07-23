using System;

class Program
{
    // ABOVE AND BEYOND MODIFICATIONS:
    // Added a file with all the scriptures as references.
    // This program will allow the user to play a game of Scripture Hangman after the initial Memorizer program, or if they quit the first program.
    // Added a lookup file section to my class.
    // The file path did not work the first time, so I moved the file to the same directory as the Program.cs file.


    static void Main(string[] args)
    {
        //Calls to the Reference in search for scripture.

        Word word = new Word();
        word.HideAllWords();

        Console.WriteLine("Would you like to play Scripture Hangman? (yes/no)");
        string response = Console.ReadLine().ToLower();
        if (response == "yes")
        {
            Hangman hangman = new Hangman();
        }
        else
        {
            Console.WriteLine("Thank you for using the Scripture Memorizer, Good Bye!");
        }
    }
    





}