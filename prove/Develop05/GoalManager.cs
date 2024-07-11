using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

//responsavel por gerencias os goals
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>(); //lista para armazenar os objetivos
    private int _score; //pontuação do jogador

    public GoalManager()
    {
        _score = 0; //inicia a pontuação com 0
    }

    public void Start()
    {
        bool run = true;

        while (run)
        {
            Console.WriteLine();
            DisplayPlayerInfo();//mostra a pontuação do jogador
            DisplayMenu(); //mostra menu de opções
            string choice = Console.ReadLine(); //le a escolha do usuario

            switch (choice)
            {
                case "1":
                    CreateGoal(); //criar objetivo
                    break;
                case "2":
                    ListGoalDetails(); //listar objetivos
                    break;
                case "3":
                    SaveGoals(); //salvar em arquivo
                    break;
                case "4":
                    LoadGoals(); //carregar do arquivo
                    break;
                case "5":
                    RecordEvent(); //registrar eventos de conclusão
                    break;
                case "6":
                    DeleteGoal(); //excluir objetivos se quiser
                    break;
                case "7":
                    run = false; //sair
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again."); //coloquei opão de escolha invalida para o programa não fechar automaticamente caso tenha erro de digitação
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
    //menu de exibição para o usuario
    private void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Delete Goal");
        Console.WriteLine("7. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    private void DisplayPlayerInfo()
    {   
        // exibe a pontuação do jogador
        Console.WriteLine($"You have {_score} points.\n");
    }
    //lista os detalhes de todos os goals
    private void ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            if (_goals[i] is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"{i + 1}. {checklistGoal.GetDatailsString()}");
            }
            else
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDatailsString()}");
            }
        }
        Thread.Sleep(2000);
    }
    //permite a criação de um novo goal
    private void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goals");
        Console.Write("Which type of goal would you like to create? ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                _goals.Add(CreateSimpleGoal()); //cria simplegoal
                break;
            case "2":
                _goals.Add(CreateEternalGoal()); //cria eternalgoal
                break;
            case "3":
                _goals.Add(CreateChecklistGoal()); //cria checklistgoal
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                break;
        }
    }
    //cria um simple goal
    private SimpleGoal CreateSimpleGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        return new SimpleGoal(name, description, points);
    }
    //cria um eternal goal
    private EternalGoal CreateEternalGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        return new EternalGoal(name, description, points);
    }
    //cria um checklist goal
    private ChecklistGoal CreateChecklistGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing in that many times? ");
        int bonus = int.Parse(Console.ReadLine());
        return new ChecklistGoal(name, description, points, target, bonus);
    }
    //registra os eventos de conclusão dos goals
    private void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].Name}");
        }

        Console.Write("Which goal have you completed? Enter the number: ");
        int goalIndex;
        if (!int.TryParse(Console.ReadLine(), out goalIndex) || goalIndex < 1 || goalIndex > _goals.Count)
        {
            Console.WriteLine("Invalid input. Please enter a valid goal number.");
            Thread.Sleep(2000);
            return;
        }

        var selectedGoal = _goals[goalIndex - 1];
        int pointsEarned = selectedGoal.RecordEvent(); //registra o evento de conclusão do objetivo
        _score += pointsEarned; //soma e atualiza a pontuação do jogador

        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        Console.WriteLine($"You now have {_score} points.\n");

        //Console.WriteLine(selectedGoal.GetDatailsString());
        Thread.Sleep(2000);
    }
    //permiti a exclusão de um goal
    private void DeleteGoal()
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].Name}");
        }

        Console.Write("Which goal would you like to delete? Enter the number: ");
        int goalIndex;
        if (!int.TryParse(Console.ReadLine(), out goalIndex) || goalIndex < 1 || goalIndex > _goals.Count)
        {
            Console.WriteLine("Invalid input. Please enter a valid goal number.");
            Thread.Sleep(2000);
            return;
        }

        _goals.RemoveAt(goalIndex - 1); //remove o objetivo da lista, mas não remove do arquivo se não salvar antes de fechar o programa

        Console.WriteLine("Goal deleted successfully!");
        Console.WriteLine("OBS:. After deleting, Save to permanently delete the txt file.");
        Thread.Sleep(2000);
    }
    //salva os objetivos em um arquivo
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score); // Save the score atual
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation()); //salva a rpresentação em texto de cada objetivo
            }
        }
        Console.WriteLine("Goals saved successfully!");
        Thread.Sleep(2000);
    }
    //carrega os objetivos salvos de um arquivo
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _goals.Clear(); //limpa a lista de objetivos

            _score = int.Parse(lines[0]); //carrega a pontuação do jogador

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(", ");
                if (parts.Length < 4)
                {
                    continue;
                }
                string type = parts[0]; //tipo do objeto
                string name = parts[1]; //nome do objeto
                string description = parts[2]; //descrição do objeto
                int points = int.Parse(parts[3]); //pontos do objetivo

                switch (type)
                {
                    case "Simple Goal":
                        bool isComplete = bool.Parse(parts[4]); //verifica se o objetivo esta completo
                        _goals.Add(new SimpleGoal(name, description, points, isComplete)); //adciona um objetivo simples
                        break;
                    case "Eternal Goal":
                        bool eternalIsComplete = bool.Parse(parts[4]);//verifica se o objetivo esta completo
                        _goals.Add(new EternalGoal(name, description, points, eternalIsComplete)); //adciona um objetivo eterno
                        break;
                    case "Checklist Goal":
                        int amountCompleted = int.Parse(parts[4]); //quantidade de vezes que o objetivo foi completado
                        int target = int.Parse(parts[5]); //meta para o objetivo de checklist
                        int bonus = int.Parse(parts[6]); //bonus para o objetivo checklist
                        _goals.Add(new ChecklistGoal(name, description, points, target, bonus, amountCompleted)); //adciona um objetivo de checklist
                        break;
                    default:
                        Console.WriteLine("Unknown goal type found in file.");
                        break;
                }
            }
            Console.WriteLine("Goals loaded successfully!");
            Thread.Sleep(1000);
        }
        else
        {
            Console.WriteLine("No saved goals found.");
            Thread.Sleep(1000);
        }
    }
}
