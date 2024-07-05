using System;
using System.Collections.Generic;
using System.Threading;
//Guide the user to think deeply, by having them consider a certain experience when they were successful or demonstrated strength. 
//Then, prompt them with questions to reflect more deeply about details of this experience. They might discover more depth than they previously realized.

public class ReflectingActivity : Activity //child
{

    private List<string> _prompts; //lista de prompts para reflexão
    private List<string> _questions; //lista de questoes para reflexão

    //contrutor pra initicar atividade de reflexão
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.\n";

        _prompts = new List<string>
        {
            "--- Think of a time when you stood up for someone else. ---",
            "--- Think of a time when you did something really difficult. ---",
            "--- Think of a time when you helped someone in need. ---",
            "--- Think of a time when you did something truly selfless. ---"
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you? ",
            "Have you ever done anything like this before? ",
            "How did you get started? ",
            "How did you feel when it was complete? ",
            "What made this time different than other times when you were not as successful? ",
            "What is your favorite thing about this experience? ",
            "What could you learn from this experience that applies to other situations? ",
            "What did you learn about yourself through this experience? ",
            "How can you keep this experience in mind in the future? "
        };
    }

    //Gerencia a execução da atividade de reflexão. Envolve exibir um prompt aleatório e pedir 
    //ao usuário que reflita sobre uma série de perguntas.
    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        //Console.WriteLine();
        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue.\n");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            //DisplayPrompt();
            DisplayQuestions(); //display questions one by one
        }

        DisplayEndingMessage();
    }

    //metodo: Retorna um prompt aleatório da lista.
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    //metodo: Retorna uma pergunta aleatória da lista.
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowSpinner(5);
    }

    //metodo: Exibe cada pergunta e dá tempo para o usuário refletir.
    public void DisplayQuestions()
    {
        foreach (var question in _questions)
        {
            Console.Write(question);
            ShowSpinner(5);
            Console.WriteLine();
        }
    }

}