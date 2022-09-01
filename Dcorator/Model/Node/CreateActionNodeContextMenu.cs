using System.Collections.ObjectModel;
using Dcorator.Model.Decorator;

namespace Dcorator.Model.Node
{
    class CreateActionNodeContextMenu : DiagramMenuItem
    {
        private ObservableCollection<string> menu;

        public CreateActionNodeContextMenu(ObservableCollection<string> contextMenu)
        {
            this.menu = contextMenu;
        }

        public override void CreateMenuItem()
        {
            var contextmenu = new DiagramPasteContextMenu(menu).AddDecorator(
                                new DiagramCopyContextMenu(menu).AddDecorator(
                                        new CreateDiagramContextMenu()));

            contextmenu.CreateMenuItem();
        }
    }
}
