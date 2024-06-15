using System;

class Program
{
    static void Main(string[] args)
    {   
        string answerUser;
        do
        {
            //parte 1 and 2
            //Console.WriteLine("What is the magic number? ");
            //int number = int.Parse(Console.ReadLine());

            // parte 3, with random number
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);

            int guess = -1;
            int attempts = 0;

            while (guess != number)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");

                    Console.WriteLine($"You have made {attempts} attempts.");
                }
            }
        Console.WriteLine("Would you like to play again? yes/no: ");
        answerUser = Console.ReadLine().ToLower();
        } while (answerUser == "yes");
    }   
}