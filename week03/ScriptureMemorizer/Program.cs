using System;

class Program
{
    // I found a csv file with all the scriptures in it on GitHub.
    // I will use this file to get the scripture text, I had problems with accessing it, so I added it to the bin folder.
    // I also have the original file int there as well.
    // My program asks the user for the book name, chapter, and verse number.
    // It then searches the csv file for the scripture and returns the text.
    // I have not yet figured out how to work the input side to cross reference differen book inputs, for example
    // if the user inputs D&C instead of Doctrine and Covenants, it will not find the scripture. So I replaced the text for this project.


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