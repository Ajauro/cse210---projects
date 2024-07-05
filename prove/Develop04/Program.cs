using System;
using System.Collections.Generic;
using System.Threading;

    //Este programa é estruturado para fornecer várias atividades guiadas ao usuário, 
    //ajudando-o a focar em respiração, reflexão, listagem e gratidão, com cada atividade herdando 
    //funcionalidades comuns da classe pai Activity.

class Program
{   
    //metodo main: o ponto de entrada do programa. 
    //Exibe o menu, obtem a escolha do usuario e executa a atividade correspondente
    //o loop continua até a opção de saída pelo usuario
    static void Main(string[] args)
    {
        
        bool run = true;

        while (run)
        {
            Console.Clear(); //limpar terminal
            //display menu options
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing activity.");
            Console.WriteLine("2. Start Reflecting activity.");
            Console.WriteLine("3. Start Listing activity.");
            Console.WriteLine("4. Start Gratitude Diary activity.");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.Clear();

            //handle the user's menu choice
            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run(); 
                    break;
                case "2":
                    new ReflectingActivity().Run();
                    break;
                case "3":
                    new ListingActivity().Run();
                    break;
                case "4":
                    new GratitudeDiary().Run();
                    break;
                case "5":
                    run = false; // if the choice is invalid, display an error message and wait for 2s
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    Thread.Sleep(2000);
                    break;
            }
        }

    }
}