using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        JournalEntry myJournalEntry = new JournalEntry();
        myJournalEntry.CreateJournalEntry();
        // myJournalEntry.DisplayJournalEntry();
        // Console.WriteLine(myJournalEntry.CreateFileSystemString());
        JournalEntry myJournalEntry2 = new JournalEntry();
        myJournalEntry2.CreateJournalEntry();

        Journal myJournal = new Journal();
        myJournal.AddJournalEntry(myJournalEntry);
        myJournal.AddJournalEntry(myJournalEntry2);

        myJournal.DisplayJournal();
    }
}