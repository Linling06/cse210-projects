using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding Requirements:
        // I added a level system based on the user's total score.
        // The current level is displayed with the score, and the program
        // shows a special level-up message when the user reaches a new level.

        Menu menu = new Menu();
        Goals goals = new Goals();

        int choice = 0;

        while (choice != 6)
        {
            goals.DisplayScore();
            choice = menu.DisplayMenu();

            if (choice == 1)
            {
                int goalType = menu.DisplayCreateGoalMenu();
                BaseGoal goal;

                if (goalType == 1)
                {
                    goal = new SimpleGoal();
                }
                else if (goalType == 2)
                {
                    goal = new EternalGoal();
                }
                else if (goalType == 3)
                {
                    goal = new CheckListGoal();
                }
                else
                {
                    Console.WriteLine("That is not a valid goal type.");
                    continue;
                }

                goal.CreateGoal();
                goals.AddGoal(goal);
            }
            else if (choice == 2)
            {
                goals.DisplayGoals();
            }
            else if (choice == 3)
            {
                goals.SaveGoals();
            }
            else if (choice == 4)
            {
                goals.LoadGoals();
            }
            else if (choice == 5)
            {
                goals.RecordEvent();
            }
            else if (choice != 6)
            {
                Console.WriteLine("That is not a valid menu choice.");
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
