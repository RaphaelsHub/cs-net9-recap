using Csharp_Lessons.Classes;
using ValueType = Csharp_Lessons.Classes.ValueType;

namespace Csharp_Lessons.Services;

public class MemoryManagementService
{
    public void DemonstrateValueType()
    {
        var valueObject1 = new ValueType(1, 2);
        var valueObject2 = valueObject1;
        
        valueObject1.X = 10;
        
        Console.Write("Original: ");
        valueObject1.Print();
        Console.Write("Copy: ");
        valueObject2.Print();
    }

    public void DemonstrateReferenceType()
    {
        var referenceObject1 = new ReferenceType(1, 2);
        var referenceObject2 = referenceObject1;
        
        referenceObject1.X = 10;
        
        Console.Write("Original: ");
        referenceObject1.Print();
        Console.Write("Copy: ");
        referenceObject2.Print();
    }
}