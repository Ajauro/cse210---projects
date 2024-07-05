using System;
public class Activity //parent class for all activities
{

    protected string _name; //noma de cada atividade
    protected string _description; //descrição de cada atividade
    protected int _duration; //duração de cada atividade em segundos

    // display the starting message of the activity
    //metodo: exibe uma mensagem de boas vindas, a descrição, pergunta ao usuario a duração 
    //e mostra um spinner e um timer
    public void DisplayStartingMessage()
    {   
        //start with a common starting message that provides the name of the activity, 
        //a description, and asks for and sets the duration of the activity in seconds.
        Console.WriteLine($" ≫ Welcome to the {_name}."); //name of the activity
        Console.WriteLine($"\nDescription: {_description}"); //description
        Console.Write("How long, in seconds, would you like for your session? "); //duration in seconds
        _duration = int.Parse(Console.ReadLine()); //recebe a resposta do user
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5); // Mostra o spinner por 5 segundos

    }

    //display mensagem final em cada atividade
    //metodo: exibe uma mensagem Well Done e mostra um spinner para finalizar a atividade
    public void DisplayEndingMessage()
    {   
        Console.WriteLine();
        Console.WriteLine("Well Done!!\n");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(4);

    }

    //show a spinner animation for a given number of seconds
    //metodo: exibe a animação spinner por um tempo especifico em segundos
    public void ShowSpinner( int seconds)
    {
         List<string> animationString = new List<string>
        {
            "|",
            "/",
            "-",
            "\\",
            "|",    //formatos do spinner
            "/",
            "-",
            "\\"
        };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int counter = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[counter % animationString.Count]);
            Thread.Sleep(300); // Intervalo entre cada quadro da animação
            Console.Write("\b \b"); // Move o cursor uma posição para trás

            counter++;
        }

        Console.Write(" "); // Limpa o último caractere do spinner
        Console.Write("\b \b"); // Move o cursor uma posição para trás
    }

    //show a countdown timer
    //metodo: exibe um temporizar regressivo
    public void ShowCountDown( int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}

