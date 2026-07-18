using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address(
            "525 South Center Street",
            "Rexburg",
            "ID",
            "USA"
        );

        Lecture lecture = new Lecture(
            "Learning Better Study Skills",
            "A lecture about how students can study more effectively.",
            "July 20, 2026",
            "6:00 PM",
            lectureAddress,
            "Brother Smith",
            120
        );

        Address receptionAddress = new Address(
            "210 College Avenue",
            "Provo",
            "UT",
            "USA"
        );

        Reception reception = new Reception(
            "New Student Welcome Reception",
            "A reception for new students to meet each other and ask questions.",
            "August 15, 2026",
            "7:00 PM",
            receptionAddress,
            "welcome@collegeevents.com"
        );

        Address outdoorAddress = new Address(
            "100 Park Road",
            "Idaho Falls",
            "ID",
            "USA"
        );

        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "Summer Picnic",
            "An outdoor picnic with food, games, and music.",
            "August 30, 2026",
            "5:30 PM",
            outdoorAddress,
            "Sunny with a light breeze"
        );

        Console.WriteLine("Lecture Event");
        Console.WriteLine();

        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("------------------------------");
        Console.WriteLine();

        Console.WriteLine("Reception Event");
        Console.WriteLine();

        Console.WriteLine("Standard Details:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("------------------------------");
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Event");
        Console.WriteLine();

        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}