using System;
public abstract class ArrayBase : IDimension, IPrinter
{
    public void PublicInputArray()
    {
        InputArray();
    }
    protected abstract void InputArray();
    public void PublicRandomArray()
    {
        RandomArray();
    }
    protected abstract void RandomArray();
    public void PublicCreateArray(bool userValues = false)
    {
        CreateArray(userValues);
    }
    protected abstract void CreateArray(bool userValues = false);
    public abstract void Average();
    public abstract void Print();
    public abstract void Recreate(bool userValues = false);
}