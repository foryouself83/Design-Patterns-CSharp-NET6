using System.Collections.ObjectModel;

namespace Decorator.Model.Decorator
{
    class DiagramCopyContextMenu : DiagramContextMenuDecorator
    {
        private ObservableCollection<string> menu;

        public DiagramCopyContextMenu(ObservableCollection<string> contextMenu)
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
            menu.Add("Copy Menu");
        }
    }
}
