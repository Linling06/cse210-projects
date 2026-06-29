public class SimpleGoal : BaseGoal
{
    public SimpleGoal()
        : base("", "", 0, false, "SimpleGoal")
    {
    }

    public SimpleGoal(
        string name,
        string description,
        int points,
        bool status)
        : base(name, description, points, status, "SimpleGoal")
    {
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetPoints();
    }

    public override int RecordEvent()
    {
        if (GetStatus())
        {
            return 0;
        }

        return MarkComplete();
    }
}
