using System.Collections.ObjectModel;
using Dcorator.Model.Decorator;

namespace Dcorator.Model.Node
{
    class CreateAlgorithmNodeContextMenu : DiagramMenuItem
    {
        private ObservableCollection<string> menu;

        public CreateAlgorithmNodeContextMenu(ObservableCollection<string> contextMenu)
        {
            this.menu = contextMenu;
        }

        public override void CreateMenuItem()
        {
            var contextmenu = new DiagramPasteContextMenu(menu).AddDecorator(
                                        new CreateDiagramContextMenu());

            contextmenu.CreateMenuItem();
        }
    }
}
