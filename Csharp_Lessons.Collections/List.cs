using System.Collections;

namespace Csharp_Lessons.Collections;

/// <summary>
/// Represents a simple generic list implementation with dynamic resizing.
/// </summary>
public class List<T> : IEnumerable<T>
{
    /// <summary>
    /// Default capacity of the list.
    /// </summary>
    private const int DefaultCapacity = 4;

    /// <summary>
    /// Gets the number of elements currently in the list.
    /// </summary>
    public int Count { get; private set; } = 0;

    /// <summary>
    /// Gets the number of elements that can be stored in the current list.
    /// </summary>
    public int Capacity { get; private set; } = DefaultCapacity;

    /// <summary>
    /// Internal array used to store list elements.
    /// </summary>
    private T[] _array;

    /// <summary>
    /// Initializes a new instance of the List class with the default capacity.
    /// </summary>
    public List() => _array = new T[DefaultCapacity];

    /// <summary>
    /// Gets the number of elements in the list.
    /// </summary>
    public int GetCount() => Count;

    /// <summary>
    /// Gets the capacity of the list.
    /// </summary>
    public int GetCapacity() => Capacity;

    /// <summary>
    /// Adds an item to the end of the list. If full, it resizes the array.
    /// </summary>
    /// <param name="item">Item to add.</param>
    public void Add(T item)
    {
        if (Count == Capacity)
        {
            T[] newArray = new T[Capacity * 2];
            Array.Copy(_array, newArray, Capacity);
            _array = newArray;
            Capacity *= 2;
        }

        _array[Count++] = item;
    }

    /// <summary>
    /// Adds a range of items to the list.
    /// </summary>
    /// <param name="items">Items to add.</param>
    public void AddRange(IEnumerable<T> items)
    {
        foreach (var item in items)
            Add(item);
    }

    /// <summary>
    /// Removes an item at a specific index.
    /// </summary>
    /// <param name="index">Index of item to remove.</param>
    public void RemoveAt(int index)
    {
        if (index < 0 || index >= Count)
            throw new ArgumentOutOfRangeException(nameof(index));

        for (int i = index; i < Count - 1; i++)
            _array[i] = _array[i + 1];

        _array[--Count] = default!;
    }

    /// <summary>
    /// Removes the last item from the list.
    /// </summary>
    public void RemoveLast()
    {
        if (Count == 0)
            Console.WriteLine("List is empty!");
        else
            _array[--Count] = default!;
    }

    /// <summary>
    /// Displays the last element without removing it.
    /// </summary>
    public void PeekLast()
    {
        if (Count == 0)
            Console.WriteLine("List is empty!");
        else
            Console.WriteLine(_array[Count - 1]);
    }

    /// <summary>
    /// Clears all elements in the list.
    /// </summary>
    public void Clear()
    {
        for (int i = 0; i < Count; i++)
            _array[i] = default!;

        Count = 0;
    }

    /// <summary>
    /// Returns an enumerator for iterating over the list.
    /// </summary>
    public IEnumerator<T> GetEnumerator() => new Iterator<T>(this);

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <summary>
    /// Exposes internal array for iterator access.
    /// </summary>
    internal T[] InternalArray => _array;
    
    // Если мы используем IEnumerable, то нам не нужно реализовывать интерфейс IEnumerator
    // public IEnumerator<T> GetEnumerator()
    // {
    //     for (int i = 0; i < GetCount(); i++)
    //         yield return _array[i];
    // }
}