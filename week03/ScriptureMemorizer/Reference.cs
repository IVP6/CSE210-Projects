using System;
using System.Reflection;
using System.Globalization;
class Reference
{
    private string _bookName;
    private string _chapter;
    private string _verseNumber;

    // constructor to get scripture
    public string FindText()
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!\n");

        Console.WriteLine("Let's start with the Book Name (i.e. 1 Nephi, for Doctrine and Covenants, use D&C):");
        _bookName = Console.ReadLine();
        _bookName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_bookName.ToLower());

        Console.WriteLine("What is the Chapter number?:");
        _chapter = Console.ReadLine();

        Console.WriteLine("What is the verse number?:");
        _verseNumber = Console.ReadLine();

        // You can now do something with _bookName, _chapter, and _verseNumber
        Console.WriteLine($"Searching for {_bookName} {_chapter}:{_verseNumber}...");

        Scripture scripture = new Scripture(_bookName, _chapter, _verseNumber);


        // This variable will hold the scripture text.
        string foundScripture = scripture.GetScripture();
        return foundScripture;


    }

    public string GetScriptureInfo()
    {
        return $"{_bookName} {_chapter}:{_verseNumber} \n";
    }


    




}