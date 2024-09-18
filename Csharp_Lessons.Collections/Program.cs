using Csharp_Lessons.Collections.Classes;

namespace Csharp_Lessons.Collections;

class Program
{
    static void Main(string[] args)
    {
        var testCollections = new TestCollections();
        testCollections.HashSetTest();
        testCollections.DictionaryTest();
        testCollections.LinkedListTest();
        testCollections.LinkedListTest();
        testCollections.ArrayTest();
        testCollections.DoubleArrayTest();
        testCollections.ListTest();
        testCollections.StackQueueTest();
        testCollections.CustomStackTest();
    }
}