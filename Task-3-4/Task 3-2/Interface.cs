interface IDimension : IPrinter
{
    public abstract void PublicInputArray();
    public abstract void PublicRandomArray();
    public abstract void PublicCreateArray(bool userValues = false);
    public abstract void Average();
    public abstract void Recreate(bool userValues = false);
}

interface IPrinter
{
    public void Print();
}

interface IOneDimension
{
    public void DeleteOver();
    public void Unique();
}

interface ITwoDimension
{
    public int GetDeterminant();
}

interface IManyDimension
{
    public void EvenNumChange();
}