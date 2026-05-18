using System;

class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    private string[] _prompts =
    {
        "How are you feeling today?",
        "Who did you talk with today?",
        "What was the best part of your day?",
        "What did you learn today?",
        "What are you grateful for today?"
    };

    public void CreateJournalEntry()
    {
        _date = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

        Random random = new Random();
        int index = random.Next(_prompts.Length);

        _prompt = _prompts[index];

        Console.WriteLine(_prompt);
        Console.Write("> ");
        _response = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(_response))
        {
            _response = "No response entered.";
        }
    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }
}