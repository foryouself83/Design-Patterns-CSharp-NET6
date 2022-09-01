using System.Collections.ObjectModel;

namespace Dcorator.Model.Decorator
{
    class DiagramCutContextMenu : DiagramContextMenuDecorator
    {
        private ObservableCollection<string> menu;

        public DiagramCutContextMenu(ObservableCollection<string> contextMenu)
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
            menu.Add("Cut Menu");
        }
    }
}
