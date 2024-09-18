using Csharp_Lessons.LINQ.Classes;

namespace Csharp_Lessons.LINQ;

class Program
{
    static void Main(string[] args)
    {
        string path = @"D:\Csharp_Lessons\Csharp_Lessons.LINQ\Text.txt";
        LINQ_Practice.DeleteEvenNums();
        LINQ_Practice.GetLargestName1(path);
        LINQ_Practice.GetLargestName2(path);
        LINQ_Practice.GetLargestName3(path);
        LINQ_Practice.GetLargestName4(path);
        LINQ_Practice.GetLargestName5(path);
        LINQ_Practice.MinMaxName(path);
    }
}