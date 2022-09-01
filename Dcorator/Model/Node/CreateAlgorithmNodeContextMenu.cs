using System.Collections.ObjectModel;
using Decorator.Model.Decorator;

namespace Decorator.Model.Node
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
