using System;
using System.Text.Json;

class Journal
{
    List<JournalEntry> _journalEntries = new List<JournalEntry>();

    public void AddJournalEntry(JournalEntry journalEntry)
    {
        _journalEntries.Add(journalEntry);
    }

    public void DisplayJournal()
    {
        foreach (JournalEntry journalEntry in _journalEntries)
        {
            journalEntry.DisplayJournalEntry();
        }
    }

    public void SaveJournal()
    {
        try
        {
            Console.Write("What file name do you want to save? ");
            string fileName = Console.ReadLine() + ".json";

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IncludeFields = true
            };

            string jsonString = JsonSerializer.Serialize(_journalEntries, options);
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine("Journal saved successfully.");
        }
        catch
        {
            Console.WriteLine("There was a problem saving the journal.");
        }
    }

    public void LoadJournal()
    {
        try
        {
            Console.Write("What file name do you want to load? ");
            string fileName = Console.ReadLine() + ".json";

            if (File.Exists(fileName))
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    IncludeFields = true
                };

                string jsonString = File.ReadAllText(fileName);
                _journalEntries =
                    JsonSerializer.Deserialize<List<JournalEntry>>(jsonString, options)
                    ?? new List<JournalEntry>();

                Console.WriteLine("Journal loaded successfully.");
            }
            else
            {
                Console.WriteLine("That file does not exist.");
            }
        }
        catch
        {
            Console.WriteLine("There was a problem loading the journal.");
        }
    }
}