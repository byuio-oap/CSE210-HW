using System;

public class Job
{
    
        public string _company;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;
       // Console.WriteLine("Hello Learning02 World!");

    public void Display()
    {
        Console.WriteLine($"{_jobTitle}  {_company} {_startYear}-{_endYear}");
    }
    
}