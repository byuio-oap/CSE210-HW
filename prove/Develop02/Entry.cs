using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop02
{

    public class Entry
    {
            List<string> entryLst=new List<string>();
            public string _response;
            
    public void createEntry()
    {
        
        PromptGenerator promptLstQuestion=new PromptGenerator();
        promptLstQuestion._prompt=promptLstQuestion.displayPrompts();
        Console.WriteLine(promptLstQuestion._prompt);
        
        DateTime today=DateTime.Today;
        String dateStr=today.ToString("dd/MM/yyyy");

        Journal entrydate= new Journal();
        entrydate._dateStr=dateStr;
        
        _response= Console.ReadLine();

        entryLst.Add(promptLstQuestion._prompt);
        entryLst.Add(entrydate._dateStr);
        entryLst.Add(_response);
       // foreach (var entries in entryLst)
       // {
         //Console.WriteLine($"Date:{entries[0]}-Prompt:{entries[1]}");
         //Console.WriteLine($"{entries[2]}");
        // Console.WriteLine(entries);
            
       // }
    
        
        //Console.WriteLine(userEntryInput);iteLine($"Date:{date_str}-Prompt:{listQuestion}");
        //Console.WriteLine();

        
       Files addEntry=new Files();
       addEntry.addEntryToFile(promptLstQuestion._prompt,entrydate._dateStr,_response);

    }
    public void displayEntryFromList()
    {
      foreach (var entries in entryLst)
        {
         //Console.WriteLine($"Date:{entries[0]}-Prompt:{entries[1]}");
         //Console.WriteLine($"{entries[2]}");
         Console.WriteLine($"display:{entries}");
            
        }
    
    }
    

        
    }
}