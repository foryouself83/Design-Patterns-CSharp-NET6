using System.Collections.ObjectModel;
using Dcorator.Model.Node;

class Program
{
    static void Main(string[] args)
    {
        ObservableCollection<string> menus = new();

        Console.WriteLine($"Menu type : Entity Menu");
        var entityMenu = new CreateEntityNodeContextMenu(menus);
        entityMenu.CreateMenuItem();

        foreach (var menu in menus)
            Console.WriteLine($"Sub Menu : {menu}");

        menus.Clear();

        Console.WriteLine($"\r\nMenu type : Action Menu");
        var actionMenu = new CreateActionNodeContextMenu(menus);
        actionMenu.CreateMenuItem();

        foreach (var menu in menus)
            Console.WriteLine($"Sub Menu : {menu}");

        menus.Clear();

        Console.WriteLine($"\r\nMenu type : Algorithm Menu");
        var algorithmMenu = new CreateAlgorithmNodeContextMenu(menus);
        algorithmMenu.CreateMenuItem();

        foreach (var menu in menus)
            Console.WriteLine($"Sub Menu : {menu}");

    }
}