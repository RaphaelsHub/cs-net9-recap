namespace Csharp_Lessons.File.Exceptions;

public class FileOpenException(FileStream? file)
{
    public FileOpenException() : this(null)
    {
    }

    public void OpenFile()
    {
        try
        {
            file = File.Open("Alex", FileMode.Open, FileAccess.Read);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e + "Argument Exception");
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e + "Directory Not Found Exception");
        }
        catch (Exception e)
        {
            throw new MyExceptionDraw(e.Message + "File opening error! Couldn't Find!");
        }
        finally
        {
            file?.Dispose();
        }
    }
}