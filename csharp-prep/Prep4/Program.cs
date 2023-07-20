using System;
using System.Collections.Generic;
class Program
{
    
    static void Main(string[] args)
    {
        
       int number= -1;
       float total=0;
       float average=0;
       List<int> lstOfNumbers= new List<int>();
       Console.WriteLine("Enter a list of number, type 0 when finished.");  
       while (number!=0)
       {
        Console.Write("Enter a number: ");
        number=int.Parse(Console.ReadLine());
        if (number!=0)
        {
        lstOfNumbers.Add(number);    
        }
    }
       total=lstOfNumbers.Sum();
       int lstSize=lstOfNumbers.Count;
       Console.WriteLine($"The sum is: {total}");
       average=total/lstSize;
       
       Console.WriteLine($"The average is : {average}");
       int max=lstOfNumbers.Max();
       Console.WriteLine($"The largest number is: {max}");
       //int minNumber=lstOfNumbers[0];
       List<int> seclstOfNumbers= new List<int>();

       foreach (int num in lstOfNumbers)
       {
        if (num>0)
        {
         seclstOfNumbers.Add(num);        }
       }
       int min=seclstOfNumbers.Min();
       Console.WriteLine($"The smallest positive number is: {min}");  
       

     // List<int>sortedLst=new List<int>();
       lstOfNumbers.Sort();
       Console.WriteLine("The sorted list is: ");
 
      foreach (int num in lstOfNumbers)
      {
        Console.WriteLine(num);
      }
       
    }
}