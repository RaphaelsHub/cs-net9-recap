namespace Csharp_Lessons.Classes;

public class VariableLesson
{
    // Data types with size indications
    private readonly short shortValue; // 16-bit signed integer
    private readonly int intValue; // 32-bit signed integer
    private readonly long longValue; // 64-bit signed integer
    private readonly ushort ushortValue; // 16-bit unsigned integer
    private readonly uint uintValue; // 32-bit unsigned integer
    private readonly ulong ulongValue; // 64-bit unsigned integer
    private readonly bool boolValue; // Boolean type, 1 byte (true or false)
    private readonly float floatValue; // 32-bit floating-point type
    private readonly double doubleValue; // 64-bit floating-point type
    private readonly decimal decimalValue; // 128-bit floating-point type with higher precision
    private readonly byte byteValue; // 8-bit unsigned integer
    private readonly sbyte sbyteValue; // 8-bit signed integer
    private char CharValue { get; }
    private string StringValue { get; }

    //Time
    private DateTime BirthDateTime { get; set; }
    private DateTime PresentDateTime { get; set; }
    private TimeSpan TimeSpan { get; set; }

    //Random
    private Random Random { get; set; }

    public VariableLesson()
    {
        // Default values
        shortValue = 0;
        intValue = 0;
        longValue = 0;
        ushortValue = 0;
        uintValue = 0;
        ulongValue = 0;
        boolValue = false;
        floatValue = 0f;
        doubleValue = 0.0;
        decimalValue = 0m;
        byteValue = 0;
        sbyteValue = 0;
        CharValue = 'A';
        StringValue = "Hello";

        // Time
        BirthDateTime = new DateTime(2003, 5, 24);
        PresentDateTime = DateTime.Now;
        TimeSpan = PresentDateTime - BirthDateTime;

        // Random
        Random = new Random();
    }

    public void VariablePropreties()
    {
        Console.WriteLine(
            $"ShortMinValue: {short.MinValue}, ShortMaxValue: {short.MaxValue}, ShortSize: {sizeof(short)}, ShortValue: {shortValue}");
        Console.WriteLine(
            $"IntMinValue: {int.MinValue}, IntMaxValue: {int.MaxValue}, IntSize: {sizeof(int)}, IntValue: {intValue}");
        Console.WriteLine(
            $"LongMinValue: {long.MinValue}, LongMaxValue: {long.MaxValue}, LongSize: {sizeof(long)}, LongValue: {longValue}");
        Console.WriteLine(
            $"UShortMinValue: {ushort.MinValue}, UShortMaxValue: {ushort.MaxValue}, UShortSize: {sizeof(ushort)}, UShortValue: {ushortValue}");
        Console.WriteLine(
            $"UIntMinValue: {uint.MinValue}, UIntMaxValue: {uint.MaxValue}, UIntSize: {sizeof(uint)}, UIntValue: {uintValue}");
        Console.WriteLine(
            $"ULongMinValue: {ulong.MinValue}, ULongMaxValue: {ulong.MaxValue}, ULongSize: {sizeof(ulong)}, ULongValue: {ulongValue}");
        Console.WriteLine($"BoolSize: {sizeof(bool)}, BoolValue: {boolValue}");
        Console.WriteLine(
            $"FloatMinValue: {float.MinValue}, FloatMaxValue: {float.MaxValue}, FloatSize: {sizeof(float)}, FloatValue: {floatValue}");
        Console.WriteLine(
            $"DoubleMinValue: {double.MinValue}, DoubleMaxValue: {double.MaxValue}, DoubleSize: {sizeof(double)}, DoubleValue: {doubleValue}");
        Console.WriteLine(
            $"DecimalMinValue: {decimal.MinValue}, DecimalMaxValue: {decimal.MaxValue}, DecimalSize: {sizeof(decimal)}, DecimalValue: {decimalValue}");
        Console.WriteLine(
            $"ByteMinValue: {byte.MinValue}, ByteMaxValue: {byte.MaxValue}, ByteSize: {sizeof(byte)}, ByteValue: {byteValue}");
        Console.WriteLine(
            $"SByteMinValue: {sbyte.MinValue}, SByteMaxValue: {sbyte.MaxValue}, SByteSize: {sizeof(sbyte)}, SByteValue: {sbyteValue}");
        Console.WriteLine(
            $"CharMinValue: {char.MinValue}, CharMaxValue: {char.MaxValue}, CharSize: {sizeof(char)}, CharValue: {CharValue}");
        Console.WriteLine($"StringValue: {StringValue}");
        Console.WriteLine($"BirthDateTime: {BirthDateTime}, PresentDateTime: {PresentDateTime}, TimeSpan: {TimeSpan}");
    }

    public void MathStaticFunctions()
    {
        Console.WriteLine((int)Math.Round(10.5, MidpointRounding.ToZero)); //10
        Console.WriteLine((int)Math.Round(10.5, MidpointRounding.AwayFromZero)); //11
        Console.WriteLine(Math.Abs(-10));
        Console.WriteLine(Math.Acos(0.4));
        Console.WriteLine(Math.Cos(90));
        Console.WriteLine(Math.Pow(2, 4));
        Console.WriteLine(Math.Sqrt(100));
        Console.WriteLine(Math.PI * Math.Pow(3, 2)); //pi*r^2
    }

    public void BoxingUnboxingTest()
    {
        object obj = 1; // Создали объект ссылочного типа, где значение 1 будет упаковано и выделено на куче
        ref object unused = ref obj; // Присвоили ссылку объекта ссылочному типу
        int unused1 = (int)obj; // Значение было извлечено из упакованного объекта и приведено к типу int
    }

    public void RandomNumsTest()
    {
        int secondRandom = Random.Next(1, 10);
        int firstRandom = Random.Next(1, 10);
        var doubleRandom = Random.NextDouble() * 10;

        checked
        {
            var unused = firstRandom + secondRandom;
        }

        var (first, second) = Swap(firstRandom, secondRandom);
        Swap(ref firstRandom, ref secondRandom);
        Sum(firstRandom, secondRandom, out int sum);
        Console.WriteLine(
            $"First random: {firstRandom}, Second random: {secondRandom} and double random: {doubleRandom}");
        Console.WriteLine($"First random: {first}, Second random: {second} and double random: {doubleRandom}");
    }

    private void Sum<T>(in T firstRandom, in T secondRandom, out T sum) where T : struct
    {
        double doubleSum = Convert.ToDouble(firstRandom) + Convert.ToDouble(secondRandom);
        sum = (T)Convert.ChangeType(doubleSum, typeof(T));
    }

    private (T, T) Swap<T>(T firstRandom, T secondRandom)
    {
        T temp = firstRandom;
        firstRandom = secondRandom;
        secondRandom = temp;

        return (firstRandom, secondRandom);
    }

    private void Swap<T>(ref T firstRandom, ref T secondRandom)
    {
        T temp = firstRandom;
        firstRandom = secondRandom;
        secondRandom = temp;
    }
}