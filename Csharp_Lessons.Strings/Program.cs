using System.Text;

namespace Csharp_Lessons.Strings;

class Program
{
    static void Main()
    {
        ConsoleTest();
        Concatenation();
        StringStaticMethods();
        StringBuilderExample();
    }
    
    private static void ConsoleTest()
    {
        Console.WriteLine("Hello, World!"); 
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Hello, World!");
        Console.ResetColor();
        Console.Write("What is your name? ");
        string? name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}");
    }
    
    private static void Concatenation()
    {
        var surname = "Pekel";
        var name = "Vlad";

        var unused = name + " " + surname;
        var unused1 = string.Concat(name, " ", surname);
        var unused2 = string.Format("{0} {1}", name, surname);
        var unused3 = $"{name} {surname}";
    }
    
    private static void StringStaticMethods()
    {
        var str = //Сделает конкатенацию
            string.Join(" ", "Alex", "Pekel", "Is A King"); //Добавит в конец
        str = str.Insert(0, "By the way, "); //Вставит текст вначале указателя
        str = str.Remove(10); //Удалит начиная с 10 символа
        str = str.Replace('a', 'E'); //Заменит
        str = str.ToLower(); //Привидет к маленьким
        string[] unused = str.Split(';'); //Разделит на под массивы и вернет массивы
    }
    
    private static void StringBuilderExample()
    {
        var sb = new StringBuilder();

        // Append some strings
        sb.Append("Hello");
        sb.Append(" ");
        sb.Append("World");
        
        sb.AppendFormat(" - {0} {1}", "Welcome", "User"); // Append formatted strings
        sb.Insert(0, "Greetings: ");        // Insert a string
        sb.Remove(11, 7); // Remove "Welcome"
        sb.Replace("World", "Everyone");        // Replace a section of the string
        string result = sb.ToString();
        Console.WriteLine(result);
    }
}