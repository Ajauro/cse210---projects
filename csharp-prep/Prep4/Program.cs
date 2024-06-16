using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of number, type 0 when finished.");

        List <int> numbers = new List <int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        if (numbers.Count > 0)
        {
            int sum = 0;
            foreach ( int i in numbers)
            {
                sum += i;
            }

            double average = (double) sum / numbers.Count;
            int largestNumber = numbers[0];
            int smallestNumber = int.MaxValue;
            bool foundPositive = false;
                
            foreach (int i in numbers)
            {
                if ( i > largestNumber)
                {
                    largestNumber = i;
                }
            
            //stretch challenge
                if ( i > 0 && i < smallestNumber)
                {
                    smallestNumber = i;
                    foundPositive = true;
                }
            }

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}"); 
            Console.WriteLine($"The largest number is: {largestNumber}");

            //stretch challenge
            if (foundPositive)
            {
                Console.WriteLine($"The smallest positive number is: {smallestNumber}");
            }

            SortList(numbers);
            Console.WriteLine("The sorted list is: ");

            foreach ( int i in numbers)
            {
                Console.WriteLine(i);
            }
        }    
    }
    static void SortList(List <int> numbers)
    {
        numbers.Sort();
    }
}