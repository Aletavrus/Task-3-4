using System;
class WeekDays : IPrinter
{
    public void Print()
    {
        DayOfWeek dayOfWeek = DateTime.Today.DayOfWeek;
        Console.WriteLine($"Today is {dayOfWeek}");
    }
    public int Length()
    {
        return 0;
    }
}