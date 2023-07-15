using System;

class Program
{
    static void Main(string[] args)
    {
       List<Activity> activities = new List<Activity>();

        Console.WriteLine("Enter details for Running activity:");
        activities.Add(CreateRunningActivity());
        Console.WriteLine();

        Console.WriteLine("Enter details for Stationary Bicycles activity:");
        activities.Add(CreateStationaryBicyclesActivity());
        Console.WriteLine();

        Console.WriteLine("Enter details for Swimming activity:");
        activities.Add(CreateSwimmingActivity());
        Console.WriteLine();

        Console.WriteLine("Activity Summary:");
        Console.WriteLine();

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }

    private static Running CreateRunningActivity()
    {
        Console.Write("Enter the date (yyyy-mm-dd): ");
        DateTime date;
        while (!DateTime.TryParse(Console.ReadLine(), out date))
        {
            Console.WriteLine("Invalid date format. Please enter the date in the correct format (yyyy-mm-dd): ");
        }

        Console.Write("Enter the length (minutes): ");
        int length;
        while (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
        {
            Console.WriteLine("Invalid length. Please enter a positive integer value for the length: ");
        }

        Console.Write("Enter the distance (miles): ");
        double distance;
        while (!double.TryParse(Console.ReadLine(), out distance) || distance <= 0)
        {
            Console.WriteLine("Invalid distance. Please enter a positive decimal value for the distance: ");
        }

        return new Running(date, length, distance);
    }

    private static StationaryBicycles CreateStationaryBicyclesActivity()
    {
        Console.Write("Enter the date (yyyy-mm-dd): ");
        DateTime date;
        while (!DateTime.TryParse(Console.ReadLine(), out date))
        {
            Console.WriteLine("Invalid date format. Please enter the date in the correct format (yyyy-mm-dd): ");
        }

        Console.Write("Enter the length (minutes): ");
        int length;
        while (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
        {
            Console.WriteLine("Invalid length. Please enter a positive integer value for the length: ");
        }

        Console.Write("Enter the speed (mph): ");
        double speed;
        while (!double.TryParse(Console.ReadLine(), out speed) || speed <= 0)
        {
            Console.WriteLine("Invalid speed. Please enter a positive decimal value for the speed: ");
        }

        return new StationaryBicycles(date, length, speed);
    }

    private static Swimming CreateSwimmingActivity()
    {
        Console.Write("Enter the date (yyyy-mm-dd): ");
        DateTime date;
        while (!DateTime.TryParse(Console.ReadLine(), out date))
        {
            Console.WriteLine("Invalid date format. Please enter the date in the correct format (yyyy-mm-dd): ");
        }

        Console.Write("Enter the length (minutes): ");
        int length;
        while (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
        {
            Console.WriteLine("Invalid length. Please enter a positive integer value for the length: ");
        }

        Console.Write("Enter the number of laps: ");
        int laps;
        while (!int.TryParse(Console.ReadLine(), out laps) || laps <= 0)
        {
            Console.WriteLine("Invalid number of laps. Please enter a positive integer value for the laps: ");
        }

        return new Swimming(date, length, laps);
    }
}
