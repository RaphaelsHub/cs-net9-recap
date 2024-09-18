using Csharp_Lessons.OOP.Interfaces;

namespace Csharp_Lessons.OOP.Implementations;

public class BookControl : IBookControl
{
    public void AddABookToLibrary(int id)
    {
        Console.WriteLine("You are adding a book with index {id}"); 
    }

    void IBookControl.ReadABook(int id)
    {
        Console.WriteLine("You are reading a book with index {id} and you are in a IBookControl");
    }

    void IBook.ReadABook(int id)
    {
        Console.WriteLine("You are reading a book with index {id}");
    }

    public void TakeABook(int id)
    {
        Console.WriteLine("You are taking a book with index {id}");
    }

    public void WriteABook(string bookText)
    {
        Console.WriteLine("You are writing a book with text {bookText} and you are in a IBook");
    }
}