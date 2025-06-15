namespace Csharp_Lessons.Services;

public class OperatorsService
{
    public void DemonstrateAllOperators()
    {
        Console.WriteLine("=== OPERATORS DEMONSTRATION ===");
        
        DemonstrateArithmetic();
        DemonstrateComparison();
        DemonstrateLogical();
        DemonstrateUnary();
        DemonstrateTernary();
        DemonstrateNullCoalescing();
    }

    private void DemonstrateArithmetic()
    {
        Console.WriteLine("\n--- Arithmetic Operators ---");
        int a = 10, b = 3;
        
        Console.WriteLine($"{a} + {b} = {a + b}");
        Console.WriteLine($"{a} - {b} = {a - b}");
        Console.WriteLine($"{a} * {b} = {a * b}");
        Console.WriteLine($"{a} / {b} = {a / b} (integer division)");
        Console.WriteLine($"{a} / {(double)b} = {a / (double)b} (floating division)");
        Console.WriteLine($"{a} % {b} = {a % b} (modulus)");
        
        a += 5;
        Console.WriteLine($"After += 5: a = {a}");
    }

    private void DemonstrateComparison()
    {
        Console.WriteLine("\n--- Comparison Operators ---");
        int x = 5, y = 7;
        
        Console.WriteLine($"{x} == {y} ? {x == y}");
        Console.WriteLine($"{x} != {y} ? {x != y}");
        Console.WriteLine($"{x} > {y} ? {x > y}");
        Console.WriteLine($"{x} < {y} ? {x < y}");
        Console.WriteLine($"{x} >= {y} ? {x >= y}");
        Console.WriteLine($"{x} <= {y} ? {x <= y}");
    }

    private void DemonstrateLogical()
    {
        Console.WriteLine("\n--- Logical Operators ---");
        bool a = true, b = false;
        
        Console.WriteLine($"{a} && {b} = {a && b} (AND)");
        Console.WriteLine($"{a} || {b} = {a || b} (OR)");
        Console.WriteLine($"!{a} = {!a} (NOT)");
    }

    private void DemonstrateUnary()
    {
        Console.WriteLine("\n--- Unary Operators ---");
        int num = 5;
        
        Console.WriteLine($"Original: {num}");
        Console.WriteLine($"Post-increment: {num++} (now {num})");
        Console.WriteLine($"Pre-increment: {++num}");
        Console.WriteLine($"Post-decrement: {num--} (now {num})");
        Console.WriteLine($"Pre-decrement: {--num}");
        Console.WriteLine($"Unary plus: {+num}");
        Console.WriteLine($"Unary minus: {-num}");
    }

    private void DemonstrateTernary()
    {
        Console.WriteLine("\n--- Ternary Operator ---");
        int age = 20;
        
        string status = age >= 18 ? "Adult" : "Minor";
        Console.WriteLine($"Age {age}: {status}");
        
        int score = 85;
        string grade = score >= 90 ? "A" : 
                      score >= 80 ? "B" :
                      score >= 70 ? "C" : "D";
        Console.WriteLine($"Score {score}: Grade {grade}");
    }

    private void DemonstrateNullCoalescing()
    {
        Console.WriteLine("\n--- Null Coalescing Operators ---");
        string? nullableString = null;
        string fallback = "Default Value";
        
        // ?? operator
        string result1 = nullableString ?? fallback;
        Console.WriteLine($"null ?? \"{fallback}\" = \"{result1}\"");
                
        string? configValue = null;
        string actualValue = configValue ?? GetDefaultConfig();
        Console.WriteLine($"Config value: {actualValue}");
    }

    private string GetDefaultConfig() => "Default Config";
}