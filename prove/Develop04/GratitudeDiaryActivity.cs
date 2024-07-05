using System;

//Showing Creativity and Exceeding Requirements
//Adding another kind of activity.

public class GratitudeDiary : Activity
{   
    private int _list; //usado para armazenar o número de itens listados.

    //construtor que inicializa a classe
    public GratitudeDiary()
    {
        _name = "Gratitude Diary Activity";
        _description = "This activity will help you reflect by making you think about and write down things you are grateful for. \nClear your mind and concentrate on remembering the little things.\n";
    }

    //executar a atividade
    //metodo: Gerencia a execução da atividade de diário de gratidão. 
    //Envolve coletar a entrada do usuário sobre coisas pelas quais ele é grato durante a duração da atividade.
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("List as many things as possible for which you are grateful: ");
        Thread.Sleep(1000);
        Console.Write("You may begin in: ");
        ShowCountDown(3);
        Console.WriteLine();
        //Console.WriteLine(">>> "); // Mostrar a mensagem após a contagem regressiva

        List<string> userResponse = GetList();
        _list = userResponse.Count;

        Console.WriteLine($"You listed {_list} items!");

        DisplayEndingMessage();
    }

    //metodo: Coleta e retorna uma lista de respostas do usuário.
    private List<string> GetList()
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
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