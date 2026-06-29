public class EternalGoal : BaseGoal
{
    private int _numberOfCompletions;

    public EternalGoal()
        : base("", "", 0, false, "EternalGoal")
    {
        _numberOfCompletions = 0;
    }

    public EternalGoal(
        string name,
        string description,
        int points,
        bool status,
        int completions)
        : base(name, description, points, status, "EternalGoal")
    {
        _numberOfCompletions = completions;
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetPoints();
        _numberOfCompletions = 0;
    }

    public override int RecordEvent()
    {
        _numberOfCompletions++;
        return GetPoints();
    }

    public override string GetConsoleString()
    {
        return $"[ ] {GetName()} ({GetDescription()}) -- Completed {_numberOfCompletions} times";
    }

    public override string GetFileSystemString()
    {
        return $"{base.GetFileSystemString()}|{_numberOfCompletions}";
    }
}
