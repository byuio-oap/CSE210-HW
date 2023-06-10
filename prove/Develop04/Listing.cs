using System;
using System.Diagnostics;
using static System.Console;

public class Listing : Activity
{
    // Attributes 
    private List<string> _promptList = new List<string>
    {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };
    private List<string> _saveRespondList = new List<string>();
    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";


    
    public Listing(string activityName, int activityTime) : base(activityName, activityTime)
    {

    }
    public void GetActivityDescription()
    {
        WriteLine(_description);
    }
    private string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_promptList.Count);
        return _promptList[index];
    }
    public void ReturnPrompt(int seconds)
    {
        WriteLine(); 
        var question = GetRandomPrompt();
        WriteLine("\nList as many responses as you can to the following prompt:");
        WriteLine($"\n--- {question} ---");
        CountDown();
        WriteLine("");    

       Stopwatch timer = new Stopwatch();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < seconds)
        {
            Write("> ");
            _saveRespondList.Add(Console.ReadLine());
        }
        timer.Stop();
        int listLength = _saveRespondList.Count;
        WriteLine($"\nYou listed {listLength} items!");
        
    }
   
   
   }
