namespace Csharp_Lessons.OOP.Interfaces;

public interface IBook
{
    void ReadABook(int id);
    void TakeABook(int id);
    void WriteABook(string bookText);
}