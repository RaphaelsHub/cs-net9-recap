namespace Csharp_Lessons.Collections;

class Program
{
    static void Main()
    {
        // var collectionDemos = new CollectionDemos();
        // collectionDemos.RunAllDemos();
        Run();
    }

        public static void Run()
    {
        var list = new List<int>();

        PrintHeader("Test: Add single elements");
        Console.WriteLine("-> Add(10), Add(20), Add(30)");
        list.Add(10);
        list.Add(20);
        list.Add(30);
        PrintList(list);

        PrintHeader("Test: AddRange");
        Console.WriteLine("-> AddRange({40, 50, 60})");
        list.AddRange(new[] { 40, 50, 60 });
        PrintList(list);

        Console.WriteLine($"-> Count     : {list.GetCount()}");
        Console.WriteLine($"-> Capacity  : {list.GetCapacity()}");
        Console.WriteLine();

        PrintHeader("Test: RemoveAt(2)");
        Console.WriteLine("-> RemoveAt(2)");
        list.RemoveAt(2);
        PrintList(list);

        PrintHeader("Test: PeekLast");
        Console.WriteLine("-> PeekLast()");
        list.PeekLast();
        Console.WriteLine();

        PrintHeader("Test: RemoveLast");
        Console.WriteLine("-> RemoveLast()");
        list.RemoveLast();
        PrintList(list);

        PrintHeader("Test: Clear");
        Console.WriteLine("-> Clear()");
        list.Clear();
        PrintList(list);

        PrintHeader("Test: AddRange after Clear");
        Console.WriteLine("-> AddRange({100, 200, 300})");
        list.AddRange(new[] { 100, 200, 300 });
        PrintList(list);

        PrintHeader("Test: Foreach iteration");
        Console.WriteLine("-> Iterating:");
        foreach (var item in list)
            Console.Write($"[{item}] ");
        
        Console.WriteLine();
        PrintFooter();
    }

    private static void PrintList(List<int> list)
    {
        Console.Write("-> Current list: ");
        if (list.GetCount() == 0)
        {
            Console.WriteLine("[empty]");
        }
        else
        {
            foreach (var item in list)
                Console.Write($"[{item}] ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    private static void PrintHeader(string title)
    {
        Console.WriteLine(new string('-', 40));
        Console.WriteLine($"  {title}");
        Console.WriteLine(new string('-', 40));
    }

    private static void PrintFooter()
    {
        Console.WriteLine(new string('=', 40));
        Console.WriteLine("  End of List<T> functionality demo");
        Console.WriteLine(new string('=', 40));
    }
}