interface IDimension : IPrinter
{
    void PublicInputArray();
    void PublicRandomArray();
    void PublicCreateArray(bool userValues = false);
    void Average();
    void Recreate(bool userValues = false);
}

interface IPrinter
{
    void Print();
}

interface IOneDimension
{
    void DeleteOver();
    void Unique();
}

interface ITwoDimension
{
   int GetDeterminant();
}

interface IManyDimension
{
    void EvenNumChange();
}
