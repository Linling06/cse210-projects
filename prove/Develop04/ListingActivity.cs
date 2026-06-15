class ListingActivity : BaseActivity
{
    private List<FlaggedString> _prompts;

    public ListingActivity()
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<FlaggedString>();

        SetPrompts();
    }

    private void SetPrompts()
    {
        _prompts.Add(new FlaggedString("Who are people that you appreciate?", false));
        _prompts.Add(new FlaggedString("What are personal strengths of yours?", false));
        _prompts.Add(new FlaggedString("Who are people that you have helped this week?", false));
        _prompts.Add(new FlaggedString("When have you felt the Holy Ghost this month?", false));
        _prompts.Add(new FlaggedString("Who are some of your personal heroes?", false));
    }

    public void RunActivity()
    {
        DisplayGreeting();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetPromptString(_prompts)} ---");
        Console.WriteLine();

        RunCountDown("You may begin in: ", 5);

        StartTimer();

        int count = 0;

        while (!HasTimerExpired())
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {count} items.");

        DisplayEnding();
    }
}