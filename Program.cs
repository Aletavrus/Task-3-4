using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Note: ALWAYS answer with lower case letters");
        Console.WriteLine("Do you want to have randomly generated values in arrays?");
        string getCreationType = Console.ReadLine();
        bool userValues = false;
        if (getCreationType == "no")
        {
            userValues = true;
        }
        IPrinter[] printer = new IPrinter[2];
        IElementGenerator<string> stringGenerator = new StringGenerator();
        IElementGenerator<bool> boolGenerator = new BoolGenerator();
        printer[0] = new OneDimension<string>(stringGenerator, userValues);
        printer[1] = new TwoDimension<bool>(boolGenerator, userValues);
        for (int i =0; i < printer.Length; i++)
        {
            printer[i].Print();
        }
    }
}
