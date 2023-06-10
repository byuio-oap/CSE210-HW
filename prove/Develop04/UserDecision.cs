using System;
using static System.Console;

public class UserDecision
{
 private  string _userChoice;
public string GetUserOption()
{
   bool Options=false;
           // string userChoice=""; 

           
            do
            {
                        WriteLine("Menu Options");
                        WriteLine("  Please select one of the following options.");
                        WriteLine("  1.Start breathing activity");
                        WriteLine("  2.Start reflecting activity");
                        WriteLine("  3.Start listing activity");
                        WriteLine("  4.Quit");
                        Write("Select and option from the menu: ");
                        
                        _userChoice=Console.ReadLine().Trim();

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