using System;

class Program
{
    static void Main(string[] args)
    {
        // Cria uma instância da classe Address
        Address address1 = new Address("742 Main St", "Salt Lake", "Utah", "82456");
        Address address2 = new Address("1032 Freedom St", "São Paulo", "Brazil", "70154012");
        Address address3 = new Address("159 King St", "Madrid", "Espanha", "1456279");
        // Cria instâncias para cada tipo de evento
        Lecture lecture = new Lecture("Book of Mormon Devotional", "Talk about Come, Follow Me program", "2024-09-20", "8:00 PM", address1, "Brother Nephi Lehi", 150);

        Reception reception = new Reception("PRO English", "Annual graduation", "2024-10-11", "4:00 PM", address2, "rsvp@eventproenglish.com");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Music Festival", "Concert by various international groups", "2024-11-04", "6:00 PM", address3, "Partly cloudy with a chance of rain");

        // Marketing messages
        Console.WriteLine("LECTURE STANDARD DETAILS:\n" + lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("LECTURE FULL DETAILS:\n" + lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("LECTURE SHORT DESCRIPTION:\n" + lecture.GetShortDescription());
        Console.WriteLine("\n---------------------------\n");
        Console.WriteLine("RECEPTION STANDARD DETAILS:\n" + reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("RECEPTION FULL DETAILS:\n" + reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("RECEPTION SHORT DESCRIPTION:\n" + reception.GetShortDescription());
        Console.WriteLine("\n---------------------------\n");
        Console.WriteLine("OUTDOOR GATHERING STANDARD DETAILS:\n" + outdoorGathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("OUTDOOR GATHERING FULL DETAILS:\n" + outdoorGathering.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("OUTDOOR GATHERING SHORT DESCRIPTION:\n" + outdoorGathering.GetShortDescription());
    }
    
}