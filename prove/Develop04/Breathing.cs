using static System.Console;
using System;
public class Breathing : Activity
{
    private string _breatheIn="Breathe in...";
    private string _breatheOut="Now breathe out...";

    private string _breathingActivityDescription="This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public Breathing (String Name,int Time) : base(Name,Time)
    {

    }
    public void  GetActivityDescription()
    {
       WriteLine(_breathingActivityDescription); 
    }
 public void BreathingTimer(int userInputInSeconds)
    {
        Console.WriteLine();  
        int breathingActivityTimer = 0;
        while (breathingActivityTimer < userInputInSeconds)
        {
            Console.WriteLine();  
            for (int i = 4; i > 0; i--)
            {
                Write($"{_breatheIn}{i}");
                Thread.Sleep(2000);
                Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                breathingActivityTimer += 1;
            }
            Console.WriteLine($"{_breatheIn}  ");  
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{_breatheOut}{i}");
                Thread.Sleep(2000);
                Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");;  
                breathingActivityTimer += 1;
            }
            Console.WriteLine($"{_breatheOut}  ");  
        }
    }


}