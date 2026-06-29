using System;

public abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;
    private string _goalType;

    public BaseGoal()
    {
        _name = "";
        _description = "";
        _numberOfPoints = 0;
        _status = false;
        _goalType = "";
    }

    public BaseGoal(
        string name,
        string description,
        int points,
        bool status,
        string goalType)
    {
        _name = name;
        _description = description;
        _numberOfPoints = points;
        _status = status;
        _goalType = goalType;
    }

    protected string GetName()
    {
        return _name;
    }

    protected void SetName()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine() ?? "";
    }

    protected string GetDescription()
    {
        return _description;
    }

    protected void SetDescription()
    {
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine() ?? "";
    }

    protected int GetPoints()
    {
        return _numberOfPoints;
    }

    protected void SetPoints()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        _numberOfPoints = int.Parse(Console.ReadLine() ?? "0");
    }

    protected bool GetStatus()
    {
        return _status;
    }

    protected int MarkComplete()
    {
        _status = true;
        return _numberOfPoints;
    }

    public virtual string GetConsoleString()
    {
        string statusMarker = "[ ]";

        if (_status)
        {
            statusMarker = "[X]";
        }

        return $"{statusMarker} {_name} ({_description})";
    }

    public virtual string GetFileSystemString()
    {
        return $"{_goalType}|{_name}|{_description}|{_numberOfPoints}|{_status}";
    }

    public virtual string GetGoalType()
    {
        return _goalType;
    }

    public abstract int RecordEvent();

    public abstract void CreateGoal();
}
