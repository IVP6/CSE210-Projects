using System;
using System.ComponentModel.DataAnnotations;
using System.IO;


namespace Week02.Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nMain Menu, please select an option:");
                Console.WriteLine("1. Write in your Journal");
                Console.WriteLine("2. Delete Entry");
                Console.WriteLine("3. Display All Entries");
                Console.WriteLine("4. Save to File");
                Console.WriteLine("5. Load from File");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Please enter a number between 1 and 6.");
                    continue; // skip back to the menu
                }

                switch (choice)
                {
                    case 1:
                        Entry entry = new Entry();
                        entry.Display();
                        entry._entryText = Console.ReadLine();
                        journal.AddEntry(entry); // cleaner than accessing _entries
                        break;

                    case 2:
                        Console.Write("Enter entry number to delete: ");
                        
                        if (int.TryParse(Console.ReadLine(), out int index))
                            journal.RemoveEntry(index);
                        else
                            Console.WriteLine("Invalid number.");
                        break;

                    case 3:
                        journal.DisplayAll();
                        break;

                    case 4:
                        Console.Write("What would you like to call your Journal?: ");
                        string journalName = Console.ReadLine();
                        journal.SaveToFile(journalName + ".txt");
                        break;

                    case 5:
                        string directoryPath = Directory.GetCurrentDirectory();
                        string[] files = Directory.GetFiles(directoryPath, "*.txt");

                        Console.WriteLine("\nSaved Journal Files:");
                        foreach (string file in files)
                        {
                            Console.WriteLine(Path.GetFileName(file));
                        }
                        Console.Write("Enter filename to load: ");
                        string fileName = Console.ReadLine();
                        journal.LoadFromFile(fileName);
                        break;

                    case 6:
                        Console.WriteLine("Exiting the program.");
                        running = false; // end the loop
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
            
            
        }
    }
}    