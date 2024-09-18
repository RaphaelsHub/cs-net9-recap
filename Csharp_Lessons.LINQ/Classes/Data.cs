namespace Csharp_Lessons.LINQ.Classes;

public class Data
{
    public long Id { get; init; }
    public string? Name { get; init; }
    public string? Surname { get; init; }
    public string? Country { get; init; }
    public string? Address { get; init; }

    public override string ToString()
    {
        return $"Name: {Name} Surname: {Surname} Id: {Id} Country: {Country} Address: {Address}";
    }

    public static Data GetData(string str)
    {
        string[] lines = str.Split(";");
        
        return new Data()
        {
            Name = lines[0],
            Surname = lines[1],
            Id = int.Parse(lines[2]),
            Country = lines[3],
            Address = lines[4],
        };
    }
}