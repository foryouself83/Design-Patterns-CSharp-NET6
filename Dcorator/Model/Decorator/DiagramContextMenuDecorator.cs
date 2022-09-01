namespace Dcorator.Model.Decorator
{
    public abstract class DiagramContextMenuDecorator : DiagramMenuItem
    {
        protected DiagramMenuItem? context;
        public DiagramContextMenuDecorator AddDecorator(DiagramMenuItem context)
        {
            this.context = context;

            return this;
        }
        public override void CreateMenuItem()
        {
            if (context != null)
            {
                context.CreateMenuItem();
            }
        }
    }
}
