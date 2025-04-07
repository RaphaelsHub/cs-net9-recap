namespace Csharp_Lessons.Classes;

public class Variables
{
    // Primitive data types
    private readonly sbyte _sbyteValue = sbyte.MinValue;                // 8-bit signed integer
    private readonly byte _byteValue = byte.MaxValue;                   // 8-bit unsigned integer
    
    private readonly short _shortValue = short.MinValue;               // 16-bit signed integer
    private readonly ushort _ushortValue = ushort.MaxValue;            // 16-bit unsigned integer
    
    private readonly int _intValue = int.MinValue;                     // 32-bit signed integer
    private readonly uint _uintValue = uint.MaxValue;                  // 32-bit unsigned integer
    
    private readonly long _longValue = long.MinValue;                  // 64-bit signed integer
    private readonly ulong _ulongValue = ulong.MaxValue;               // 64-bit unsigned integer
    
    private readonly float _floatValue = float.MinValue;               // 32-bit floating-point type
    private readonly double _doubleValue = double.MaxValue;            // 64-bit floating-point type
    
    private readonly decimal _decimalValue = 9m;                      // 128-bit floating-point type with higher precision
    
    private readonly bool _boolValue = true;                          // 8-bit boolean type (true/false)
    
    
    // Symbolic and reference data types
    private readonly char _charValue = 'c';                          // 16-bit Unicode character
    private readonly string _stringValue = "Hello";                  // String type (immutable sequence of characters)
    
    // Time
    private static DateTime BirthDateTime { get; set; } = new DateTime(2003, 5, 24);
    private static DateTime PresentDateTime { get; set; } = DateTime.Now;
    private TimeSpan DateTimeDiff { get; set; } = PresentDateTime - BirthDateTime;

    //Random
    private Random Random { get; set; } = new Random();

    public void PrintAllVariables()
    {
        Console.WriteLine(
            $"Signed byte value: {_sbyteValue}, size: {sizeof(sbyte)}" +
            $"\nUnsigned byte value: {_byteValue}, size: {sizeof(byte)}" +
            $"\nShort value: {_shortValue}, size: {sizeof(short)}" +
            $"\nUnsigned short value: {_ushortValue}, size: {sizeof(ushort)}" +
            $"\nInt value: {_intValue}, size: {sizeof(int)}" +
            $"\nUnsigned int value: {_uintValue}, size: {sizeof(uint)}" +
            $"\nLong value: {_longValue}, size: {sizeof(long)}" +
            $"\nUnsigned long value: {_ulongValue}, size: {sizeof(ulong)}" +
            $"\nFloat value: {_floatValue}, size: {sizeof(float)}" +
            $"\nDouble value: {_doubleValue}, size: {sizeof(double)}" +
            $"\nDecimal value: {_decimalValue}, size: {sizeof(decimal)}" +
            $"\nBoolean value: {_boolValue}, size: {sizeof(bool)}" +
            $"\nChar value: {_charValue}, size: {sizeof(char)}" +
            $"\nString value: {_stringValue}" +
            $"\nBirthDay DateTime value: {BirthDateTime}" + 
            $"\nPresent DateTime value: {PresentDateTime}" +
            $"\nTimeSpan value: {DateTimeDiff}");
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
    
    // in - readonly reference type
    // ref - writeable reference type
    // out - writeable reference type, but it must be initialized in the method
    public void RandomNumsTest()
    {
        int firstRandom = Random.Next(1, 10);
        int secondRandom = Random.Next(1, 10);
        var doubleRandom = Random.NextDouble() * 10;

        Console.WriteLine($"FirstRandom {firstRandom}, SecondRandom {secondRandom}, DoubleRandom {doubleRandom} before");
        Console.WriteLine($"Sum of random nums {Sum(firstRandom, secondRandom)}");
        Sum(firstRandom, secondRandom, out int sum);
        Console.WriteLine($"Sum of random nums (out version): {sum}");
        
        Swap(firstRandom, secondRandom);
        Console.WriteLine($"FirstRandom {firstRandom}, SecondRandom {secondRandom}, after swap without ref");
        
        Swap(ref firstRandom, ref secondRandom);
        Console.WriteLine($"FirstRandom {firstRandom}, SecondRandom {secondRandom}, after swap with ref");
        
        // Здесь мы не меняем значения переменных firstRandom и secondRandom, а просто меняем их местами
        var (first, second) = SwapImmutable(firstRandom, secondRandom);
        Console.WriteLine($"FirstRandom {first}, SecondRandom {second}, after swap with tuple");
        
        var train = SwapImmutable(firstRandom, secondRandom);
        Console.WriteLine($"FirstRandom {train.Item1}, SecondRandom {train.Item2}, after swap with tuple");
    }
    
    // Sum method overloading
    private int Sum(in int firstRandom, in int secondRandom)
    {
        int sumOfRandoms;
        checked { sumOfRandoms = firstRandom + secondRandom; }
        return sumOfRandoms;
    } 
    private void Sum(in int firstRandom, in int secondRandom, out int sum)
    {
        checked { sum = firstRandom + secondRandom; }
    }
    private void Sum<T>(in T firstRandom, in T secondRandom, out T sum) where T : struct
    {
        double doubleSum = Convert.ToDouble(firstRandom) + Convert.ToDouble(secondRandom);
        sum = (T)Convert.ChangeType(doubleSum, typeof(T));
    }
    
    // Swap method overloading
    private void Swap<T>(T firstRandom, T secondRandom)
    {
        T temp = firstRandom;
        firstRandom = secondRandom;
        secondRandom = temp;
    }
    private void Swap<T>(ref T firstRandom, ref T secondRandom)
    {
        T temp = firstRandom;
        firstRandom = secondRandom;
        secondRandom = temp;
    }
    private (T,T) SwapImmutable<T>(in T firstRandom, in T secondRandom) where T : struct => (secondRandom, firstRandom);
    private (T, T) SwapImmutable<T>(T firstRandom, T secondRandom) where T : struct => (secondRandom, firstRandom);
    
    public void BoxingUnboxingTest()
    {
        object obj = 1; // Создали объект ссылочного типа, где значение 1 будет упаковано и выделено на куче
        ref object unused = ref obj; // Присвоили ссылку объекта ссылочному типу
        int unused1 = (int)obj; // Значение было извлечено из упакованного объекта и приведено к типу int
        
        Console.WriteLine($"Object value: {obj}, type: {obj.GetType()}");
        Console.WriteLine($"Ref object value: {unused}, type: {unused.GetType()}");
        Console.WriteLine($"Int value: {unused1}, type: {unused1.GetType()}");
    }
}