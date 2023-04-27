using System;

class Program
{
    static void Main(string[] args)
    {
       //Console.WriteLine("Hello Prep3 World!");
       //Console.Write("What is the magic number?");
       //string magicInput=Console.ReadLine();
       //int magic =int.Parse(magicInput);
       
       int guess=-1;
       int contador=0;
       string option="yes"; 
do
{
    Random ranNumber = new Random();
    int magic=ranNumber.Next(1,100);
    Console.WriteLine($"Random # is : {magic}");
      do
      {
       Console.Write("What is you guess? ");
       guess=int.Parse(Console.ReadLine());
       contador++;

        if (guess==magic)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {contador} attempts.");
                Console.Write("Would you like continue playing? (yes or no) ");
                option=Console.ReadLine();
                contador=0;
            }
            
        else if (guess>magic)
            {
                Console.WriteLine("Lower");
            }
        else if (guess<magic)
            {
                Console.WriteLine("Higher");
            }
      } while (guess!=magic);  
     
} while (option!="no");
 Console.WriteLine("Thank you for playing.");
    


     
      
      
      
      
      
       
    }
}