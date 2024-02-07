using System.ComponentModel.DataAnnotations.Schema;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Note: ALWAYS answer with lower case letters");
        Console.WriteLine("Do you want to have randomly generated values in array?");
        string getCreationType = Console.ReadLine();
        bool userValues = false;
        if (getCreationType == "no")
        {
            userValues = true;
        }
        IDimension[] arrayBase = new IDimension[3];
        arrayBase[0] = new OneDimension(userValues);
        arrayBase[1] = new TwoDimension(userValues);
        arrayBase[2] = new ManyDimension(userValues);
        for (int i = 0; i<arrayBase.Length; i++)
        {
            arrayBase[i].Average();
            arrayBase[i].Print();
            Console.WriteLine();
        }
        WeekDays weekDays = new WeekDays();
        for (int i = 0; i<arrayBase.Length; i++)
        {
            arrayBase[i].Print();
        }
        weekDays.Print();
    }
}
