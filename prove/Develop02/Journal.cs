using System.Text.Json;

class Journal
{
    List<Entry> _entries = new List<Entry>();
    public void Write()
    {
        string prompt = PromptGenerator.GetPrompt();
        Console.WriteLine(prompt);

        // Prompt the user for their answer.
        Console.Write("> ");
        string answer = Console.ReadLine();

        // Add the entry.
        _entries.Add(new Entry(prompt, answer));
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.DisplayEntry());
            Console.WriteLine();
        }
    }

    public void LoadEntries()
    {
        Console.Write("What is the journal name? ");
        string dataPath = Console.ReadLine() + ".json";

        if (File.Exists(dataPath))
        {
            _entries = JsonSerializer.Deserialize<List<Entry>>(File.ReadAllText(dataPath)) ?? new List<Entry>();
            Console.WriteLine($"Journal loaded successfully!");
        }
        else
        {
            Console.WriteLine("That journal does not exist.");
        }
    }

    public void SaveEntries()
    {
        Console.Write("What is the journal name? ");
        string dataPath = Console.ReadLine() + ".json";

        File.WriteAllText(
            dataPath,
            JsonSerializer.Serialize(
                _entries,
                new JsonSerializerOptions { WriteIndented = true }
            )
        );

        Console.WriteLine("Journal saved successfully!");
    }
}