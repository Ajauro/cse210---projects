using System;

//classe abstrata e serve como base para diferentes tipos de objetivos.

public abstract class Goal
{
    protected string _name; //nome do objetivo
    protected string _description; //descrição
    protected int _points; //pontos associados

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string Name => _name; //leitura para acessar o nome do objetivo
    public string Description => _description; //leitura para acessar a descrição
    public int Points => _points;//leitura para acessar os pontos associados

    //Método abstrato para registrar um evento relacionado ao objetivo (deve ser implementado nas subclasses)
    public abstract int RecordEvent();
     // Método abstrato para verificar se o objetivo está completo (deve ser implementado nas subclasses)
    public abstract bool IsComplete();
     // Método abstrato para obter uma representação detalhada do objetivo (deve ser implementado nas subclasses)
    public abstract string GetDatailsString();
     // Método abstrato para obter uma representação em formato de string do objetivo (deve ser implementado nas subclasses)
    public abstract string GetStringRepresentation();
}
