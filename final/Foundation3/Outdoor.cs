using System;
public class OutdoorGathering : Event
{
    private string forecast;
    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time,string forecast, Address address)
        : base(title, description, date, time, address)
    {
            this.forecast=forecast;
    }

    public override string GetFullDetails()
    {
       // string weather = GetWeatherForecast();
       // return $"{base.GetShortDescription()}\nType: Outdoor Gathering\nWeather: {weather}";
        return $"{base.GetShortDescription()}\nWeather: {forecast}";

    }

    protected override string GetEventType()
    {
        return "Outdoor Gathering";
    }

    private string GetWeatherForecast()
    {
        
        return "Sunny";
    }
}