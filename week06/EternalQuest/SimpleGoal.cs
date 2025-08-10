public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points, 1) // Pass 1 as requiredEvents for SimpleGoal
    {
    }

    public override void RecordEvent()
    {
        if (!_isCompleted)
        {
            Loading(6);
            _isCompleted = true;
            Console.WriteLine($"{_points} points awarded!");
            Console.WriteLine("Goal completed!\n");
            Loading(6);
        }
    }

    public override string GetDetailsString()
    {
        string checkBox = _isCompleted ? "[X]" : "[ ]"; //
        return $"{checkBox} {_name} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        Loading(6);
        return $"SimpleGoal:{_name},{_description},{_points},{_isCompleted}";
    }
}