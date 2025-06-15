namespace Csharp_Lessons.Services;


public class ConditionsService
{
    public void PrintDayOfWeek(int day)
    {
        switch (day)
        {
            case 1: Console.WriteLine("Monday"); break;
            case 2: Console.WriteLine("Tuesday"); break;
            case 3: Console.WriteLine("Wednesday"); break;
            case 4: Console.WriteLine("Thursday"); break;
            case 5: case 6: case 7: Console.WriteLine("Weekend"); break;
            default: Console.WriteLine("Invalid day"); break;
        }
    }

    public void EvaluateTemperature(int temp)
    {
        if (temp >= 30) Console.WriteLine("Hot");
        else if (temp >= 20) Console.WriteLine("Warm");
        else if (temp >= 10) Console.WriteLine("Cool");
        else Console.WriteLine("Cold");
    }

    public void CheckEvenOdd(int number)
    {
        if (number % 2 == 0) Console.WriteLine("Even");
        Console.WriteLine("Odd");
    }
}