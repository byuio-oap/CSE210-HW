using System.Net;
using System.Threading.Tasks.Dataflow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Develop02
{

    public class Files
    {

    public string _filename="journal.txt";


       public void CreateJournalFile()
       {
        
        
        if (!File.Exists(_filename))
        {
          File.CreateText(_filename);  
        }
       }

       public void  DisplayJournalContents()
       {
        string journaltext=File.ReadAllText(_filename);
       
        Console.WriteLine(journaltext);
       }
       
       

       public void addEntryToFile(string prompt,string entrydate,string userInput)
       {
      

        File.AppendAllText(_filename,$"\nDate:{entrydate} - Prompt: {prompt}");
        File.AppendAllText(_filename,($"\n{userInput}"));
        
       }





    }
}