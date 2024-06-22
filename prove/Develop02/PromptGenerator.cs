// using System;
// using System.Collections.Generic;
// using System.IO;

// public class PromptGenerator
// {
//     private List<string> _prompts;
//     private Random _random;

//     //classe que inicializa a lista de prompts e o gerador aleatorio
//     public PromptGenerator()
//     {
//         _prompts = new List<string>
//         {
//             "Who was the most interesting person I interacted with today?",
//             "What was the best part of my day?",
//             "How did I see the hand of the Lord in my life today?",
//             "What was the strongest emotion I felt today?",
//             "If I had one thing I could do over today, what would it be?"
//         };
//         _random = new Random();
//     }

//     //metodo para retornar um prompt aleatorio da lista
//     public string GetRandomPrompt()
//     {
//         int i = _random.Next(_prompts.Count);
//         return _prompts[i];
//     }
// }