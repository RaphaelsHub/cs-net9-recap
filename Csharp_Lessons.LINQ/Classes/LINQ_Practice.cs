namespace Csharp_Lessons.LINQ.Classes;

public static class LINQ_Practice
{
    //Задача отсортировать файл по длине имени

    #region firstType

    public static void GetLargestName1(string? path)
    {
        if (path == null) return;
        
        if(!File.Exists(path))
            return;
        
        var files = new DirectoryInfo(path).GetFiles();

        Array.Sort(files, CompName);

        foreach (var file in files)
        {
            Console.WriteLine($"{file.Name} {file.Length}");
        }
    }

    private static int CompName(FileInfo a, FileInfo b)
    {
        if (a.Length == b.Length) return 0;

        return a.Length > b.Length ? -1 : 1;
    }

    #endregion

    #region secondType

    public static void GetLargestName2(string? path)
    {
        if (path == null) return;
        
        if(!File.Exists(path))
            return;

        IEnumerable<FileInfo> files = new DirectoryInfo(path)
            .GetFiles()
            .OrderByDescending(file => file.Name.Length)
            .Take(10);

        foreach (var file in files)
            Console.WriteLine($"{file.Name} {file.Length}");
    }

    #endregion

    #region thirdType

    public static void GetLargestName3(string? path)
    {
        if (path == null) return;
        
        if(!File.Exists(path))
            return;
        
        new DirectoryInfo(path)
            .GetFiles()
            .OrderByDescending(file => file.Name.Length)
            .Take(10)
            .ForEach(x => Console.WriteLine($"{x.Name} {x.Length}"));
    }

    private static void ForEach<T>(this IEnumerable<T>? files, Action<T> action)
    {
        if (files == null) return;

        foreach (var file in files)
            action(file);
    }

    #endregion

    #region fourthType

    public static void GetLargestName4(string? path)
    {
        if (path == null) return;
        
        if(!File.Exists(path))
            return;

        new DirectoryInfo(path)
            .GetFiles()
            .OrderByDescending(x => x.Name.Length)
            .Take(10)
            .ForEach(x => x.Name.Length, x => x.Name);
    }

    private static void ForEach<T>(this IEnumerable<T>? source, Func<T, long> getLength, Func<T, string> getName)
    {
        if (source == null) return;

        foreach (var item in source)
        {
            long a = getLength(item);
            string b = getName(item);

            Console.WriteLine($"{b} {a}");
        }
    }

    #endregion

    #region fifthType

    public static void GetLargestName5(string? path)
    {   
        if(path == null) return;
        
        if(!File.Exists(path))
            return;
        
        new DirectoryInfo(path)
            .GetFiles()
            .OrderByDescending(file => file.Length)
            .Take(10)
            .ForEach(elem => elem);
    }

    private static void ForEach<T>(this IEnumerable<T>? files, Func<T, FileInfo> getFileInfo)
    {
        if (files == null) return;

        foreach (var file in files)
            Console.WriteLine($"{getFileInfo(file).Name} {getFileInfo(file).Length}");
    }

    #endregion

    #region deleteEvenNumsFromCollection

    public static void DeleteEvenNums(params int[] nums)
    {
        nums.ToList().RemoveAll(num => num % 2 == 0);
    }

    #endregion

    #region MinMaxNameChess

    public static void MinMaxName(string? fileName)
    {
        if (fileName == null) return;


        try
        {
            List<Data> persons = File.ReadAllLines(fileName)
                .Skip(1)
                .Select(Data.GetData)
                .Where(x => x.Name != null && x.Name.Length > 5)
                .OrderByDescending(da => da.Name)
                .ThenBy(d => d.Id)
                .Take(10)
                .ToList();

            foreach (var person in persons)
                Console.WriteLine(person);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"File not found: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }

    #endregion
}