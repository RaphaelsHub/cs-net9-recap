using System.Collections;

namespace Csharp_Lessons.Collections;

public class Iterator<T> : IEnumerator<T>
{
    private int _index = -1;
    private readonly List<T> _list;
    
    public Iterator(List<T> list) => _list = list;
    
    // Nothing to dispose, because we are not using unmanaged resources
    public void Dispose() { }
    
    // Reset the enumerator to its initial position (-1)
    public void Reset() => _index = -1;

    // Return the current element
    public T Current => _list.InternalArray[_index];

    // Explicit interface implementation to return the current element as an object
    object? IEnumerator.Current => Current!;

    // Move to the next element in the list
    public bool MoveNext()
    {
        _index++;
        return _index < _list.Count;
    }
}