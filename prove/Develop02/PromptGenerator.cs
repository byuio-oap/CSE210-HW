using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class PromptGenerator
    {
     

public string displaySelectedPrompts()
    {   
    
       // List of question to randomly select
    List<string> lstPrompts=new List<string>();
    lstPrompts.Add("Who was the most interesting person I interacted with today?");
    lstPrompts.Add("What was the best part of my day?");
    lstPrompts.Add("How did I see the hand of the Lord in my life today?");
    lstPrompts.Add("What was the strongest emotion I felt today?");
    lstPrompts.Add("If I had one thing I could do over today, what would it be?");

    var random = new Random();
    int index=random.Next(lstPrompts.Count);
    string Randomprompt=lstPrompts[index]; 
    return Randomprompt;
 }
  }
