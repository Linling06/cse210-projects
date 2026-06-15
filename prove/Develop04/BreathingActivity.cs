class BreathingActivity : BaseActivity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void RunActivity()
    {
        DisplayGreeting();

        StartTimer();

        while (!HasTimerExpired())
        {
            RunCountDown("Breathe in... ", 4);
            RunCountDown("Breathe out... ", 6);
            Console.WriteLine();
        }

        DisplayEnding();
    }
}