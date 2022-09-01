using System.Collections.ObjectModel;
using Dcorator.Model.Decorator;

namespace Dcorator.Model.Node
{
    class CreateEntityNodeContextMenu : DiagramMenuItem
    {
        private ObservableCollection<string> menu;

        public CreateEntityNodeContextMenu(ObservableCollection<string> contextMenu)
        {
            this.menu = contextMenu;
        }

        public override void CreateMenuItem()
        {
            var contextmenu = new DiagramPasteContextMenu(menu).AddDecorator(
                                new DiagramCutContextMenu(menu).AddDecorator(
                                    new DiagramCopyContextMenu(menu).AddDecorator(
                                        new CreateDiagramContextMenu())));

            contextmenu.CreateMenuItem();
        }
    }
}
