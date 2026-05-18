// Exceeding Requirements:

// I prompt the user for the journal name to save the file and save it in a
// JSON format; this will make the program more user-friendly and make sure the
// data is more structured. I also did a lot of crash prevention to make the
// program more stable.


using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize a journal.
        Journal journal = new Journal();

        // Welcome message.
        Console.WriteLine("Welcome to the Journal Program!");
        
        // Program loop.
        int menuNumber;
        do
        {
            menuNumber = GetMenuNumber();
            switch (menuNumber)
            {
                case 1:
                    journal.Write();
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3:
                    journal.LoadEntries();
                    break;
                case 4:
                    journal.SaveEntries();
                    break;
            }
        } while (menuNumber != 5);

        // Goodbye message.
        Console.WriteLine("Goodbye!");
    }

    static int GetMenuNumber()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int userNumber) && userNumber is >=1 and <= 5)
            {
                return userNumber;
            }
            else
            {
                Console.Write("That's not a valid input, please try again: ");
            }
        }
    }

}