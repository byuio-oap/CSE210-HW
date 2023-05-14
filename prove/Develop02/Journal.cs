using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Journal
{
public string _dateStr="";
Files clsFilesInJournal= new Files();
Entry clsEntryInJournal = new Entry();
//Entrada entrada =new Entrada();
PromptGenerator promptGenerator=new PromptGenerator();

bool loadEntries=false;




public void Menu()
{
 
  string selectChoice;
                  do
                  {

                        selectChoice=GetUserOption();
                        switch (selectChoice)
                        {
                              case "1":
                             clsEntryInJournal.createEntry();
                              break;
                              case "2":
                              if (loadEntries==true)
                              {
                                          foreach (var item in clsEntryInJournal.entryLst)
                                          {
                                          Console.WriteLine(item);
                                          loadEntries=false;
                                          }    
                                }
                               else
                               {
                                          clsEntryInJournal.DisplayAllEntries();
            
                               }
                                                                        
                              
                              
                              break;
                              case "3":
                              clsFilesInJournal.DisplayEntryFromFiles(clsEntryInJournal);
                              loadEntries=true;
                              break;
                              case "4":
                              clsFilesInJournal.saveEntryToTxTFile(clsEntryInJournal);
                              break; 
                              case "5":
                              break;                       
                        } 
                  }while(selectChoice!="5");
  
}

private string GetUserOption()
{
   bool Options=false;
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
                        Console.Write("What would you like to to?\n");
                        Console.Write(">" );
                        userChoice=Console.ReadLine().Trim();

                  if (userChoice=="1"|| userChoice=="2"||userChoice=="3"||userChoice=="4"||userChoice=="5")
                  {
                        Options=true;
                        }  
                        else
                        {
                        Console.WriteLine($"\"{userChoice}\" is not a is valid option. Please chose 1-4"); 
                  } 
           } while (!Options);   
           
            return userChoice;

       }



// public void createEntry()
//      {
//        //  Random question to display to user and save in journal.
//       //_prompt=promptGenerator.displaySelectedPrompts();
//       entrada._prompt=promptGenerator.displaySelectedPrompts();
      

//        Console.WriteLine(entrada._prompt);
        
//     //    //Todays date
//          DateTime today=DateTime.Today;
//         string dateStr=today.ToString("dd/MM/yyyy");
//           entrada._dateStr=dateStr;
      
//         //Read and save user respond to random question in _response.
//          entrada._response= Console.ReadLine().Trim();
       
//     //    //Add entries to a List
//     //     entryLst.Add(_prompt);
//     //     entryLst.Add(_dateStr);
//     //     entryLst.Add(_response);
                
      
//        //entrada._resp
       
//     clsEntryInJournal.lst_entries.Add(entrada);
//     clsEntryInJournal.DisplayAllEntry();


//     }

 
}


  
