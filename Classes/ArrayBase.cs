using System;
public abstract class ArrayBase : IDimension
{
    protected static Random _random = new Random();
    protected virtual void CreateArray(bool userValues = false)
    {
        if (userValues)
        {
            InputArray();
        }
        else
        {
            RandomArray();
        }
    }
    protected abstract void InputArray();
    protected abstract void RandomArray();
    public abstract void Print();
    public abstract void Recreate(bool userValues = false);
}
