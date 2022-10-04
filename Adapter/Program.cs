using Adapter.Model;
using Adapter.Model.Interface;

public class Program
{
    public static void Main(string[] args)
    {
        List<ICalculate> calculates = new List<ICalculate>();

        calculates.Add(new NewNode(100.0f));
        calculates.Add(new AdapterNode(10000.0f));

        double value = 0.0f;

        foreach (var node in calculates)
        {
            value += node.Calculate();
        }
        Console.WriteLine(value);
    }
}
