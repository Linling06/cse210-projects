class Program
{
    public static void DisplayPersonInformation(Person person)
    {
        // if(person is Doctor doctor)
        //     Console.WriteLine(doctor.GetPersonInformation());
        // else if (person is Police police)
        //     Console.WriteLine(police.GetPoliceManInformation());
        // else
        Console.WriteLine(person.GetPersonInformation());

    }

    public static void Main(string[] args)
    {
        // Person myPerson = new Person("Bob", "Roberts", 57, 198);
        // Console.WriteLine(myPerson.GetPersonInformation());

        Police myPoliceMan = new Police("Gun", "Robert", "Bob", 43, 187);

        // Console.WriteLine(myPoliceMan.GetPersonInformation());

        Doctor myDoctor = new Doctor("PhD", "Bob", "Payne", 43, 187);

        // Console.WriteLine(myDoctor.GetPersonInformation());

        // myDoctor.ChangeWeight(10);
        // myPoliceMan.ChangeWeight(-11);

        // Console.WriteLine(myDoctor.GetPersonInformation());
        // Console.WriteLine(myPoliceMan.GetPersonInformation());


        List<Person> myPeople = new List<Person>();
        // myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPoliceMan);

        foreach (Person person in myPeople)
        {
            // Console.WriteLine(person.GetPersonInformation());
            DisplayPersonInformation(person);
            Console.WriteLine(person.GetSalary());
        }
    }
}
