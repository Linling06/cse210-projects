class Doctor : Person
{
    private string _degree;

    public Doctor(string degree, string firstName,
        string lastName, int age, int weight)
        : base(firstName, lastName, age, weight)
    {
        _degree = degree;
    }

    public override string GetPersonInformation()
    {
        return $"Education: {_degree}, {base.GetPersonInformation()}";
    }

    public override double GetSalary()
    {
        return 350000.00;
    }

}