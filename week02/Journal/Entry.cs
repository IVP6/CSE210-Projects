using System;
using System.Collections.Generic;
using System.IO;    


namespace Week02.Journal
{
    public class Entry
    {
        public string _date = DateTime.Now.ToString("MM.dd.yyyy HH:mm");
        public string _promptText = new PromptGenerator().GetRandomPrompt();
        public string _entryText;






        public void Display()
        {
            Console.WriteLine($"Star Date Log: {_date}");
            Console.WriteLine($"Something to write about: {_promptText}");

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Your Entry: {_entryText}");
        }

    }
}    