
using TemplateMethod.Business;
using TemplateMethod.Model;

public class Program
{
    public static void Main(string[] args)
    {
        string filePath = @$"{Environment.CurrentDirectory}\TemplateMethodXml.xml";

        // Abstract Model in FTA Model
        ModelAccessor accessor = new FtaModel();
        // Serialize Model 
        var document = accessor.Serialize(accessor);
        document?.Save(filePath);
        // Deserialize Model 
        if (accessor.Load(filePath) is not FtaModel) return;

        Console.WriteLine($"{filePath} is FTA Model");

        // Abstract Model in STPA Model
        accessor = new StpaModel();
        // Serialize Model 
        document = accessor.Serialize(accessor);
        document?.Save(filePath);
        // Deserialize Model 
        if (accessor.Load(filePath) is not StpaModel) return;

        Console.WriteLine($"{filePath} is STPA Model");


    }
}