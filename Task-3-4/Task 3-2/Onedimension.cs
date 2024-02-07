
sealed class OneDimension:ArrayBase, IOneDimension, IPrinter
{
    private Random _random = new Random();
    private int[] _array;
    public OneDimension(bool userValues = false)
    {
        Recreate(userValues);
    }

    public override void Recreate(bool userValues = false)
    {
        CreateArray(userValues);
    }

    public override void Print()
    {
        Print(_array);
    }

    private static void Print(int[] array)
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
        _array = new int[size];
        if (!userValues)
        {
            RandomArray();
        }
        else
        {
            InputArray();
        }
    }

    protected override void RandomArray()
    {
        for (int i = 0; i < _array.Length; i++)
        {
            _array[i] = _random.Next(0, 100);
        }
    }

    protected override void InputArray()
    {
        Console.WriteLine("Enter a string with all values of an array separated by spaces");
        string input = Console.ReadLine();
        string[] inputLst = input.Split();
        for (int i = 0; i < _array.Length; i++)
        {
            _array[i] = int.Parse(inputLst[i]);
        }
    }


    public override void Average()
    {
        int summ = 0;
        foreach (int number in _array)
        {
            summ += number;
        }
        decimal avg = summ / _array.Length;
        Console.WriteLine($"Average = {avg}");
    }

    public void DeleteOver()
    {
        int newArrayLength = _array.Length;
        for (int x = 0; x < _array.Length; x++)
        {
            if (Math.Abs(_array[x]) > 100)
            {
                newArrayLength--;
            }
        }
        int[] array2 = new int[newArrayLength];
        int counter = 0;
        for (int x = 0 ; x < _array.Length ; x++)
        {
            if (!(Math.Abs(_array[x]) > 100))
            {
                array2[counter] = _array[x];
                counter++;
            }
        }
        Print(array2);
    }


    public void Unique()
    {
        int newArrayLength = _array.Length;
        for (int i = 0; i < _array.Length; i++)
        {
            for (int j = i; j < _array.Length; j++)
            {

                if (_array[i] == _array[j] && i != j)
                {
                    newArrayLength--;
                    break;
                }
            }
        }
        int counter = 0;
        int[] newArray = new int[newArrayLength];
        for (int a = 0; a < _array.Length; a++)
        {
            if (!Contain(newArray, _array[a]))
            {
                newArray[counter] = _array[a];
                counter++;
            }
        }
        Print(newArray);
    }

    public bool Contain(int[] array, int symb)
    {
        for (int g = 0; g < array.Length; g++)
        {
            if (symb == array[g])
            {
                return true;
            }
        }
        return false;
    }
}