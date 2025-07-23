using System;



public class Hangman
{
    private string _scripture;
    private string _scriptureDisplay;
    private string _hiddenScripture;
    private int _attempts;
    public Hangman()
    {
        // Start Game
        Console.Clear();
        Console.WriteLine("HANG MAN!");
        Reference reference = new Reference();
        _scripture = reference.FindText();
        _scriptureDisplay = reference.GetScriptureInfo();
        // Initialize hidden scripture with underscores
        Console.WriteLine($"{_scriptureDisplay} —  \n");
        _hiddenScripture = string.Concat(_scripture.Select(c => char.IsLetter(c) ? '_' : c));
        _attempts = 0;
        int scriptLength = _hiddenScripture.Length;

        // Start the game loop
        while (_attempts < scriptLength)
        {
            Console.WriteLine($"Attempts left: {scriptLength - _attempts}");
            Console.WriteLine($"Current scripture: {_hiddenScripture}");
            Console.WriteLine("Guess a letter:");
            string guess = Console.ReadLine().ToLower();

            if (string.IsNullOrEmpty(guess) || guess.Length != 1)
            {
                Console.WriteLine("Please enter a single letter.");
                continue;
            }

            // Check if the guess is correct
            bool correctGuess = false;
            char[] hiddenChars = _hiddenScripture.ToCharArray();
            for (int i = 0; i < _scripture.Length; i++)
            {
                if (_scripture[i].ToString().ToLower() == guess)
                {
                    _attempts++;
                    hiddenChars[i] = _scripture[i];
                    correctGuess = true;
                }
            }

            _hiddenScripture = new string(hiddenChars);

            if (!correctGuess)
            {
                _attempts++;
                Console.WriteLine($"Incorrect guess! Attempts left: {10 - _attempts}");
            }

            // Check if the scripture is fully revealed
            if (_hiddenScripture.Equals(_scripture, StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                Console.WriteLine("WINNER, WINNER, CHICKEN DINNER!\n");
                Console.WriteLine($"Congratulations! You've revealed the scripture:\n \n{_scripture}");
                Console.WriteLine(" ");
                Console.WriteLine($"Attempts used: {_attempts} \nOut of: {scriptLength}");
                break;
            }
        }
        if (_attempts >= scriptLength)
        {
            Console.Clear();
            Console.WriteLine("Sorry, you've run out of attempts.");
            Console.WriteLine($"Game over! The scripture was: {_scripture}");
        }


        // While loop to keep the game running


    }
    
}