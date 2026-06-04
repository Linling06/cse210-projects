class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bob", "Roberts", 57, 198);
        Console.WriteLine(myPerson.GetPersonInformation());

        Police myPoliceMan = new Police("Gun", "Robert", "Bob", 43, 187);

        Console.WriteLine(myPoliceMan.GetPersonInformation());

        Doctor myDoctor = new Doctor("PhD", "Bob", "Payne", 43, 187);

        Console.WriteLine(myDoctor.GetPersonInformation());
        
        myDoctor.ChangeWeight(10);
        myPoliceMan.ChangeWeight(-11);

        Console.WriteLine(myDoctor.GetPersonInformation());
        Console.WriteLine(myPoliceMan.GetPersonInformation());
    }
}
