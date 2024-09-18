using System.Collections;

namespace Csharp_Lessons.Collections.Classes;

public class Stack<T> : IEnumerable<T>
{
    private T[] _stack;
    public uint Count { get; set; }
    public uint Capacity { get; set; }

    public Stack()
    {
        Capacity = 2;
        _stack = new T[Capacity];
    }

    public Stack(T[] stack)
    {
        _stack = stack;
    }

    // public IEnumerator<T> GetEnumerator() крутая версия даже итератор не надо реализовывать
    // {
    //     for (int i = 0; i < _stack.Length; i++)
    //     {
    //         yield return _stack[i];
    //     }
    // }

    public void Push(T a)
    {
        if (_stack.Length == Capacity)
        {
            T[] newArray = new T[_stack.Length * 2];
            Array.Copy(_stack, newArray, Capacity * 2);
            _stack = newArray;
        }

        _stack[Count++] = a;
    }

    public void Pop()
    {
        if (Count == 0)
        {
            Console.WriteLine("Stack already is empty!");
        }
        else
        {
            _stack[--Count] = default!;
        }
    }

    public object Peek()
    {
        if (Count == 0)
        {
            Console.WriteLine("Stack is empty!");
        }

        return _stack[Count - 1] ?? default!;
    }


    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}