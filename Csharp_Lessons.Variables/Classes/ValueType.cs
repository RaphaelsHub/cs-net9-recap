namespace Csharp_Lessons.Classes;

public struct ValueType(int x, int y)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;
    
    public override string ToString() => $"{nameof(ValueType)} X: {X} Y: {Y}";
    public void Print() => Console.WriteLine(ToString());
}