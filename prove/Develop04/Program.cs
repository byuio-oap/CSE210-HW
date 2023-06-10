using System;
using static System.Console;

class Program
{
// string _userChoice="";

    static void Main(string[] args)
    {
      

         string selectChoice;
                  do
                  {
                        UserDecision userOption = new UserDecision();
                        selectChoice=userOption.GetUserOption(); 
                        
                        switch (selectChoice)
                        {
                              case "1":
                              Clear();
                              Breathing breathingActivity = new Breathing("Breathing",0);
                              breathingActivity.GetActivityName();
                              breathingActivity.GetActivityDescription();
                              int breathinAactivityInSecond=breathingActivity.GetActivityTime();
                              breathingActivity.ShowSpinnerAnimationStart();
                              breathingActivity.BreathingTimer(breathinAactivityInSecond);
                              breathingActivity.ShowSpinnerAnimationDone();
                              breathingActivity.FinishActivity();
                        


                             // Console.WriteLine("1");
                              break;
                              case "2":
                              Clear();
                              Reflecting reflectActitviy=new Reflecting("Reflecting",0);
                              reflectActitviy.GetActivityName();
                              reflectActitviy.GetActivityDescription();
                              int reflectActivityInSecond=reflectActitviy.GetActivityTime();
                              reflectActitviy.ShowSpinnerAnimationStart();
                              reflectActitviy.ShowPrompt(reflectActivityInSecond);
                              reflectActitviy.ShowSpinnerAnimationDone();
                              reflectActitviy.FinishActivity();

                             // Console.WriteLine("2");
                              
                              break;
                              case "3":
                               Clear();
                              Listing listingActitviy=new Listing("Listning",0);
                              listingActitviy.GetActivityName();
                              listingActitviy.GetActivityDescription();
                              int listingActivityInSecond=listingActitviy.GetActivityTime();
                              listingActitviy.ShowSpinnerAnimationStart();
                              listingActitviy.ReturnPrompt(listingActivityInSecond);
                              listingActitviy.ShowSpinnerAnimationDone();
                              listingActitviy.FinishActivity();
                              //Console.WriteLine("3");
                              break;
                              case "4":
                              break; 
                                                  
                        } 
                 }
                  while(selectChoice!="4");


     }




}



    

