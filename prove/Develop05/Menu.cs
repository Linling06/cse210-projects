using System;

public class Menu
{
    public int DisplayMenu(int score, string level)
    {
        Console.WriteLine();
        Console.WriteLine($"You have {score} points.");
        Console.WriteLine($"Current level: {level}");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");

        return int.Parse(Console.ReadLine());
    }
}
