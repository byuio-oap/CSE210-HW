using System;
using static System.Console;
public class Activity{
    private string _actName;
    private int _actTime;

     private string _message = "You may begin in...";


    public Activity(string actName,int actTime)
    {
          _actName=actName;
          _actTime=actTime;
    }
    public void GetActivityName()
    {
       WriteLine($"Welcome to the {_actName} Activity\n");
    }   

    public int GetActivityTime()
    {
        Write("\nHow long, in seconds, would you like for your session?");
        int userInputInSeconds=Int32.Parse(ReadLine());
        _actTime=userInputInSeconds;
        return userInputInSeconds;
    }

public void ShowSpinnerAnimationStart()
    {
        Console.Clear();
        Write("Get ready...\n");
        ShowSpinnerAnimation();
    } 

public void ShowSpinnerAnimationDone()
    {
        Write("\nWell done !!\n");
        ShowSpinnerAnimation();
    } 


 public void FinishActivity()
    {
        
        Console.WriteLine($"\nYou have completed another {_actTime} seconds of the {_actName} Activity!");
        ShowSpinnerAnimation();
        Console.Clear();
    }


public void ShowSpinnerAnimation()
{

    
        List<string> spinnerAnimation=new List<string>();
        spinnerAnimation.Add("/");
        spinnerAnimation.Add("-");
        spinnerAnimation.Add("\\");
        spinnerAnimation.Add("|");
        spinnerAnimation.Add("|");

       
        DateTime startTime = DateTime.Now;
        DateTime endtime=startTime.AddSeconds(5);
        int spinnerAnimationIndex=0;
        
        while(DateTime.Now<endtime)
        {
            string index = spinnerAnimation[spinnerAnimationIndex];
            Write(index);
            Thread.Sleep(75);
            Write("\b \b");
            spinnerAnimationIndex++;

            if (spinnerAnimationIndex >=4)
            {
                spinnerAnimationIndex=0;
            }
           
        }
        
}

 public void CountDown()
    {
        WriteLine();  
        for (int i = 5; i > 0; i--)
        {
            Write($"{_message}{i}");
            Thread.Sleep(1000);
            Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        }

    }

public void ShowSpinnerThinkingAnimation()
{

    
        List<string> spinnerAnimation=new List<string>();
        spinnerAnimation.Add("/");
        spinnerAnimation.Add("-");
        spinnerAnimation.Add("\\");
        spinnerAnimation.Add("|");
        spinnerAnimation.Add("|");

       
        DateTime startTime = DateTime.Now;
        DateTime endtime=startTime.AddSeconds(7);
        int spinnerAnimationIndex=0;
        
        while(DateTime.Now<endtime)
        {
            string index = spinnerAnimation[spinnerAnimationIndex];
            Write(index);
            Thread.Sleep(900);
            Write("\b \b");
            spinnerAnimationIndex++;

            if (spinnerAnimationIndex >=4)
            {
                spinnerAnimationIndex=0;
            }
           
        }
        
}

 

}
