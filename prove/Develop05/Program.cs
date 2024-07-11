using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;


//ponto de entrada do programa
//a função Main instancia a classe GoalManager e chama seu metodo Start()
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}

//Showing Creativity and Exceeding Requirements
//added another option to the menu, allowing you to exclude goals.
//It can be automatically deleted from the list, but can only be 
//permanently deleted from the file after saving before closing the program.