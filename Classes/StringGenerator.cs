using System;

class StringGenerator : IElementGenerator<string>
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
