using System;
using System.Diagnostics;
using static System.Console;


class Program
{
    static void Main(string[] args)
    {
      GoalManager goals = new GoalManager();
      Program program =new Program();
      Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");


        string selectedChoice;
        do
        {
          UserDecision userOption = new UserDecision();
          selectedChoice=userOption.GetUserOptionMainMenu();  
          switch (selectedChoice)
          {
            case "1":
                   string userSelectedTypeOfGoal="";
                    while (userSelectedTypeOfGoal!="4")
                    {
                        userSelectedTypeOfGoal=userOption.GetUserOptionTypeOfGoal();

                        switch (userSelectedTypeOfGoal)
                        {
                            case "1"://Simple
                            (string name,string description,int points)=program.SimpleAndEternalGoalQuestion();
                            SimpleGoal simpleGoal= new SimpleGoal("Simple Goal:",name,description,points);
                            goals.AddGoal(simpleGoal);
                            break;
                            case "2"://Eternal
                            (string eName,string eDescription,int ePoints)=program.SimpleAndEternalGoalQuestion();
                            EternalGoal eternalGoal= new EternalGoal("Enternal Goal:",eName,eDescription,ePoints);
                            goals.AddGoal(eternalGoal);
                            break;
                            case "3"://List
                            (string lName,string lDescription,int lPoints)=program.SimpleAndEternalGoalQuestion();
                            Console.Write("How many times does this goal need to be accomplished for a bonus?  ");
                            int numberOfTimes = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for accomplishing it that many times?  ");
                            int bonusPoints = int.Parse(Console.ReadLine());
                            ListGoals listGoal= new ListGoals("Check List Goal:",lName,lDescription,lPoints,numberOfTimes,bonusPoints);
                            goals.AddGoal(listGoal);
                            break;
                            case "4"://Quit Sub Menu
                            break;
                            
                        }
                    }
              break;
            case "2":
            Console.Clear();  
            Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
            goals.ListGoals();
            break;
            
            case "3":
            goals.SaveGoals();
            break;

            case "4":
            Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
            goals.LoadGoals();

            break;
            
            case "5":
            Console.Clear(); 
            Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
            goals.RecordGoalEvent();
            break;
            
            case "6":
            Console.WriteLine("\nThank you for using the Eternal Quest Program!\n");
                    break;
                    
            
          } 
        } while (selectedChoice!="6");
    }

 private (string name , string description ,int points) SimpleAndEternalGoalQuestion(){
      Console.WriteLine("What is the name of your goal?  ");
      string name = Console.ReadLine();
      Console.WriteLine("What is a short description of your goal?  ");
      string description = Console.ReadLine();
      Console.Write("What is the amount of points associated with this goal?  ");
      int points = int.Parse(Console.ReadLine());
      
      return (name,description,points);
  }


}