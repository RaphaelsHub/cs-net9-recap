namespace Csharp_Lessons.Collections;

public class CollectionDemos
{
    public void DemonstrateHashSetUsage()
    {
        Console.WriteLine("HashSet Example:");
        var uniqueEmails = new HashSet<string>
        {
            "user1@example.com",
            "user2@example.com",
            "user1@example.com", // Duplicate will be ignored
            "user3@example.com"
        };

        foreach (var email in uniqueEmails)
            Console.WriteLine(email);

        Console.WriteLine();
    }

    public void DemonstrateDictionaryUsage()
    {
        Console.WriteLine("Dictionary Example:");
        var contacts = new Dictionary<string, string>
        {
            { "Alice", "+123456789" },
            { "Bob", "+987654321" }
        };

        contacts["Bob"] = "+111111111"; // Updating Bob's number

        if (contacts.TryGetValue("Alice", out var number))
            Console.WriteLine($"Alice's number: {number}");

        foreach (var contact in contacts)
            Console.WriteLine($"{contact.Key}: {contact.Value}");

        Console.WriteLine();
    }

    public void DemonstrateLinkedListUsage()
    {
        Console.WriteLine("LinkedList Example:");
        var numbers = new LinkedList<int>(new[] { 1, 2, 3, 4, 5 });

        if (numbers.First != null)
        {
            numbers.First.Value = 0;               // Replace first element
            numbers.AddLast(16);                   // Add new element at the end
        }

        var current = numbers.First;

        while (current != null && current.Next != null)
        {
            if (current.Next.Value == 1)
            {
                var newNode = new LinkedListNode<int>(3);
                numbers.AddAfter(current, newNode);
            }

            current = current.Next;
        }

        foreach (var number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();
    }

    public void DemonstrateStackUsage()
    {
        Console.WriteLine("Stack Example:");
        var backHistory = new Stack<string>();
        backHistory.Push("Page 1");
        backHistory.Push("Page 2");
        backHistory.Push("Page 3");

        while (backHistory.Count > 0)
            Console.WriteLine("Back: " + backHistory.Pop());

        Console.WriteLine();
    }

    public void DemonstrateQueueUsage()
    {
        Console.WriteLine("Queue Example:");
        var supportQueue = new Queue<string>();
        supportQueue.Enqueue("Client A");
        supportQueue.Enqueue("Client B");
        supportQueue.Enqueue("Client C");

        while (supportQueue.Count > 0)
            Console.WriteLine("Serving: " + supportQueue.Dequeue());

        Console.WriteLine();
    }

    public void DemonstrateListUsage()
    {
        Console.WriteLine("List Example:");
        var scores = new System.Collections.Generic.List<int> { 10, 20, 30, 15, 5 };
        scores.Add(25);

        scores.Sort();    // Ascending
        scores.Reverse(); // Descending

        Console.WriteLine("Top 3 scores:");
        for (int i = 0; i < Math.Min(3, scores.Count); i++)
            Console.WriteLine(scores[i]);

        Console.WriteLine();
    }

    public void DemonstrateMultidimensionalArrayUsage()
    {
        Console.WriteLine("Multidimensional Array Example:");
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Main diagonal:");
        for (int i = 0; i < matrix.GetLength(0); i++)
            Console.WriteLine(matrix[i, i]);

        Console.WriteLine();
    }

    private int[] CreateArrayFromParams(params int[] array) => array;

    public void DemonstrateArrayUsage()
    {
        Console.WriteLine("Array Example:");
        var prices = new[] { 100, 300, 200, 400, 150 };

        Array.Sort(prices);
        Array.Reverse(prices);

        Console.WriteLine("Prices (high to low):");
        foreach (var price in prices)
            Console.Write(price + " ");
        
        Console.WriteLine();

        var copiedPrices = new int[prices.Length];
        Array.Copy(prices, copiedPrices, prices.Length);

        Console.WriteLine("\nCopied array:");
        foreach (var price in copiedPrices)
            Console.Write(price + " ");
        
        Console.WriteLine();

        var dynamicArray = CreateArrayFromParams(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        Console.WriteLine("\nCreated from params:");
        foreach (var value in dynamicArray)
            Console.Write(value + " ");

        Console.WriteLine();
    }

    public void RunAllDemos()
    {
        DemonstrateHashSetUsage();
        DemonstrateDictionaryUsage();
        DemonstrateLinkedListUsage();
        DemonstrateStackUsage();
        DemonstrateQueueUsage();
        DemonstrateListUsage();
        DemonstrateMultidimensionalArrayUsage();
        DemonstrateArrayUsage();
    }
}
