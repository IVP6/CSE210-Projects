using System;
using System.Collections.Generic;

class Activity
{
    protected string _name;
    protected DateTime _date;
    protected double _duration;  // in minutes
    protected double _distance;  // in miles

    public Activity(string name, DateTime date, double duration, double distance = 0)
    {
        _name = name;
        _date = date;
        _duration = duration;
        _distance = distance;
    }

    public virtual double GetSpeed()
    {
        if (_duration <= 0) return 0;
        return _distance / (_duration / 60.0); // Use 60.0 for floating-point division
    }

    public virtual double GetPace()
    {
        if (_distance <= 0) return 0;
        return _duration / _distance;
    }

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {_name} ({_duration} min) - Distance: {_distance:F1} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F1} min per mile";
    }
}