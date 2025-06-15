namespace Csharp_Lessons.Services;


public class MathOperationsService
{
    private readonly Random _random = new();

    public void DemonstrateMathLibrary()
    {
        int angle = 30;
        double radians = angle * Math.PI / 180;

        Console.WriteLine($"Sin({angle}°) = {Math.Sin(radians):F4}");
        Console.WriteLine($"Cos({angle}°) = {Math.Cos(radians):F4}");
        Console.WriteLine($"Tan({angle}°) = {Math.Tan(radians):F4}");
        Console.WriteLine($"{angle} squared = {Math.Pow(angle, 2)}");
        Console.WriteLine($"{angle} cubed = {Math.Pow(angle, 3)}");
        Console.WriteLine($"Square root of {angle} = {Math.Sqrt(angle):F2}");
        Console.WriteLine($"Log base 2 of {angle} = {Math.Log2(angle):F4}");
        Console.WriteLine($"Log base 10 of {angle} = {Math.Log10(angle):F4}");
        Console.WriteLine($"Natural log of {angle} = {Math.Log(angle):F4}");
        Console.WriteLine($"Absolute value of -{angle} = {Math.Abs(-angle)}");
        Console.WriteLine($"Max of 10 and 20 = {Math.Max(10, 20)}");
        Console.WriteLine($"Min of 10 and 20 = {Math.Min(10, 20)}");

        Console.WriteLine($"Random number between 1 and 100: {GenerateRandomInt(1, 100)}");
        Console.WriteLine($"Random double between 0.0 and 1.0: {GenerateRandomDouble():F4}");
        Console.WriteLine($"Random boolean: {GenerateRandomBool()}");

        Console.WriteLine($"E is approximately: {Math.E:F4}");
        Console.WriteLine($"Pi is approximately: {Math.PI:F4}");

        Console.WriteLine($"Rounded value of 10.527 to 1 decimal place: {Math.Round(10.527, 1)}");
        Console.WriteLine($"Rounded value of 10.527 to nearest integer: {Math.Round(10.527)}");
        Console.WriteLine($"Rounded value of 10.527 to nearest integer (AwayFromZero): {Math.Round(10.527, MidpointRounding.AwayFromZero)}");
        Console.WriteLine($"Rounded value of 10.527 to nearest integer (ToZero): {Math.Round(10.527, MidpointRounding.ToZero)}");
    }

    private int GenerateRandomInt(int min, int max) => _random.Next(min, max + 1);
    private double GenerateRandomDouble() => _random.NextDouble();
    private bool GenerateRandomBool() => _random.Next(0, 2) == 1;
}