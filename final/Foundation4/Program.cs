using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running("30 Nov 2021", 40, 60.0),
            new Cycling("16 Jan 2022", 25, 70.0),
            new Swimming("11 Sep 2023", 60, 30)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}