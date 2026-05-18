using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("Choose: ");

            int.TryParse(Console.ReadLine(), out choice);

            if (choice == 1)
            {
                JournalEntry entry = new JournalEntry();

                entry.CreateJournalEntry();

                myJournal.AddJournalEntry(entry);
            }

            else if (choice == 2)
            {
                myJournal.DisplayJournal();
            }

            else if (choice == 3)
            {
                myJournal.LoadJournal();
            }

            else if (choice == 4)
            {
                myJournal.SaveJournal();
            }

            else if (choice == 5)
            {
                Console.WriteLine("Goodbye");
            }

            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }
}