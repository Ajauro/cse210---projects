using System;

public class MathAssignment : Assignment //derived class
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }

}

    // public string GetTextbookSection()
    // {
    //     return _textbookSection;
    // }
    // public string GetProblems()
    // {
    //     return _problems;
    // }