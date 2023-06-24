using System;
using System.Diagnostics;
using static System.Console;


public class UserDecision
{
 private  string _userChoice;
public string GetUserOptionMainMenu()
{
   bool Options=false;
      do
      {
                        WriteLine("Main Menu Options");
                        WriteLine("============================================");
                        WriteLine("Please select one of the following options:");
                        WriteLine("1. Create New Goal");
                        WriteLine("2. List Goals");
                        WriteLine("3. Save Goals");
                        WriteLine("4. Load Goals");
                        WriteLine("5. Record Goals");
                        WriteLine("6. Quit");
                        WriteLine("============================================");
                        Write("Select and option from the menu: ");
                        
                        _userChoice=ReadLine().Trim();

                  if (_userChoice=="1"|| _userChoice=="2"||_userChoice=="3"||_userChoice=="4"||_userChoice=="5"||_userChoice=="6")
                  {
                        Options=true;
                        }  
                        else
                        {
                        Console.WriteLine($"\"{_userChoice}\" is not a is valid option. Please chose 1-6"); 
                  } 
           } while (!Options);   
             return _userChoice;
      }

public string GetUserOptionTypeOfGoal()
{
   bool Options=false;
      do
      {
                        WriteLine("Goal Menu Options");
                        WriteLine("============================================");
                        WriteLine("The Types of Goals are:");
                        WriteLine("1. Simple Goals");
                        WriteLine("2. Eternal Goals");
                        WriteLine("3. Checklist Goals");
                        WriteLine("4. Back to Main Menu");
                        WriteLine("============================================");
                        Write("What type of Goal would you like to create? ");
                        
                        _userChoice=ReadLine().Trim();

                  if (_userChoice=="1"|| _userChoice=="2"||_userChoice=="3"||_userChoice=="4")
                  {
                        Options=true;
                        }  
                        else
                        {
                        Console.WriteLine($"\"{_userChoice}\" is not a is valid option. Please chose 1-4"); 
                  } 
           } while (!Options);   
             return _userChoice;
      }


}