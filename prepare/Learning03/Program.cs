using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning03 World!");
         Fraction noParameter = new Fraction();
        Console.WriteLine(noParameter.GetFractionString());
        Console.WriteLine(noParameter.GetDecimalValue());

        Fraction singleParameter = new Fraction(5);
        Console.WriteLine(singleParameter.GetFractionString());
        Console.WriteLine(singleParameter.GetDecimalValue());

        Fraction doubleParmeter = new Fraction(3, 4);
        Console.WriteLine(doubleParmeter.GetFractionString());
        Console.WriteLine(doubleParmeter.GetDecimalValue());

        Fraction doubleParmeter2 = new Fraction(1, 3);
        Console.WriteLine(doubleParmeter2.GetFractionString());
        Console.WriteLine(doubleParmeter2.GetDecimalValue());  
    }
}