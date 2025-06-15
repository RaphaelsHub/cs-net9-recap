namespace Csharp_Lessons.Services;

public class DataTypeService
{
    public void PrintPrimitiveTypes()
    {
        Console.WriteLine($"sbyte: {sbyte.MinValue} to {sbyte.MaxValue}");
        Console.WriteLine($"byte: {byte.MinValue} to {byte.MaxValue}");
        Console.WriteLine($"short: {short.MinValue} to {short.MaxValue}");
        Console.WriteLine($"ushort: {ushort.MinValue} to {ushort.MaxValue};");
        Console.WriteLine($"int: {int.MinValue} to {int.MaxValue}");
        Console.WriteLine($"uint: {uint.MinValue} to {uint.MaxValue};");
        Console.WriteLine($"long: {long.MinValue} to {long.MaxValue}");
        Console.WriteLine($"ulong: {ulong.MinValue} to {ulong.MaxValue};");
        Console.WriteLine($"float: {float.MinValue} to {float.MaxValue}");
        Console.WriteLine($"double: {double.MinValue} to {double.MaxValue}");
        Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue}");
        Console.WriteLine($"char: {char.MinValue} to {char.MaxValue}");
        Console.WriteLine($"bool: {true} or {false}");
    }

    public void PrintComplexTypes()
    {
        string stringVariable = "This is a string type";
        object objectVariable = "This is an object type";
        dynamic dynamicVariable = "This is a dynamic type";

        Console.WriteLine($"string: {stringVariable}");
        Console.WriteLine($"object: {objectVariable}");
        Console.WriteLine($"dynamic: {dynamicVariable}");
        Console.WriteLine($"DateTime: {DateTime.Now}");
        Console.WriteLine($"TimeSpan: {TimeSpan.FromHours(1)}");
    }
}