using Csharp_Lessons.Classes;

namespace Csharp_Lessons;

class Program
{
    static void Main()
    {
        object obj = new Variables();
        
        
        var variables = obj as Variables ?? new Variables();
        
        variables.PrintAllVariables();
        variables.MathStaticFunctions();
        variables.RandomNumsTest();
        variables.BoxingUnboxingTest();
        
        Console.ReadKey();
        Console.Clear();
        
        if (obj is Variables variables1)
        {
            variables1.PrintAllVariables();
            variables1.MathStaticFunctions();
            variables1.RandomNumsTest();
            variables1.BoxingUnboxingTest();
        }
        
        
        
        TestRef a = new TestRef(1, 2);
        TestRef b = a;
        b.X = 3;
        a.Print();
        b.Print();
        
        TestValue c = new TestValue(1, 2);
        TestValue d = c;
        d.X = 3;
        c.Print();
        d.Print();
        
    }
}