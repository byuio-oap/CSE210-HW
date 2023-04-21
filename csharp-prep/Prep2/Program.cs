using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!"); A >= 90 B >= 80 C >= 70 D >= 60 F < 60

        Console.Write("Insert you grade. ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter="";
        string signo="";
       
        if (grade>=90)//Checks grade and asign letter
          
            { 
               letter="A"; 
            }
            else if (grade>=80)
            {
               letter="B"; 
            }
            else if (grade>=70)
            {
               letter="C"; 
            }
            else if (grade>=60)
            {
               letter="D"; 
            }
            else
            {
               letter="F"; 
            }
         if (grade>=97||grade<=60) //Check for less than F or A+ 
            {
                Console.WriteLine($"Your grade is {letter}. ");

            }
         else
            {
                if (grade % 10>=7)//Check if remainder is >= 7 and asigns "+" or "-" if it is "3"
                    {
                    signo="+"; 
                    }
                else if (grade % 10 <3)
                    {
                        signo="-";
                    }   

                    Console.WriteLine($"Your grade is {letter}{signo}");

            }
                 

        if (grade>=70)
            {
                Console.WriteLine("Congratulation you passed.");
            }    
        else
            {
                Console.WriteLine("You failed , try harder.");
            }




    }
}