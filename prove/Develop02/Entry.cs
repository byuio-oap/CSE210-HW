using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class Entry
    {
     public List<string> entryLst=new List<string>();
     public string _response;
    public string _prompt;
    public string _dateStr;
   //Entrada entrada =new Entrada();
    PromptGenerator promptGenerator=new PromptGenerator();
    
    //public List<Entrada> lst_entries = new List<Entrada>();
    



    


    
            
    public void createEntry()
    {
    //     //Random question to display to user and save in journal.
    //    _prompt=promptGenerator.displaySelectedPrompts();
        _prompt=promptGenerator.displaySelectedPrompts();

        Console.WriteLine(_prompt);
        
    //    //Todays date
         DateTime today=DateTime.Today;
        string dateStr=today.ToString("dd/MM/yyyy");
          _dateStr=dateStr;
      
    //     //Read and save user respond to random question in _response.
           _response= Console.ReadLine();
       
    //    //Add entries to a List
       entryLst.Add(_prompt);
       entryLst.Add(_dateStr);
       entryLst.Add(_response);
              
      


    }
    

     public void DisplayAllEntries()
     {
        
       foreach (var ent in entryLst)
       {
               Console.WriteLine(ent);
       }  
    }

      public void DisplayAll()
     {
        

     Console.WriteLine($"Date {_dateStr} - Prompt {_prompt}");
     Console.WriteLine($"{_response}\n");          
    }
}
    
    
