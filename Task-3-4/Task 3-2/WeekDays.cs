using System;
class WeekDays : IPrinter
{
    public void Print()
    {
        string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        Random random = new Random();
        int day = random.Next(1, 8);
        Console.WriteLine(days[day]);
    }
}