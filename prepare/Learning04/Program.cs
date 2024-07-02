using System;

public class Program
{
    public static void Main(string[] args)
    {
        //Assignment
        Assignment student1 = new Assignment("Olivia Benneth", "Division");
        Console.WriteLine(student1.GetSummary());
        Console.WriteLine("----------------");
        //Math Assignment
        MathAssignment student2 = new MathAssignment("Angelina Fritz", "Bhaskara", "9.3", "20-25");
        Console.WriteLine(student2.GetSummary());
        Console.WriteLine(student2.GetHomeworkList());
        Console.WriteLine("----------------");
        
        WritingAssignment student3 = new WritingAssignment("Johnny Sousa", "Literature", "The Little Prince");
        Console.WriteLine(student3.GetSummary());
        Console.WriteLine(student3.GetWritingInfo());
    }
}