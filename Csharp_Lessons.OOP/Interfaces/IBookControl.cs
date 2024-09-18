namespace Csharp_Lessons.OOP.Interfaces;

public interface IBookControl: IBook
{
    void AddABookToLibrary(int id);
    new void ReadABook(int id);
}