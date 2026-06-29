using System;
using System.Collections.Generic;
using System.IO;

public class Goals
{
    private List<BaseGoal> _goals;
    private string _filename;
    private int _totalScore;

    public Goals()
    {
        _goals = new List<BaseGoal>();
        _filename = "";
        _totalScore = 0;
    }

    public void AddGoal(BaseGoal goal)
    {
        _goals.Add(goal);
    }

    public void LoadGoals()
    {
        ObtainFileName("What is the filename for the goal file? ");

        if (!File.Exists(_filename))
        {
            Console.WriteLine("That file does not exist.");
            return;
        }

        string[] lines = File.ReadAllLines(_filename);

        if (lines.Length == 0)
        {
            Console.WriteLine("The file is empty.");
            return;
        }

        _goals.Clear();
        _totalScore = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            bool status = bool.Parse(parts[4]);

            if (goalType == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(
                    name,
                    description,
                    points,
                    status);

                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                int completions = int.Parse(parts[5]);

                EternalGoal goal = new EternalGoal(
                    name,
                    description,
                    points,
                    status,
                    completions);

                _goals.Add(goal);
            }
            else if (goalType == "CheckListGoal")
            {
                int completions = int.Parse(parts[5]);
                int max = int.Parse(parts[6]);
                int bonus = int.Parse(parts[7]);

                CheckListGoal goal = new CheckListGoal(
                    name,
                    description,
                    points,
                    status,
                    completions,
                    max,
                    bonus);

                _goals.Add(goal);
            }
        }

        Console.WriteLine("Your goals have been loaded.");
    }

    public void SaveGoals()
    {
        ObtainFileName("What is the filename for the goal file? ");

        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            outputFile.WriteLine(_totalScore);

            foreach (BaseGoal goal in _goals)
            {
                outputFile.WriteLine(goal.GetFileSystemString());
            }
        }

        Console.WriteLine("Your goals have been saved.");
    }

    public void DisplayGoals()
    {
        Console.WriteLine();
        Console.WriteLine("The goals are:");

        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals yet.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetConsoleString()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_totalScore} points.");
        Console.WriteLine($"Current level: {GetLevel()}");
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals to record.");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetConsoleString()}");
        }

        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine() ?? "0");
        int index = goalNumber - 1;

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("That is not a valid goal number.");
            return;
        }

        int oldLevel = GetLevel();
        int pointsEarned = _goals[index].RecordEvent();

        if (pointsEarned == 0)
        {
            Console.WriteLine("That goal is already complete.");
            return;
        }

        _totalScore += pointsEarned;

        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        Console.WriteLine($"You now have {_totalScore} points.");

        int newLevel = GetLevel();

        if (newLevel > oldLevel)
        {
            Console.WriteLine($"Level up! You reached level {newLevel}!");
        }
    }

    private void ObtainFileName(string prompt)
    {
        Console.Write(prompt);
        _filename = Console.ReadLine() ?? "";
    }

    private int GetLevel()
    {
        return (_totalScore / 500) + 1;
    }
}
