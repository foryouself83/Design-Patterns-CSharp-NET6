using System.Collections.ObjectModel;

namespace Decorator.Model.Decorator
{
    class DiagramPasteContextMenu : DiagramContextMenuDecorator
    {
        private ObservableCollection<string> menu;

        public DiagramPasteContextMenu(ObservableCollection<string> contextMenu)
        {
            this.menu = contextMenu;
        }
        public override void CreateMenuItem()
        {
            base.CreateMenuItem();
            CreateCopyMenu();
        }
        private void CreateCopyMenu()
        {
            menu.Add("Paste Menu");
        }
    }
}
