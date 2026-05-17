using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine(" Enter a list of numbers, type 0 when finished.");
        
        do
        {
            Console.Write("Enter number: ");

            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        double sum = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }

        double average = sum / numbers.Count;
        int largest = -10;
        foreach (int number in numbers)
        {
            if (largest < number)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}.");
        Console.WriteLine($"The average is: {average}.");
        Console.WriteLine($"The largest number is: {largest}.");
    }

}