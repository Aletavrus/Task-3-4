using System.Collections.Generic;
class IntGenerator: IElementGenerator<int>
{
    private static Random _random = new Random();
    public int GenerateRandom()
    {
        return _random.Next(0, 100);
    }
}

class StringGenerator: IElementGenerator<string>
{
    private const string letters = "abcdefghijklmnopqrstuvwsyz";
    private static Random _random = new Random();
    public string GenerateRandom()
    {
        int length = _random.Next(1, 10);
        string stringToReturn = "";
        for (int i = 0; i < length; i++)
        {
            stringToReturn += letters[i];
        }
        return stringToReturn;
    }
}

class DoubleGenerator: IElementGenerator<double>
{
    private static Random _random = new Random();
    public double GenerateRandom()
    {
        int coeff = _random.Next(1, 10);
        double number = _random.NextDouble();
        number = Math.Round(number, 2, MidpointRounding.ToEven);
        return number*coeff;
    }
}

class BoolGenerator: IElementGenerator<bool>
{
    private static Random _random = new Random();
    public bool GenerateRandom()
    {
        bool flag = false;
        int determinant = _random.Next(0, 2);
        if (determinant == 1)
        {
            flag = true;
        }
        return flag;
    }
}