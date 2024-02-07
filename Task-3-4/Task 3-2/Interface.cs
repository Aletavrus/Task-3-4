interface IDimension : IPrinter
{
    public void PublicInputArray();
    public void PublicRandomArray();
    public void PublicCreateArray(bool userValues = false);
    public void Average();
    public void Recreate(bool userValues = false);
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
