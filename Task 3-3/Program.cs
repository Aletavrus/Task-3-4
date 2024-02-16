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
        Console.WriteLine();
        for (int i = 0; i<arrayBase.Length; i++)
        {
            arrayBase[i].Print();
            arrayBase[i].Average();
            Console.WriteLine();
        }
        WeekDays weekDays = new WeekDays();
        IPrinter[] printList = new IPrinter[arrayBase.Length + 1];
        for (int i = 0; i<printList.Length-1; i++ )
        {
            printList[i] = arrayBase[i];
        }
        printList[printList.Length-1] = weekDays;
        foreach ( IPrinter printer in printList )
        {
            printer.Print();
            Console.WriteLine();
        }
    }
}
