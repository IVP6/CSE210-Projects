class Swimming : Activity
{
    private int _laps;
    private double _poolLength = 50; // in meters

    public Swimming(string name, DateTime date, double duration, int laps)
        : base(name, date, duration, 0) // distance will be calculated
    {
        _laps = laps;
        // Calculate distance in miles
        _distance = GetDistance();
    }

    public double GetDistance()
    {
        // Distance = laps × pool length (convert meters to miles)
        double distanceInMeters = _laps * _poolLength;
        return distanceInMeters * 0.000621371; // Convert meters to miles
    }

    public override string GetSummary()
    {
        return $"{_date.ToShortDateString()} {GetType().Name} ({_name}) - Duration: {_duration} min, Distance: {GetDistance():F2} miles, Laps: {_laps}, Speed: {GetSpeed():F2} mph";
    }
}