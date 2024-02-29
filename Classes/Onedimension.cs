using System.Collections.Generic;
sealed class OneDimension<T> : ArrayBase
{
    private T[] _array;
    private IElementGenerator<T> _elementGenerator;
    public OneDimension(IElementGenerator<T> ElementGenerator, bool userValues = false)
    {
        _elementGenerator = ElementGenerator;
        CreateArray(userValues);
    }

    public override void Recreate(bool userValues = false)
    {
        CreateArray(userValues);
    }
    public override void Print()
    {
        Print(_array);
        Console.WriteLine();
    }

    private static void Print(T[] array)
    {
        for (int h = 0; h < array.Length; h++)
        {
            Console.Write($"{array[h]} ");
        }
        Console.WriteLine();
    }

    protected override void CreateArray(bool userValues = false)
    {
        Console.WriteLine("Enter size of an array");
        int size = int.Parse(Console.ReadLine());
        _array = new T[size];
        base.CreateArray(userValues);
    }

    protected override void InputArray()
    {
        Console.WriteLine($"Enter a string with all values of an array separated by spaces (type must be {typeof(T)})");
        string input = Console.ReadLine();
        string[] inputList = input.Split();
        for (int i = 0; i< inputList.Length; i++)
        {
            T inputToType = (T)Convert.ChangeType(inputList[i], typeof(T));
            _array[i] = inputToType;
        }
    }

    protected override  void RandomArray()
    {
        for (int i = 0; i < _array.Length;i++)
        {
            _array[i] = _elementGenerator.GenerateRandom();
        }
    }
}