using System;
using System.Collections.Generic;
using System.Linq;

class Program
{   
    static void Main(string[] args)
    {   
        
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that He gave his one and only Son that whoever believes in him shall not perish but have eternal life");

        scripture.HideRandomWords(3);
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine(scripture.IsCompletelyHidden());

        Console.WriteLine(scripture.GetDisplayText());

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All the words are hidden. Finish");
                break;
            }

            Console.WriteLine("Press 'enter' to hide the words or type 'quit' to close the program");
            string input = Console.ReadLine();
            if (input.Trim().ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(2);
        }
    }
}