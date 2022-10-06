using Iterator.Business;
using Iterator.Model;

public class Program
{
    static void Main(string[] args)
    {
        Collection collection = new Collection();
        collection.Add(new Item("Kim"));
        collection.Add(new Item("Lee"));
        collection.Add(new Item("Park"));
        collection.Add(new Item("Won"));
        collection.Add(new Item("Dong"));
        collection.Add(new Item("Git"));
        collection.Add(new Item("View"));
        collection.Add(new Item("File"));
        collection.Add(new Item("Show"));
     
        var iterator = collection.CreateIterator();

        var item = iterator.First();
        Console.WriteLine(item?.Name);
        while (!iterator.IsDone)
        {
            item = iterator.Next();
            Console.WriteLine(item?.Name);
        }                
    }
}
