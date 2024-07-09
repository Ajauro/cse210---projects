using System;
using System.Collections.Generic;
using System.Threading;
//Guide the user to think broadly, by helping them list as many things as they can in a 
//certain area of strength or positivity. They might discover more breadth than they previously realized.

public class ListingActivity : Activity //child
{
    private int _count; //armazena o numero de itens listados
    private List<string> _prompts; //armazena os prompts

    //contrutor que inicializa a listing activity classe
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life \nby having you list as many things as you can in a certain area.\n";
        
        _prompts = new List<string>
        {
            "--- Who are people that you appreciate? ---",
            "--- What are personal strengths of yours? ---",
            "--- Who are people that you have helped this week? ---",
            "--- When have you felt the Holy Ghost this month? ---",
            "--- Who are some of your personal heroes? ---"
        };  
    }

    //metodo: executar a atividade de listing
    //Gerencia a execução da atividade de listagem. 
    //Envolve exibir um prompt aleatório e coletar a 
    //entrada do usuário durante a duração da atividade
    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt(); //get a random prompt
        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt: \n");
        Console.WriteLine(prompt);
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountDown(5); 
        Console.WriteLine();
        //Console.WriteLine(">>> "); // Mostrar a mensagem após a contagem regressiva
        List<string> userResponse = GetListFromUser(); //get the user's responses
        _count = userResponse.Count;

        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }

    //metodo: get a random prompt from the list od prompts
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    //metodo: obter a lista de resposta do usuario
    private List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {   
            //prompt user for input
            Console.Write(">>> "); // Mostrar a mensagem antes de cada entrada do usuário
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input);
            }
        }

        return responses;
    }
}