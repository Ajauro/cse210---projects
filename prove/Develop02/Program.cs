using System;
using System.Collections.Generic;
using System.IO;

class Program
{   
    static Journal journal = new Journal();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal program!");
        PromptGenerator promptGenerator = new PromptGenerator();

        bool executar = true;
        while (executar)
        {
            Menu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    NewEntry(promptGenerator);
                    break;
                case "2":
                    journal.Display();
                    break;
                case "3":
                    LoadJournal();
                    break;
                case "4":
                    SaveJournal();
                    break;
                case "5":
                    executar = false;
                    break;
                default:
                    Console.WriteLine("Invalid opition!");
                    break;
            }
        }
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");
    }

    static void NewEntry(PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        journal.AddEntry(new Entry {_date = DateTime.Now.ToShortDateString(), _prompt = prompt, _entryText = response});
    }

    static void SaveJournal()
    {
        Console.Write("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }

    static void LoadJournal()
    {
        Console.Write("Enter the filename to load the journal: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }
}

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void Display()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file) 
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine("Date,Prompt,Entry");

            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date}, {entry._prompt}, {entry._entryText}");
            }
        }
    }

    public void LoadFromFile (string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear();

            using (StreamReader reader = new StreamReader(file))
            {
                //ignora a linha de cabeçalho
                reader.ReadLine();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(",");
                    if (parts.Length == 3)
                    {
                        AddEntry (new Entry {_date = parts[0], _prompt = parts[1], _entryText = parts[2]});
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }
}

public class Entry
{
    public string _date {get; set;}
    public string _prompt {get; set;}
    public string _entryText {get; set;}

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }
}

public class PromptGenerator
{
    private List<string> _prompts;
    private Random _random;

    //classe que inicializa a lista de prompts e o gerador aleatorio
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        _random = new Random();
    }

    //metodo para retornar um prompt aleatorio da lista
    public string GetRandomPrompt()
    {
        int i = _random.Next(_prompts.Count);
        return _prompts[i];
    }
}