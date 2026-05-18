using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        JournalEntry myJournalEntry = new JournalEntry();
        myJournalEntry.CreateJournalEntry();
        myJournal.AddJournalEntry(myJournalEntry);

        JournalEntry myJournalEntry2 = new JournalEntry();
        myJournalEntry2.CreateJournalEntry();
        myJournal.AddJournalEntry(myJournalEntry2);

        myJournal.DisplayJournal();

        myJournal.SaveJournal();

        myJournal.LoadJournal();

        myJournal.DisplayJournal();
    }
}