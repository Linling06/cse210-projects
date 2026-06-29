using System;

public class CheckListGoal : BaseGoal
{
    private int _numberOfCompletions;
    private int _maxGoals;
    private int _bonusPoints;

    public CheckListGoal()
        : base("", "", 0, false, "CheckListGoal")
    {
        _numberOfCompletions = 0;
        _maxGoals = 0;
        _bonusPoints = 0;
    }

    public CheckListGoal(
        string name,
        string description,
        int points,
        bool status,
        int completions,
        int max,
        int bonus)
        : base(name, description, points, status, "CheckListGoal")
    {
        _numberOfCompletions = completions;
        _maxGoals = max;
        _bonusPoints = bonus;
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetPoints();
        ObtainMaxGoal();
        ObtainBonusPoints();
        _numberOfCompletions = 0;
    }

    public override int RecordEvent()
    {
        if (GetStatus())
        {
            return 0;
        }

        _numberOfCompletions++;

        if (_numberOfCompletions >= _maxGoals)
        {
            MarkComplete();
            return GetPoints() + _bonusPoints;
        }

        return GetPoints();
    }

    public override string GetConsoleString()
    {
        string statusMarker = "[ ]";

        if (GetStatus())
        {
            statusMarker = "[X]";
        }

        return $"{statusMarker} {GetName()} ({GetDescription()}) -- Completed {_numberOfCompletions}/{_maxGoals} times";
    }

    public override string GetFileSystemString()
    {
        return $"{base.GetFileSystemString()}|{_numberOfCompletions}|{_maxGoals}|{_bonusPoints}";
    }

    private void ObtainMaxGoal()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _maxGoals = int.Parse(Console.ReadLine() ?? "0");
    }

    private void ObtainBonusPoints()
    {
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine() ?? "0");
    }
}
