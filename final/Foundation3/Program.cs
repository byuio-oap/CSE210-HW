
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Create a Lecture Event");
        Lecture lecture = CreateLectureEvent();
        Console.WriteLine();

        Console.WriteLine("Create a Reception Event");
        Reception reception = CreateReceptionEvent();
        Console.WriteLine();

        Console.WriteLine("Create an Outdoor Gathering Event");
        OutdoorGathering outdoorGathering = CreateOutdoorGatheringEvent();
        Console.WriteLine();
        
        Console.Clear();

        Console.WriteLine("Marketing Messages:");
        Console.WriteLine();
        Console.WriteLine("Lecture Event");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Reception Event");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Outdoor Gathering Event");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        
    }

    private static Lecture CreateLectureEvent()
    {
        Console.WriteLine("===============================================================================");
        Console.Write("Enter the title: ");
        string title = Console.ReadLine();

        Console.Write("Enter the description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the date (yyyy-mm-dd): ");
        DateTime date;
        while (!DateTime.TryParse(Console.ReadLine(), out date))
        {
            Console.WriteLine("Invalid date format. Please enter the date in the correct format (yyyy-mm-dd): ");
        }

        Console.Write("Enter the time (hh:mm): ");
        TimeSpan time;
        while (!TimeSpan.TryParse(Console.ReadLine(), out time))
        {
            Console.WriteLine("Invalid time format. Please enter the time in the correct format (hh:mm): ");
        }

        Address address = CreateAddress();

        Console.Write("Enter the speaker: ");
        string speaker = Console.ReadLine();

        Console.Write("Enter the capacity: ");

        int capacity;
        while (!int.TryParse(Console.ReadLine(), out capacity) || capacity <= 0)
        {
            Console.WriteLine("Invalid capacity. Please enter a positive integer value for the capacity: ");
        }

        return new Lecture(title, description, date, time, address, speaker, capacity);
    }

    private static Reception CreateReceptionEvent()
    {
        Console.WriteLine("===============================================================================");
        Console.Write("Enter the title: ");
        string title = Console.ReadLine();

        Console.Write("Enter the description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the date (yyyy-mm-dd): ");
        DateTime date;
        while (!DateTime.TryParse(Console.ReadLine(), out date))
        {
            Console.WriteLine("Invalid date format. Please enter the date in the correct format (yyyy-mm-dd): ");
        }

        Console.Write("Enter the time (hh:mm): ");
        TimeSpan time;
        while (!TimeSpan.TryParse(Console.ReadLine(), out time))
        {
            Console.WriteLine("Invalid time format. Please enter the time in the correct format (hh:mm): ");
        }

        Address address = CreateAddress();

        Console.Write("Enter the RSVP email: ");
        string rsvpEmail = Console.ReadLine();

        return new Reception(title, description, date, time, address, rsvpEmail);
    }

    private static OutdoorGathering CreateOutdoorGatheringEvent()
    {
        Console.WriteLine("===============================================================================");
        Console.Write("Enter the title: ");
        string title = Console.ReadLine();

        Console.Write("Enter the description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the date (yyyy-mm-dd): ");
        DateTime date;
        while (!DateTime.TryParse(Console.ReadLine(), out date))
        {
            Console.WriteLine("Invalid date format. Please enter the date in the correct format (yyyy-mm-dd): ");
        }

        Console.Write("Enter the time (hh:mm): ");
        TimeSpan time;
        while (!TimeSpan.TryParse(Console.ReadLine(), out time))
        {
            Console.WriteLine("Invalid time format. Please enter the time in the correct format (hh:mm): ");
        }

        Console.Write("Enter Weather Forecast (Sunny, Rainy, Cloudy, Windy, Stormy): ");
        string forecast = Console.ReadLine();

        Address address = CreateAddress();
        
        return new OutdoorGathering(title, description, date, time, forecast, address);
        
    }

    private static Address CreateAddress()
    {
        Console.Write("Enter the street: ");
        string street = Console.ReadLine();

        Console.Write("Enter the city: ");
        string city = Console.ReadLine();

        Console.Write("Enter the state: ");
        string state = Console.ReadLine();

        Console.Write("Enter the postal code: ");
        string postalCode = Console.ReadLine();

        return new Address(street, city, state, postalCode);
    }
}
