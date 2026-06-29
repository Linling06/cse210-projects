using System;
using System.Collections.Generic;
using System.IO;

public class Goals
{
    private List<BaseGoal> _goals;
    private int _score;
    private Menu _menu;

    public Goals()
    {
        _goals = new List<BaseGoal>();
        _score = 0;
        _menu = new Menu();
    }

    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            choice = _menu.DisplayMenu(_score, GetLevel());
            Console.WriteLine();

            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                ListGoalDetails();
            }
            else if (choice == 3)
            {
                SaveGoals();
            }
            else if (choice == 4)
            {
                LoadGoals();
            }
            else if (choice == 5)
            {
                RecordEvent();
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == 1)
        {
            _goals.Add(new SimpleGoal(shortName, description, points));
        }
        else if (goalType == 2)
        {
            _goals.Add(new EternalGoal(shortName, description, points));
        }
        else if (goalType == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(shortName, description, points, target, bonus));
        }
    }

    private void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You do not have any goals yet.");
            return;
        }

        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine());

        BaseGoal selectedGoal = _goals[goalNumber - 1];

        if (selectedGoal.IsComplete())
        {
            Console.WriteLine("That goal is already complete.");
            return;
        }

        string oldLevel = GetLevel();
        int pointsEarned = selectedGoal.RecordEvent();
        _score += pointsEarned;

        Console.WriteLine($"Congratulations! You earned {pointsEarned} points!");
        Console.WriteLine($"You now have {_score} points.");

        string newLevel = GetLevel();

        if (newLevel != oldLevel)
        {
            Console.WriteLine($"Level up! You are now a {newLevel}!");
        }
    }

    private void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (BaseGoal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Your goals have been saved.");
    }

    private void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("That file does not exist.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        if (lines.Length == 0)
        {
            Console.WriteLine("The file is empty.");
            return;
        }

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] typeAndData = lines[i].Split(new char[] { ':' }, 2);
            string goalType = typeAndData[0];
            string[] data = typeAndData[1].Split('|');

            string shortName = data[0];
            string description = data[1];
            int points = int.Parse(data[2]);

            if (goalType == "SimpleGoal")
            {
                bool isComplete = bool.Parse(data[3]);
                _goals.Add(new SimpleGoal(shortName, description, points, isComplete));
            }
            else if (goalType == "EternalGoal")
            {
                _goals.Add(new EternalGoal(shortName, description, points));
            }
            else if (goalType == "ChecklistGoal")
            {
                int target = int.Parse(data[3]);
                int bonus = int.Parse(data[4]);
                int amountCompleted = int.Parse(data[5]);

                _goals.Add(new ChecklistGoal(
                    shortName,
                    description,
                    points,
                    target,
                    bonus,
                    amountCompleted));
            }
        }

        Console.WriteLine("Your goals have been loaded.");
    }

    private string GetLevel()
    {
        if (_score < 500)
        {
            return "Beginner";
        }
        else if (_score < 1000)
        {
            return "Bronze Adventurer";
        }
        else if (_score < 2000)
        {
            return "Silver Adventurer";
        }
        else if (_score < 3000)
        {
            return "Gold Adventurer";
        }
        else
        {
            return "Eternal Champion";
        }
    }
}
