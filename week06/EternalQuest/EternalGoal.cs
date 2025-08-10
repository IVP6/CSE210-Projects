using System;
using System.Diagnostics.Tracing;



class EternalGoal : Goal
{
    //private int _score = 0; // Initialize score to 0
    private int _earnedPoints = 0; public int EarnedPoints { get { return _earnedPoints; } } // Property to access earned points
   // public int Score { get { return _score; } } // Property to access score

    public EternalGoal(string name, string description, int points) : base(name, description, points, 0) // Pass 0 as requiredEvents for EternalGoal
    {
        // EternalGoal does not require a specific number of events to complete
    }

    public override void RecordEvent()  //DONE
    {

        Console.WriteLine($"ETERNAL GOAL: {_name}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Points: {_points}");
        Console.WriteLine($"Times completed: {_currentEvents}");
        Console.WriteLine($"==============================");
        Console.WriteLine("How many times have you completed this goal?");
        int timesCompleted = int.Parse(Console.ReadLine());

        _currentEvents += timesCompleted; // Increment the current events by the number of times completed
        var earnedPoints = timesCompleted * _points; // Increment points by the number of times completed multiplied by the points value
        _earnedPoints = 0;
        _earnedPoints += earnedPoints; // Update the total earned points
        Loading(6);
        Console.WriteLine($"ETERNAL EVENT RECORDED: Total times completed: {_currentEvents}, Points earned: {earnedPoints}");

    }

    public override string IsComplete() //DONE
    {
        // Tracks the number of times the goal has been completed
        return $"ETERNAL GOAL INFO: \nTimes completed: {_currentEvents}\n";
    }

    public override string GetStringRepresentation() //DONE
    {
        int completed = _currentEvents;
        return $"{_name} - {_description} - Points per event: {_points} - Completed: {completed} (Eternal Goal)";
    }
}