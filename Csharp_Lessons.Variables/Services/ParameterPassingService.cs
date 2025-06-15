namespace Csharp_Lessons.Services;


public class ParameterPassingService
{
    // Methods to demonstrate passing parameters by value, by in, by ref, and by out
    public int Sum(int a, int b) => checked(a + b);                                    // Send a and b by value, so they are copied. We use checked to ensure that an overflow will throw an exception.
    public int Sum(in int a, in int b) => checked(a + b);                              // Send a and b by in, so they are not copied, but they are read-only.
    public int SumByRef(ref int a, ref int b) => checked(a + b);                       // Send a and b by ref, so they are not copied, and they can be modified. 
    public void SumByOut(int a, int b, out int result) => result = checked(a + b);     // Send a and b by value, but the result is sent by out, so it can be modified. We use checked to ensure that an overflow will throw an exception.


    public (T, T) SwapByValue<T>(T a, T b) where T : struct => (b, a);                 // Send a and b by value, so they are copied. We return a tuple with the swapped values.
    public (T, T) SwapByIn<T>(in T a, in T b) where T : struct => (b, a);              // Send a and b by in, so they are not copied, but they are read-only. We return a tuple with the swapped values.
    public void SwapByRef<T>(ref T a, ref T b) where T : struct => (a, b) = (b, a);    // Send a and b by ref, so they are not copied, and they can be modified. We swap the values using tuple deconstruction.


    public void CallAllMethods()
    {
        // Demonstrating parameter passing
        int x = 5, y = 10;
        Console.WriteLine($"Sum by value: {Sum(x, y)}");
        Console.WriteLine($"Sum by in: {Sum(in x, in y)}");

        int refX = 5, refY = 10;
        Console.WriteLine($"Sum by ref: {SumByRef(ref refX, ref refY)}");

        SumByOut(x, y, out var outResult);
        Console.WriteLine($"Sum by out: {outResult}");

        // Demonstrating swapping
        var (swappedA, swappedB) = SwapByValue(x, y);
        Console.WriteLine($"Swapped by value: {swappedA}, {swappedB}");

        var (swappedInA, swappedInB) = SwapByIn(in x, in y);
        Console.WriteLine($"Swapped by in: {swappedInA}, {swappedInB}");

        SwapByRef(ref refX, ref refY);
        Console.WriteLine($"Swapped by ref: {refX}, {refY}");
    }
}