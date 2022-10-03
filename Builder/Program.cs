

using Builder.Model;

class Program
{
    static void Main(string[] args)
    {
        var node = new Node()
            .SetId(Guid.NewGuid().ToString())
            .SetName("Builder")
            .SetDescription("DesignPattern")
            .SetType("None")
            .SetParent(null);


        Console.WriteLine($"{node.ToString()}");
    }
}