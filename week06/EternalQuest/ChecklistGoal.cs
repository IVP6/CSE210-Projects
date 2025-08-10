public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int target, int bonusPoints) 
        : base(name, description, points, target)
    {
        _amountCompleted = 0;
        _target = target;
        _bonusPoints = bonusPoints;
    }


    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            Loading(8);
            _amountCompleted++;
            Console.WriteLine($"{_points} points awarded!");
            Console.WriteLine($"Current progress: {_amountCompleted}/{_target}");
            Console.WriteLine($"Current Points: {_points}");
            if (_amountCompleted == _target)
            {
                _isCompleted = true;
                Console.WriteLine($"Goal completed! You earned a bonus of {_bonusPoints} points!");
                _points += _bonusPoints;
            }
        }
    }

    public override string GetDetailsString()
    {
        return $"{GetCheckBox()} {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    private string GetCheckBox()
    {
        return _isCompleted ? "[X]" : "[ ]";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_isCompleted},{_amountCompleted},{_target},{_bonusPoints}";
    }
}