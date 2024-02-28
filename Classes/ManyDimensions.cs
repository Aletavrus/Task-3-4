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
        for (int i = 0; i < _array.GetLength(0); i++)
        {
            Console.WriteLine("Enter values of 1 line in 1 string with spaces between elements");
            string input = Console.ReadLine();
            string[] inputList = input.Split();
            for (int j = 0; j < inputList.GetLength(1); j++)
            {
                T inputToType = (T)Convert.ChangeType(inputList[j], typeof(T));
                _array[i][j] = inputToType;
            }

        }
    }

    protected override void RandomArray()
    {
        for (int i = 0; i < _array.GetLength(0); i++)
        {
            for (int j = 0; j < _array.GetLength(1); j++)
            {
                _array[i][j] = _elementGenerator.GenerateRandom();
            }
        }
    }

    public override void Print()
    {
        Print(_array);
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
