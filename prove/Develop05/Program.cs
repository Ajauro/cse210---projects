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

