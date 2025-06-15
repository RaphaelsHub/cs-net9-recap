namespace Csharp_Lessons.Services;

public class LoopsService
{
    public void DemonstrateLoops()
    {
        int[] numbers = { 1, 4, 7, 10, 13, 16, 19, 22 };

        Console.WriteLine("For loop:");
        for (int i = 0; i < numbers.Length; i++)
            Console.Write(numbers[i] + " ");

        Console.WriteLine("\nForeach loop:");
        foreach (var num in numbers)
            Console.Write(num + " ");

        Console.WriteLine("\nWhile loop:");
        int j = 0;
        while (j < numbers.Length)
            Console.Write(numbers[j++] + " ");

        Console.WriteLine("\nDo-while loop:");
        int k = 0;
        do Console.Write(numbers[k++] + " ");
        while (k < numbers.Length);
    }
}