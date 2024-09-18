namespace Csharp_Lessons.Collections.Classes;

public class TestCollections
{
    public void CustomStackTest()
    {
        // CustomStack<int> a = new CustomStack<int>();

        // for (int i = 0; i < 4; i++)
        //     a.Push(1);
        //
        // for (int i = 0; i < 4; i++)
        // {
        //     Console.WriteLine(a.Peek());
        //     a.Pop();
        // }
    }

    public void HashSetTest()
    {
        var set = new HashSet<int>(new[] { 1, 2, 2, 3, 4, 5 });

        foreach (var variable in set)
            Console.WriteLine($"{variable} ");
    }

    public void DictionaryTest()
    {
        var dictionary = new Dictionary<string, double>();
        if (dictionary == null) throw new ArgumentNullException(nameof(dictionary));

        dictionary.Add("First", 1.0);
        dictionary.Add("PI", 3.15);
        dictionary.Add("E", 2.71);

        dictionary["PI"] = 3.14;

        foreach (var it in dictionary)
            Console.WriteLine(it.Key + " " + it.Value);
    }

    public void LinkedListTest()
    {
        var linkedList = new LinkedList<int>(new[] { 1, 2, 3, 4, 5 });


        if (linkedList.First != null)
        {
            linkedList.First.Value = 0;
            linkedList.AddLast(16);
        }

        var currNode = linkedList.First;

        while (currNode != null && currNode.Next != null)
        {
            if (currNode.Next.Value == 1)
            {
                var newNode = new LinkedListNode<int>(3);
                linkedList.AddAfter(currNode, newNode);
            }

            currNode = currNode.Next;
        }
    }

    public void StackQueueTest()
    {
        System.Collections.Generic.Stack<int> orders = new System.Collections.Generic.Stack<int>(10);
        if (orders == null) throw new ArgumentNullException(nameof(orders));

        Queue<int> queue = new Queue<int>(10);
        if (queue == null) throw new ArgumentNullException(nameof(queue));

        orders.Push(1);
        orders.Pop();

        queue.Enqueue(1);
        queue.Dequeue();
    }

    public void ListTest()
    {
        var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        if (list == null) throw new ArgumentNullException(nameof(list));

        list.Add(1);
        list.Sort();
        list.Reverse();
        list.RemoveAt(0);
        list.Insert(0, 1);

        foreach (var it in list)
            Console.WriteLine(it + " ");
    }

    public void DoubleArrayTest()
    {
        int[,] doubleArray = new int[,] { { 1, 3, 5 }, { 4, 6, 8 }, { 2, 1, 0 } };

        for (int i = 0; i < doubleArray.GetLength(0); i++)
        {
            for (int y = 0; y < doubleArray.GetLength(1); y++)
            {
                Console.WriteLine(doubleArray[i, y] + " ");
            }
        }
    }

    private void CreatingArray(params int[] array)
    {
        foreach (var it in array)
            Console.Write(it + " ");
    }

    public void ArrayTest()
    {
        var array = new[] { 2, 4, 6, 8, 10 };
        var array1 = new int[5];

        Array.Copy(array, array1, array1.Length);
        var unused = array[(Array.BinarySearch(array, 2))];

        CreatingArray(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
    }
}