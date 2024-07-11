using System;

public class ChecklistGoal : Goal
{
    private int _target; //meta para o objetivo 
    private int _bonus; //bonus para o objetivo de checklist
    private int _amountCompleted; //quantidade de vezes que o objetivo de checklist foi completado

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0; //inicia com 0, padrão
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        _amountCompleted++; //incrementa a quantidade de vezes completadas 
        if (_amountCompleted >= _target)
        {
            return _points + _bonus; //retorna os pontos mais o bonus se a meta for alcançada
        }
        return _points; //retorna apenas os pontos
    }

    public string IsCompleteDetails()
    {
        return $"{_amountCompleted}/{_target}";
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDatailsString()
    {
        return $"[{(_amountCompleted >= _target ? "X" : " ")}] {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal, {_name}, {_description}, {_points}, {_amountCompleted}, {_target}, {_bonus}";
    }
}