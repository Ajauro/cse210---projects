using System;

class Program
{   
    //In your Program.cs file, verify that you can call 
    //all of these methods and get the correct values, 
    //using setters to change the values and then getters 
    //to retrieve these new values and then display them to the console.
    static void Main(string[] args)
    {   
        Fraction f1 = new Fraction(1);
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

    }   

}