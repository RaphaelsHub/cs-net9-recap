namespace Csharp_Lessons.File.Exceptions;

public class MyExceptionDraw : Exception
{
    public MyExceptionDraw(string error):base(error)
    {
        Console.WriteLine(error);
    }
}