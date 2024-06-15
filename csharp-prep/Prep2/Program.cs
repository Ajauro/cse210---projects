using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();

        int x = int.Parse(userGrade);

        string letter = "";

        if ( x >= 90)
        {
            letter = "A";
        }
        else if ( x >= 80)
        {
            letter = "B";
        }
        else if ( x >= 70)
        {
            letter = "C";
        }
        else if ( x >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";
        int lastDigit  = x % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (x >= 93)
        {
            sign = "";
        }
        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if ( x >= 70)
        {
            Console.WriteLine("Congratulation, you are APROVED!");
        }
        else 
        {
            Console.WriteLine("Opss, you need to get your grade back!");
        }

    }
}