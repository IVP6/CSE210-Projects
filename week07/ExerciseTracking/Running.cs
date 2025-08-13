using System;

class Running : Activity
{
    // Remove duplicate private fields - use inherited ones from Activity
    
    public Running(string name, DateTime date, double duration, double distance)
        : base(name, date, duration, distance)
    {
    }

    public override double GetSpeed()
    {
        if (_duration <= 0) return 0;
        return _distance / (_duration / 60.0); // Use 60.0 for floating-point division
    }

    public override double GetPace()
    {
        if (_distance <= 0) return 0;
        return _duration / _distance;
    }
}