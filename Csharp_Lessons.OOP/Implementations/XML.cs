using System.Xml.Linq;
using System.Xml.Serialization;

namespace Csharp_Lessons.OOP.Implementations;

public class XML<T>(string? path)
{
    private readonly string? _path = path;

    private bool IsValidPath => !string.IsNullOrEmpty(_path) && Directory.Exists(path);

    public bool SaveModel(T model)
    {
        if (!IsValidPath)
            return false;

        using (FileStream fs = new FileStream(_path!, FileMode.Create, FileAccess.Write))
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            xmlSerializer.Serialize(fs, model);
        }

        return File.Exists(_path);
    }

    public T? LoadModel()
    {
        if (!IsValidPath)
            return default;

        using FileStream fs = new FileStream(_path!, FileMode.Open, FileAccess.Read);
        return (T?)new XmlSerializer(typeof(T)).Deserialize(fs);
    }

    public bool SaveModels(IEnumerable<T> models)
    {
        if (!IsValidPath)
            return false;

        using FileStream fs = new FileStream(_path!, FileMode.Create, FileAccess.Write);
        new XmlSerializer(typeof(List<T>)).Serialize(fs, models.ToList());

        return File.Exists(_path);
    }

    public IEnumerable<T>? LoadModels()
    {
        if (!IsValidPath)
            return default;

        using FileStream fs = new FileStream(_path!, FileMode.Open, FileAccess.Read);
        return (IEnumerable<T>?)new XmlSerializer(typeof(List<T>)).Deserialize(fs);
    }

    private static void CreatCustom()
    {
        string path = @"D:\Repositories\C_Sharp_Reminder\Serialization_DeserializationXML\Custom.xml";

        XElement a = new XElement("Country");
        XElement b = new XElement("City");

        XElement address = new XElement("Address", "Pushkin");
        var c = address;

        XAttribute city = new XAttribute("City", "Chisinau");
        b.Add(city);

        b.Add(c);

        XAttribute country = new XAttribute("Country", "Moldova");
        a.Add(country);

        a.Add(b);
        a.Add(b);
        a.Add(b);

        a.Save(path);
    }


    private static void AddAttributes(string pathForListOfWorkers)
    {
        XDocument doc = XDocument.Load(pathForListOfWorkers);

        List<XElement> list = doc
            .Descendants("ArrayOfWorker")
            .Descendants("Worker")
            .ToList();

        XAttribute min = new XAttribute("Min", 10000);
        XAttribute max = new XAttribute("Max", 30000);

        foreach (var obj in list)
            obj.Element("Salary")?.Add(min, max);

        doc.Save(pathForListOfWorkers);
    }
}