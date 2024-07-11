using System;
using System.IO;

public class SimpleGoal : Goal
{
    private bool _isComplete; //indicar se um objetivo esta completo ou não

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false; //inicia como não completo(padrão)
    }

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete; //inicializa com o estado de completo informado
    }
    //registra o evento de conclusão do objetivo
    public override int RecordEvent()
    {
        _isComplete = true; // Marca como completo
        return _points; // Retorna os pontos
    }
    //verifica se o objetivo está completo
    public override bool IsComplete() => _isComplete;
    //obtem um rprsentação dtalhada do objetivo
    public override string GetDatailsString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_name} ({_description})";
    }
    //representação tambem, só que em formato de string
    public override string GetStringRepresentation()
    {
        return $"Simple Goal, {_name}, {_description}, {_points}, {_isComplete}";
    }
}
