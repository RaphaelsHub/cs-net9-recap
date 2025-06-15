namespace Csharp_Lessons.Classes;

public class ReferenceType(int x, int y)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;
    
    public override string ToString() => $"{nameof(ReferenceType)} X: {X} Y: {Y}";
    public void Print() => Console.WriteLine(ToString());
}