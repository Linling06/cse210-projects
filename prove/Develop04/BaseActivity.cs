using System;
using System.Threading;

class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endTime;

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void DisplayGreeting()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");

        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner("", 3);
    }

    public void DisplayEnding()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        DisplaySpinner("", 3);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        DisplaySpinner("", 3);
    }

    public void RunCountDown(string message, int seconds)
    {
        Console.Write(message);

        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();
    }

    public void DisplaySpinner(string message, int seconds)
    {
        Console.Write(message);

        List<string> animations = new List<string>();
        animations.Add("|");
        animations.Add("/");
        animations.Add("-");
        animations.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animations[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= animations.Count)
            {
                i = 0;
            }
        }

        Console.WriteLine();
    }

    public void StartTimer()
    {
        DateTime startTime = DateTime.Now;
        _endTime = startTime.AddSeconds(_duration);
    }

    public bool HasTimerExpired()
    {
        DateTime currentTime = DateTime.Now;

        if (currentTime >= _endTime)
        {
            return true;
        }

        return false;
    }

    public string GetPromptString(List<FlaggedString> prompts)
    {
        Random random = new Random();

        bool allUsed = true;

        foreach (FlaggedString prompt in prompts)
        {
            if (!prompt.GetHasBeenUsed())
            {
                allUsed = false;
            }
        }

        if (allUsed)
        {
            foreach (FlaggedString prompt in prompts)
            {
                prompt.ResetHasBeenUsed();
            }
        }

        bool foundPrompt = false;
        string promptText = "";

        while (!foundPrompt)
        {
            int index = random.Next(prompts.Count);

            if (!prompts[index].GetHasBeenUsed())
            {
                promptText = prompts[index].GetPrompt();
                prompts[index].SetHasBeenUsed();
                foundPrompt = true;
            }
        }

        return promptText;
    }
}