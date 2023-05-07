using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace Develop02
{
    public class Journal
    {
      public string _dateStr="";

       public void Menu()
       {
            
         string selectChoice;
         do
         {
            Files journalFiles= new Files();
             Entry newEntry = new Entry();

            selectChoice=GetUserOption();
                 switch (selectChoice)
               {
                  
                  case "1":
                      // Console.WriteLine("Write");
                       newEntry.createEntry();
                       
                        break;
                  case "2" :
                       // Console.WriteLine("Display");
                        //newEntry.displayEntryFromList();
                        journalFiles.DisplayJournalContents();
   
                        break;
                  case "3":
                        //Console.WriteLine("Load");
                        break;
                  case "4":
                        
                        //.WriteLine("Filename to save Journal entries:");
                       journalFiles._filename=ReadLine();
                        journalFiles.CreateJournalFile();
                        
                        break; 
                  case "5":
                        //Console.WriteLine("Quit");
                        break;                       
               } 
         }while(selectChoice!="5");
         
       

       }
       private string GetUserOption()
       {
            bool isOneOFTheOptions=false;
            string userChoice=""; 
            do
            {
                  Console.WriteLine("Welcome to the Journal Program!");
                  Console.WriteLine("Please select one of the following choices.");
                  Console.WriteLine("1.Write");
                  Console.WriteLine("2.Display");
                  Console.WriteLine("3.Load");
                  Console.WriteLine("4.Save");
                  Console.WriteLine("5.Quit");
                  Console.WriteLine("What would you like to to?");
                  userChoice=ReadLine().Trim();

                  

                  if (userChoice=="1"|| userChoice=="2"||userChoice=="3"||userChoice=="4"||userChoice=="5")
                 {
                      isOneOFTheOptions=true;
                  }  
                  else
                  {
                     Console.WriteLine($"\"{userChoice}\" is not a is valid option. Please chose 1-4"); 
                      

                 } 
           } while (!isOneOFTheOptions);   
           
            return userChoice;

       }

    }
}