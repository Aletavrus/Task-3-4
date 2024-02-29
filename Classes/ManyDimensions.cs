using System.Collections.Generic;
sealed class ManyDimension<T>: ArrayBase
{
    private T[][] _array;
    private IElementGenerator<T> _elementGenerator;
    public ManyDimension(IElementGenerator<T> elementGenerator, bool userValues = false)
    {
        _elementGenerator = elementGenerator;
        CreateArray(userValues);
    }

    public override void Recreate(bool userValues = false)
    {
        CreateArray(userValues);
    }

    protected override void CreateArray(bool userValues = false)
    {
        Console.WriteLine("Enter amount of arrays in a big array");
        int size = int.Parse(Console.ReadLine());
        _array = new T[size][];
        base.CreateArray(userValues);
    }
    protected override void InputArray()
    {
        for (int i = 0; i < _array.Length; i++)
        {
            Console.WriteLine("Enter size of an inner array");
            int size = int.Parse(Console.ReadLine());
            _array[i] = new T[size];
            Console.WriteLine($"Enter values of an inner array in 1 string (type must be {typeof(T)})");
            string input = Console.ReadLine();
            string[] inputList = input.Split();
            for (int j = 0; j < _array[i].Length; j++)
            {
                T inputToType = (T)Convert.ChangeType(inputList[j], typeof(T));
                _array[i][j] = inputToType;
            }

        }
    }

    protected override void RandomArray()
    {
        for (int i = 0; i < _array.Length; i++)
        {
            int size = _random.Next(1, 5);
            _array[i] = new T[size];
            for (int j = 0; j < _array[i].Length; j++)
            {
                _array[i][j] = _elementGenerator.GenerateRandom();
            }
        }
    }

    public override void Print()
    {
        Print(_array);
        Console.WriteLine();
    }


    private static void Print(T[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j=0; j < array[i].Length; j++)
            {
                Console.Write($"{array[i][j]} ");
            }
            Console.WriteLine();
        }
    }
}
