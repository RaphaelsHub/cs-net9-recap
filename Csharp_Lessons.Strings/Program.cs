using System.Text;

namespace Csharp_Lessons.Strings;

class Program
{
    static void Main()
    {
        ConsoleSettings();
        Concatenation();
        StringStaticMethods();
        StringBuilderExample();
    }

    private static void ConsoleSettings()
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("What is your name? ");
        Console.ResetColor();
        string? name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}");
    }
    private static void Concatenation()
    {
        var surname = "Machine";
        var name = "Vlad";
        
        Console.WriteLine($"Hello, {surname} {name}");
        Console.WriteLine("Hello, " + surname + " " + name);
        Console.WriteLine(string.Concat("Hello, ", surname, " ", name));
        Console.WriteLine(string.Format("Hello, {0} {1}", surname, name));
    }
    private static void StringStaticMethods()
    {
        var str = "Hello, World";
        str = str.Insert(str.Length, " !!!"); //Вставит в конец
        str = str.Remove(str.Length - 2, 1);
        str = str.Remove(str.Length-1);
        str = str.Replace("o", "O");
        str = str.ToLower();
        string []arr = str.Split(' ');
        
        foreach (var word in arr) 
            Console.WriteLine(word);
    }
    private static void StringBuilderExample()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Insert(0, "Hello world!");
        stringBuilder.Append(" This is a test.");
        stringBuilder.Replace("world", "every one");
        stringBuilder.Remove(stringBuilder.Length-1, 1);
        stringBuilder.AppendFormat(" - {0} {1}", "Welcome", "User!");
        var arr = stringBuilder.GetChunks();
        Console.WriteLine(stringBuilder.ToString());
        
        foreach (var chunk in arr)
        {
            Console.Write(chunk);
        }
    }
}