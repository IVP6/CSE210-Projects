using System;
using System.IO;

class Scripture
{

    public static List<string> Scriptures = new List<string>();
    // Hold scripture text
    private string _scripture;

    public string GetScripture()
    {
        return _scripture;
    }

    // Constructor that reads from the CSV
    public Scripture(string bookName, string chapter, string verseNumber)
    {
        using (var reader = new StreamReader("week03/ScriptureMemorizer/ALLScriptures.csv"))
        {
            while (!reader.EndOfStream)
            {

                var line = reader.ReadLine();
                var firstComma = line.IndexOf(',');
                var secondComma = line.IndexOf(',', firstComma + 1);
                var thirdComma = line.IndexOf(',', secondComma + 1);

                if (firstComma == -1 || secondComma == -1 || thirdComma == -1)
                    continue; // skip malformed lines

                var book = line.Substring(0, firstComma).Trim();
                var chapterField = line.Substring(firstComma + 1, secondComma - firstComma - 1).Trim();
                var verseField = line.Substring(secondComma + 1, thirdComma - secondComma - 1).Trim();
                var scriptureText = line.Substring(thirdComma + 1).Trim();

                if (book.Equals(bookName, StringComparison.OrdinalIgnoreCase) &&
                    chapterField.Equals(chapter, StringComparison.OrdinalIgnoreCase) &&
                    verseField.Equals(verseNumber, StringComparison.OrdinalIgnoreCase))
                {
                    _scripture = scriptureText;
                    break;
                }
            }
        }
        {
            if (!string.IsNullOrEmpty(_scripture))
            {
                Scriptures.Add(_scripture);
                Console.WriteLine($"Found scripture {bookName} {chapter}: {verseNumber}\n {_scripture}");
            }
            else
            {
                Console.WriteLine("Scripture not found.");
            }
        }
    }

   // Add this method to your Scripture class

}








