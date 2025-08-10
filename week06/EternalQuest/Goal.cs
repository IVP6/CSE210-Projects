



public abstract class Goal

{
    public string _name { get; set; }
    public string _description { get; set; }
    public int _points { get; set; }
    protected bool _isCompleted;
    private string _complete = "[X]";
    private string _incomplete = "[ ]";
    protected int _currentEvents = 0; // Initialize current events to 0
    protected int _requiredEvents = 0; // Initialize required events to 0

    public Goal(string name, string description, int points, int requiredEvents) // Constructor to initialize the goal (DONE)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = false;
        _requiredEvents = requiredEvents;
        _currentEvents = 0;
    }

    public virtual void RecordEvent()
    {
        // List all goals that are not completed as a numbered list with a for each loop.
        // Replace GoalManager instantiation with a concrete implementation, e.g., SimpleGoalManager
        // Replace 'SimpleGoalManager' with your actual concrete implementation of GoalManager
        GoalManager goalManager = new GoalManager();
        List<Goal> goals = goalManager.GetGoalList();
        int index = 1;
        foreach (Goal goal in goals)
        {
            if (!goal._isCompleted)
            {

                Console.WriteLine($"{index}. {goal.GetDetailsString()}");
                index++;
            }
        }
    }


    public virtual void SetCompleted(bool isCompleted) { _isCompleted = isCompleted; }// DONE
    public virtual string IsComplete() // DONE
    {
        string checkBox;
        if (_isCompleted == true)
        {
            checkBox = _complete;
        }
        else
        {
            checkBox = _incomplete;
        }
        return checkBox;
    }
    public virtual string GetDetailsString()
    {
        var checkBox = IsComplete();
        // Return a string representation of the goal with its details

        return $"{checkBox} {_name}: {_description} \nPoints: {_points}";
    }
    public virtual string GetStringRepresentation()
    {
        return $"{_name} - {_description} - Points: {_points} - Completed: {_isCompleted}";
    }

    public int Loading(int time)
    { 
        for (int i = 0; i < time; i++)
        {
            Console.Write("\rLoading" + new string('.', i % 4));
            System.Threading.Thread.Sleep(500);
        }
        Console.WriteLine("\rLoading... Done!");
        return time;
    }
}