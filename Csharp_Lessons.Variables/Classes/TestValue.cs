namespace Csharp_Lessons.Classes;

public struct TestValue
{
    public int X { get; set; }
    public int Y { get; set; }
    public void Print() => Console.WriteLine(X + " " + Y);
}