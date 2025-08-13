using System;

class Cycling : Activity
{
    public Cycling(string name, DateTime date, double duration, double distance)
        : base(name, date, duration, distance)
    {

    }




    public override string GetSummary()
    {
        return $"{base.GetSummary()}";
    }
}