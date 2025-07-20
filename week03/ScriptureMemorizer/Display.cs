using System;
using System.Data;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

class Display
{
    private string _scripture;
    private string _scriptureInfo;

    public Display()
    {
        // Get scripture from (SC)
        Reference reference = new Reference();
        _scripture = reference.FindText();
        _scriptureInfo = reference.GetScriptureInfo();
    }

    // organize scripture and call Reference to hide random words
    public void HideAllWords()
    {


        Random random = new Random();
        string[] wordsToHide = _scripture.Split(' ');

        int wordsLeft = wordsToHide.Count(w => w != "____");
        while (wordsLeft > 0)

        {
            
            Console.Clear();

            int randomIndex = random.Next(wordsToHide.Length);
            if (wordsToHide[randomIndex] != "____")
            {
                wordsToHide[randomIndex] = "____";
                wordsLeft--;
                Console.WriteLine(_scriptureInfo);
                Console.WriteLine(string.Join(" ", wordsToHide));
                Console.WriteLine("Press Enter to continue, or quit to exit...");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    Console.Clear();
                    Console.WriteLine("Exiting...");
                    return;
                }
            }
        }
        Console.WriteLine("All words have been hidden! \n");
        Console.WriteLine("Did you memorize the scripture? \n");
        Console.WriteLine(_scriptureInfo);
        Console.WriteLine(_scripture + "\n");
    }
}
    
