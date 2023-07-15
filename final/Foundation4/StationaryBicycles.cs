public class StationaryBicycles : Activity
{
    private double speed;

    public StationaryBicycles(DateTime date, int length, double speed) : base(date, length)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Stationary Bicycles ({Length} min): Speed {speed:F1} mph, Pace: {GetPace():F1} min per mile";
    }
}