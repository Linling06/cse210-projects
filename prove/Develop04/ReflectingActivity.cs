class ReflectingActivity : BaseActivity
{
    private List<FlaggedString> _prompts;
    private List<FlaggedString> _questions;

    public ReflectingActivity()
        : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<FlaggedString>();
        _questions = new List<FlaggedString>();

        SetPromptsAndQuestions();
    }

    private void SetPromptsAndQuestions()
    {
        _prompts.Add(new FlaggedString("Think of a time when you stood up for someone else.", false));
        _prompts.Add(new FlaggedString("Think of a time when you did something really difficult.", false));
        _prompts.Add(new FlaggedString("Think of a time when you helped someone in need.", false));
        _prompts.Add(new FlaggedString("Think of a time when you did something truly selfless.", false));

        _questions.Add(new FlaggedString("Why was this experience meaningful to you?", false));
        _questions.Add(new FlaggedString("Have you ever done anything like this before?", false));
        _questions.Add(new FlaggedString("How did you get started?", false));
        _questions.Add(new FlaggedString("How did you feel when it was complete?", false));
        _questions.Add(new FlaggedString("What made this time different than other times when you were not as successful?", false));
        _questions.Add(new FlaggedString("What is your favorite thing about this experience?", false));
        _questions.Add(new FlaggedString("What could you learn from this experience that applies to other situations?", false));
        _questions.Add(new FlaggedString("What did you learn about yourself through this experience?", false));
        _questions.Add(new FlaggedString("How can you keep this experience in mind in the future?", false));
    }

    public void RunActivity()
    {
        DisplayGreeting();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetPromptString(_prompts)} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        RunCountDown("You may begin in: ", 5);

        StartTimer();

        while (!HasTimerExpired())
        {
            Console.WriteLine(GetPromptString(_questions));
            DisplaySpinner("", 5);
        }

        DisplayEnding();
    }
}