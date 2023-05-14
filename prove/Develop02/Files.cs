using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class Files
    {
 public string _filename="journal.txt";
Entry clsEntryInFile =new Entry();


        
 

public void  DisplayEntryFromFiles(Entry clsEntry2)
       {
        Console.WriteLine("What is the filename?");
        Console.Write(">");
        _filename=Console.ReadLine().Trim();
        if (File.Exists(_filename))
        {
          
          var logFile = File.ReadAllLines(_filename);
           foreach (var s in logFile) clsEntry2.entryLst.Add(s);

          
        }
        else
        {
          Console.WriteLine("File does not exist!");
        }
          //clsEntry2.entryLst=File.ReadAllText(_filename);
          // string journaltext=File.ReadAllText(_filename_);
          // Console.WriteLine(journaltext);
          // string filename = "myFile.txt";
          //string[] lines = System.IO.File.ReadAllLines(_filename);

          //foreach (string line in lines)
          //{
          // string[] parts = line.Split(",");

          // string _dateStr = parts[0];
          //string lastName_ = parts[1];
          //Console.WriteLine()
          //}
       }
       
       
 public void saveEntryToTxTFile(Entry clsEntry)
       {
                
          if (!File.Exists(_filename))
                {
                  
                  Console.WriteLine("What is the filename?");
                  Console.Write(">");
                  _filename=Console.ReadLine().Trim();
                  File.CreateText(_filename);
                  TextWriter tw = new StreamWriter(_filename);
                    foreach (String s in clsEntry.entryLst)
                      tw.WriteLine(s);
                    tw.Close();
                }
          else
                {
                  Console.WriteLine("What is the filename?");
                  Console.Write(">");
                  _filename=Console.ReadLine().Trim();
                   TextWriter tw = new StreamWriter(_filename);
                  foreach (String s in clsEntry.entryLst)
                           tw.WriteLine(s);
                  tw.Close();  
                 }
        
       }
        


}
