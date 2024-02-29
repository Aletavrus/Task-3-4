using System.Collections.Generic;

sealed class TwoDimension<T> : ArrayBase
{
    private T[,] _array;
    private IElementGenerator<T> _elementGenerator;
    public TwoDimension(IElementGenerator<T> elementGenerator, bool userValues = false)
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
        Console.WriteLine("Enter amount of lines of an array");
        int line = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter amount of columns of an array");
        int column = int.Parse(Console.ReadLine());
        _array = new T[line, column];
        base.CreateArray(userValues);
    }
    protected override void InputArray()
    {
        for (int i = 0; i < _array.GetLength(0); i++)
        {
            Console.WriteLine($"Enter values of 1 line in 1 string with spaces between elements (type must be {typeof(T)})");
            string input = Console.ReadLine();
            string[] inputList = input.Split();
            for (int j = 0; j < _array.GetLength(1); j++)
            {
                T inputToType = (T)Convert.ChangeType(inputList[j], typeof(T));
                _array[i, j] = inputToType;
            }

        }
    }

    protected override void RandomArray()
    {
        for (int i = 0; i< _array.GetLength(0); i++)
        {
            for (int j = 0; j < _array.GetLength(1);j++)
            {
                _array[i,j] = _elementGenerator.GenerateRandom();
            }
        }
    }

    public override void Print()
    {
        for (int i = 0; i<_array.GetLength(0); i++)
        {
            for (int j = 0; j<_array.GetLength(1); j++)
            {
                Console.Write($"{_array[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("And an array with reversed even lines");
        PrintEvenLines();
        Console.WriteLine();
    }

    private void PrintEvenLines() //элементы четных строк в обратном порядке
    {
        for (int i = 0; i < _array.GetLength(0); i++)
        {
            string line = "";
            for (int j = 0; j < _array.GetLength(1); j++)
            {
                if (j!=_array.GetLength(1)-1)
                {
                    line += _array[i, j].ToString() + " ";
                }
                else
                {
                    line += _array[i, j].ToString();
                }
            }
            if (i%2 == 0)
            {
                line = Reverse(line);
            }
            Console.WriteLine(line);
        }
    }

    private string Reverse(string s)
    {
        string reversed = "";
        string[] s_split = s.Split(' ');
        for (int k = s_split.Length -1; k>=0; k--)
        {
            reversed += s_split[k] + " ";
        }
        return reversed;
    }
}
