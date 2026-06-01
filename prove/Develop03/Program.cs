using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding Requirements:
        // I made the program only hide words that are not already hidden.
        // This makes the memorizing practice smoother because each round hides
        // new words instead of randomly choosing words that are already hidden.

        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string scriptureText =
            "Trust in the Lord with all thine heart and lean not unto thine own understanding; " +
            "In all thy ways acknowledge him and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, scriptureText);

        string userInput = "";

        while (userInput != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetScriptureString());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type quit to finish:");

            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetScriptureString());
    }
}