
public class Entry
{
    public string _date {get; set;}
    public string _prompt {get; set;}
    public string _entryText {get; set;}

    //display the entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }
}