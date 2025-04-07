namespace Csharp_Lessons.Classes;

public struct TestValue(int x, int y)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;
    public void Print() => Console.WriteLine(nameof( TestValue) + " " + X + " " + Y);
}