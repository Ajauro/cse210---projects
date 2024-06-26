using System;
using System.Collections.Generic;
using System.IO;

class Program
{   
    //create a instance
    static Journal journal = new Journal();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal program!");
        PromptGenerator promptGenerator = new PromptGenerator();

        bool executar = true;
        while (executar)
        {   
            //display menu to the user
            Menu();
            string choice = Console.ReadLine();
            //perform actions based on user's choice
            if (choice == "1")
            {
                NewEntry(promptGenerator);
                Console.WriteLine();
            }
            else if (choice == "2")
            {
                journal.Display();
            }
            else if (choice == "3")
            {
                LoadJournal();
                Console.WriteLine("Journal loaded successfully!");
                Console.WriteLine();
            }
            else if (choice == "4")
            {
                SaveJournal();
                Console.WriteLine("Journal saved successfully!");
                Console.WriteLine();
            }
            else if (choice == "5")
            {
                executar = false;
            }
            else
            {   
                //inform the user of an invalid choice and prompt to return to the menu
                Console.WriteLine("Invalid option! Press any key to return to the menu");
                Console.ReadKey();
                Console.WriteLine();
            }
        }
    }
    //display the menu options
    static void Menu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
    }
    // create a new journal entry
    static void NewEntry(PromptGenerator promptGenerator)
    {   
        //get a random prompt fot the entry
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        //add the new entry to the journal
        journal.AddEntry(new Entry { _date = DateTime.Now.ToShortDateString(), _prompt = prompt, _entryText = response });
    }
    //save the journal to a file que ja foi criado
    static void SaveJournal()
    {
        string filename = "journal.csv";
        journal.SaveToFile(filename);
    }
    //load the journal from a file que ja foi criado anteriormente
    static void LoadJournal()
    {
        string filename = "journal.csv";
        journal.LoadFromFile(filename);
    }
}
