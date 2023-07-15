public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        return (distance / Length) * 60;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return Length / distance;
    }

    public override string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        return $"{Date.ToString("dd MMM yyyy")} Swimming ({Length} min): Distance {distance:F1} km, Speed {speed:F1} kph, Pace: {pace:F1} min per km";
    }
}
