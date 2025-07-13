using System;




namespace Week02.Journal
{
    public class Journal
    {
        public List<Entry> _entries;
        public Journal()
        {
            _entries = new List<Entry>();
        }
        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        
        }

        public void DisplayAll()
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
                Console.WriteLine("----------------------------------");
            }
        }

        public void SaveToFile(string file)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"Date: {entry._date}");
                    writer.WriteLine($"Prompt: {entry._promptText}");
                    writer.WriteLine($"Entry: {entry._entryText}");
                    writer.WriteLine("----------------------------------");
                }
            }
            Console.WriteLine($"Journal saved to {file}");

        }

        public void LoadFromFile(string file)
        {
            if (!File.Exists(file))
            {
                Console.WriteLine($"File '{file}' does not exist.");
                return;
            }

            using (StreamReader reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    string dateLine = reader.ReadLine();
                    string promptLine = reader.ReadLine();
                    string entryLine = reader.ReadLine();
                    string separatorLine = reader.ReadLine(); // skip separator line

                    if (dateLine != null && promptLine != null && entryLine != null)
                    {
                        string date = dateLine.Length > 6 ? dateLine.Substring(6) : "";
                        string prompt = promptLine.Length > 8 ? promptLine.Substring(8) : "";
                        string text = entryLine.Length > 7 ? entryLine.Substring(7) : "";

                        // Check if this entry already exists in memory
                        bool duplicateFound = false;
                        foreach (Entry existing in _entries)
                        {
                            if (existing._date == date && existing._promptText == prompt && existing._entryText == text)
                            {
                                duplicateFound = true;
                                break;
                            }
                        }

                        if (!duplicateFound)
                        {
                            Entry entry = new Entry();
                            entry._date = date;
                            entry._promptText = prompt;
                            entry._entryText = text;

                            _entries.Add(entry);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Warning: Skipping a malformed entry.");
                    }
                }
            }

            Console.WriteLine($"Journal loaded from '{file}' with {_entries.Count} unique entries.");
        }

        public void RemoveEntry(int index)
        { 


            
        }
    }
}
    
