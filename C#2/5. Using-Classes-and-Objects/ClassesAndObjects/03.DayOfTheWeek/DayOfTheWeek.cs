﻿//Write a program that prints to the console which day of the week is today. Use System.DateTime.


using System;
class DayOfTheWeek
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine(now.DayOfWeek);
    }
}