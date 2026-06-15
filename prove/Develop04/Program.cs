using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity:
        // I used a FlaggedString class to track which prompts and questions have already been used.
        // The program does not repeat prompts or questions until all of them have been used once.

        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity activity = new BreathingActivity();
                activity.RunActivity();
            }
            else if (choice == 2)
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.RunActivity();
            }
            else if (choice == 3)
            {
                ListingActivity activity = new ListingActivity();
                activity.RunActivity();
            }
        }
    }
}