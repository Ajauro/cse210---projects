using System;

public class WritingAssignment : Assignment //derived class
{

    private string _tittle;

    public WritingAssignment (string studentName, string topic, string tittle) : base(studentName, topic)
    {
        _tittle = tittle;
    }

    public string GetWritingInfo()
    {
        string studentName = GetStudentName();

        return $"{_tittle} by {studentName}";
    }

}