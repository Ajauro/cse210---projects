using System;
using System.Collections.Generic;
using System.Threading;
//Help the user pace their breathing to have a session of deep breathing for 
//a certain amount of time. They might find more peace and less stress through the exercise.

public class BreathingActivity : Activity //child
{

    //construtor: inicializa o name e descrição especifico da atividade
    public BreathingActivity()
    {
        _name = "Breating Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. \nClear your mind and focus on your breathing.\n";
    }

    //run the breating activity
    //metodo: gerencia a execução da atividade.
    public void Run()
    {
        DisplayStartingMessage();

        for (int i = 0; i < _duration / 6; i++)
        {   
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(5);
            Console.WriteLine();
        }
        //mostrar a imagem de encerramento depois de executar a atividade
        DisplayEndingMessage();
    }
}