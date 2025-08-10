using System;
using System.Collections.Generic;
using System.IO;



 class GoalManager
{
    public List<Goal> _goals; // Stores a list of all goals
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public List<Goal> GetGoalList()
    {
        return _goals;
    }
        public void Start()
    {
        bool running = true;
        
        while (running)
        {
            Console.Clear();
            DisplayPlayerInfo(); // Show current score
            Console.WriteLine("==============================");
            Console.WriteLine("Welcome to the Eternal Quest!");
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Please select an option (1-6): ");
            
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        CreateGoal();
                        break;
                    case 2:
                        ListGoalDetails();
                        break;
                    case 3:
                        SaveGoals();
                        break;
                    case 4:
                        LoadGoals();
                        break;
                    case 5:
                        RecordEvent();
                        break;
                    case 6:
                        Console.WriteLine("Thank you for playing!");
                        running = false; // Exit the loop
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
            
            if (running)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }

    // Remove this closing brace to keep methods inside the class

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score} pts.\n");
        Console.WriteLine("Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"- {goal._name}");
        }
        Console.WriteLine("\n==============================\n");
        
    }

    public Goal ListGoalNames()// list all goal names, pick one and return the goal***DONE***
    {
        int index = 0;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index + 1}. {goal._name}");
            index++;
        }
        Console.WriteLine("Select a goal by number to view details or record an event.");
        int goalChoice = int.Parse(Console.ReadLine());
        if (goalChoice < 1 || goalChoice > _goals.Count)
        {
            Console.WriteLine("Invalid choice, please try again.");
            return null;
        }
        Goal selectedGoal = _goals[goalChoice - 1];
        // Now you can view details or record an event for the selected goal
        return selectedGoal;
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals) //display all goals
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal() //DONE
    {
        Console.WriteLine("Select the type of goal to create:");
        Console.WriteLine("1. Simple Goal (Requires 1 event to complete)");
        Console.WriteLine("2. Regular Goal (Requires multiple events to complete)");
        Console.WriteLine("3. Eternal Goal (No time limit)");
        Console.WriteLine("4. Quit");
        Console.Write("Please select an option (1-4): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                // Logic to create a Simple Goal
                Console.Write("Enter the name of the Simple Goal: ");
                string simpleName = Console.ReadLine();
                Console.Write("What are the details of the goal? ");
                string simpleDescription = Console.ReadLine();
                Console.Write("Enter the number of points for completing this goal: ");
                int simplePoints = int.Parse(Console.ReadLine());
                _goals.Add(new SimpleGoal(simpleName, simpleDescription, simplePoints));

                break;
            case 2:
                // Logic to create a Regular Goal
                Console.Write("Enter the name of the Regular Goal: ");
                string regularName = Console.ReadLine();
                Console.Write("What requirements are needed to complete this goal? ");
                string regularDescription = Console.ReadLine();
                Console.Write("Enter the number of events required to complete this goal: ");
                int requiredEvents = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of points for completing this goal: ");
                int regularPoints = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonusPoints = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(regularName, regularDescription, regularPoints, requiredEvents, bonusPoints));
                break;

            case 3:
                // Logic to create an Eternal Goal
                Console.Write("Enter the name of the Eternal Goal: ");
                string eternalName = Console.ReadLine();
                Console.Write("Goal description?: ");
                string eternalDescription = Console.ReadLine();
                Console.Write("Points per event occurrence?: ");
                int eternalPoints = int.Parse(Console.ReadLine());
                _goals.Add(new EternalGoal(eternalName, eternalDescription, eternalPoints));
                break;
            case 4:
                Console.WriteLine("Thank you for playing!");
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                break;
        }
    }
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record events for.");
            return;
        }
        
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]._name}");
        }
        
        Console.Write("Which goal would you like to record?: ");
        int goalChoice = int.Parse(Console.ReadLine());

        if (goalChoice >= 1 && goalChoice <= _goals.Count)
        {
            Goal selectedGoal = _goals[goalChoice - 1];
            int pointsEarned = 0;
            selectedGoal.RecordEvent();
            if (selectedGoal is SimpleGoal simpleGoal)
            {
                pointsEarned = simpleGoal._points;
                _score += pointsEarned; // Update the score with the points earned
            }
            else if (selectedGoal is ChecklistGoal checklistGoal)
            {
                pointsEarned = checklistGoal._points;
                _score += pointsEarned; // Update the score with the points earned
            }
            else if (selectedGoal is EternalGoal eternalGoal)
            {
                pointsEarned = eternalGoal.EarnedPoints; // Use public property to access score
                _score += pointsEarned; // Update the score with the points earned
            }

            
        }
        else
        {
            Console.WriteLine("Invalid choice, please try again.");
        }
    }


        public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(_score); // Save score first
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

        public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
    
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }
    
        try
        {
            _goals.Clear(); // Clear existing goals
            
            using (StreamReader reader = new StreamReader(fileName))
            {
                // First line should be the score
                string scoreLine = reader.ReadLine();
                if (int.TryParse(scoreLine, out int savedScore))
                {
                    _score = savedScore;
                }
                
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Parse each goal line
                    string[] parts = line.Split(':');
                    if (parts.Length < 2) continue;
                    
                    string goalType = parts[0];
                    string[] goalData = parts[1].Split(',');
                    
                    if (goalData.Length < 4) continue;
                    
                    string name = goalData[0];
                    string description = goalData[1];
                    int points = int.Parse(goalData[2]);
                    bool isCompleted = bool.Parse(goalData[3]);
                    
                    Goal goal = null;
                    
                    // Create the appropriate goal type
                    switch (goalType)
                    {
                        case "SimpleGoal":
                            goal = new SimpleGoal(name, description, points);
                            break;
                            
                        case "EternalGoal":
                            // Eternal goals might have additional data like times completed
                            goal = new EternalGoal(name, description, points);
                            break;
                            
                        case "ChecklistGoal":
                            // ChecklistGoal needs: name, description, points, target, bonusPoints
                            // Format: ChecklistGoal:name,description,points,isCompleted,amountCompleted,target,bonusPoints
                            if (goalData.Length >= 7)
                            {
                                int amountCompleted = int.Parse(goalData[4]);
                                int target = int.Parse(goalData[5]);
                                int bonusPoints = int.Parse(goalData[6]);
                                goal = new ChecklistGoal(name, description, points, target, bonusPoints);
                                
                                // You might need to set the current progress if ChecklistGoal has a method for it
                                // goal.SetProgress(amountCompleted); // If this method exists
                            }
                            break;
                    }
                    
                    // Add the goal to the list if it was created successfully
                    if (goal != null)
                    {
                        if (isCompleted)
                            goal.SetCompleted(true);
                        _goals.Add(goal);
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }



}    