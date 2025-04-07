namespace Csharp_Lessons.Classes;

public class TestRef(int x, int y)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;
    public void Print() => Console.WriteLine(nameof(TestRef) + " " + X + " " + Y);
}