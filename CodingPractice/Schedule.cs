using System;
using System.Collections.Generic;
using System.Text;

public class Schedule
{
    string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

    public void PrintWeekDays()
    {
        foreach (string day in weekDays)
        {
            Console.Write(day);
            Console.Write('\t');
        }
    }
}