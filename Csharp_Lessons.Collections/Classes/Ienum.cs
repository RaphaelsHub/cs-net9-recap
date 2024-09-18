namespace Csharp_Lessons.Collections.Classes;

using System.Collections;


public class Ienum<T> : IEnumerator<T>
{
    private int index = -1;
    private readonly T[] _array;

    public Ienum(T[] array)
    {
        _array = array;
    }
    
    public bool MoveNext()
    {
        index++;
        return index < _array.Length;
    }

    public void Reset()
    {
        index = -1;
    }

    public T Current { get => _array[index]; }

    object IEnumerator.Current => Current;

    public void Dispose() { }
}