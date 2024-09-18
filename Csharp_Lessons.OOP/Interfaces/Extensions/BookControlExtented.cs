namespace Csharp_Lessons.OOP.Interfaces.Extensions;

public static class BookControlExtented
{
    public static void AddRangeOfBooks(this IBookControl exempl, params int[] numbers)
    {
        foreach (var vas in numbers)
            exempl.AddABookToLibrary(vas);
    }
}