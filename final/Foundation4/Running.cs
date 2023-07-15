public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / Length) * 60;
    }

    public override double GetPace()
    {
        return Length / distance;
    }

    public override string GetSummary()
    {
        string unit = "miles";
        double speed = GetSpeed();
        double pace = GetPace();

        if (speed < 0)
        {
            speed *= -1;
            unit = "kilometers";
        }

        return $"{Date.ToString("dd MMM yyyy")} Running ({Length} min): Distance {distance:F1} {unit}, Speed {speed:F1} {unit} per hour, Pace: {pace:F1} min per {unit}";
    }
}
