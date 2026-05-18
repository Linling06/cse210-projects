using System;

class Program
{

    void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    string PromptUserName()
    {
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();
        return name;
    }

    int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number:");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    void PromtUserBirthYear(out int year)
    {
        Console.WriteLine("Please enter the year you were born: ");
        int year = int.Parse(Console.ReadLine());
    }

    static void Main(string[] args)
    {
        int year;
        Console.WriteLine("Hello Prep5 World!");
    }
}