using System;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalPoints = 0; //  keep track of total points
    static void Main(string[] args)
    {
        Console.Clear();

        string userChoice = "";
        Console.Clear();
        while (userChoice != "6")
        {
            Console.WriteLine($"Total Points: {totalPoints}\n");
            Console.Write("Menu Options\n1. Create New Goal\n2. List Goal\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit\nSelect a choice from the menu: ");
            userChoice = Console.ReadLine();
            // Create new Goal
            if (userChoice == "1"){
                Console.Write("The types of Goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\nWhich type of goal would you like to create? ");
                string userChoice2 = Console.ReadLine();

                // Create a new simple goal
                if (userChoice2 == "1"){
                    SimpleGoal simpleGoal = new SimpleGoal(); // create simpleGoal object
                    simpleGoal.PromptUser();    // get all the information from the user. do this each time
                    goals.Add(simpleGoal);  // add object to the list of goals to save it for later
                }
                // Eternal Goal
                if (userChoice2 == "2"){
                    EternalGoal eternalGoal = new EternalGoal(); // create simpleGoal object
                    eternalGoal.PromptUser();    // get all the information from the user. do this each time
                    goals.Add(eternalGoal);  // add object to the list of goals to save it for later
                }
                // CheckListGoal
                if (userChoice2 == "3"){
                    CheckListGoal checkListGoal = new CheckListGoal(); // create simpleGoal object
                    checkListGoal.PromptUser();    // get all the information from the user. do this each time
                    goals.Add(checkListGoal);  // add object to the list of goals to save it for later
                }
            }
            // List Goals
            else if (userChoice == "2")
            {
                ListGoals();
            }
            // Save Goals
            else if (userChoice == "3")
            {
                SaveFile();
            }
            // Load File
            else if (userChoice == "4"){

            }

            // Record Goal
            else if (userChoice == "5")
            {
                // List all the goals out and then ask the user which one they want 
                // to record
                Console.WriteLine("List of all the goals:");
                ListGoals();
                Console.Write("Which goal would you like to record (enter a number)? ");
                string goalChoice = Console.ReadLine();

                int iGoal = int.Parse(goalChoice) - 1;
                Goal goal = goals[iGoal];
                int pointsToAdd = goal.RecordEvent();

                totalPoints += pointsToAdd;

                // Display total points
                Console.WriteLine($"You now have {totalPoints} points.");
            }
        }
    }
    static void ListGoals()
    {
        // List the goals
        int counter = 0;
        foreach (Goal goal in goals)
        {
            counter ++;
            if (goal.IsCompleted)
            {
                Console.Write("[X] ");
            }
            else 
            {
                Console.Write("[ ] ");
            }

            // Display name and description
            Console.Write($"{counter}. {goal.Name} ({goal.Description})");

            // CheckList Goals need to print off a few extra things.
            if (goal.GetType().ToString() == "CheckListGoal")
            {
                Console.Write(goal.ToString());
            }
            // New line at the end of each list item.
            Console.WriteLine();
        }
    }
    
    static void SaveFile(){
        Console.Write("Which file do you want to save? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"totalpoints,{totalPoints}");
            foreach(Goal goal in goals){
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

    }

}