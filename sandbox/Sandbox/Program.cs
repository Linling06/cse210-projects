using System;
using System.ComponentModel;
using System.Security.Authentication.ExtendedProtection;

class Program
{


    static void DisplayGreeting()
    {
        Console.WriteLine("Hello Betty");
    }

    static double AddNumbers(int n1, int n2, double n3)
    {
        double total = n1 + n2 + n3;
        return total;
    }
    static void Main(string[] args)
    {
        DisplayGreeting();
        double total = AddNumbers(10, 20, 1001.234);
        Console.Write(total);

        // This is a super duper cool comment.
        // another comment
        // Console.WriteLine("Hello Sandbox World!");

        // int x = 10;

        // if (x == 11)
        // {
        //     Console.WriteLine("Hey Bob");
        //     Console.WriteLine("Hey Betty");
        // }

        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // int age = -1;

        // while (age < 0 || age > 125)
        // {
        //     Console.WriteLine("Please enter the age: ");
        //     age = int.Parse(Console.ReadLine());
        // }

        // int age2;
        // do
        // {
        //     Console.WriteLine("Please enter the age: ");
        //     age2 = int.Parse(Console.ReadLine());
        // } while (age2 < 0 || age2 > 125);

        // string myString = "The quick brown fox jumps over the lazy dog.";
        // char myLetter = 'A';

        // for(int i = 0; i <= 32; ++i)
        // {
        //     int powerNumber = (int)Math.Pow(2, i);
        //     Console.Write($"2 to the power of {i},  is {powerNumber}");
        //     Console.WriteLine($", 0x{powerNumber.ToString("X")}");
        // }

        // List<int> myData = new List<int> ();
        // myData.Add(1);
        // myData.Add(2);
        // myData.Add(3);
        // myData.Add(4);
        // myData.Add(5);
        // myData.Add(99);
        // myData.Add(-100);
        // foreach(int i in myData)
        // {
        //     Console.WriteLine(i);
        // }
        
    }
}