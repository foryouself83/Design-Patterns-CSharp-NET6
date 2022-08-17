namespace Compound.FactoryNode.Detail
{
    public class SubDetail
    {
        public string Id { get; set; } = string.Empty;
        public string Detail { get; set; } = string.Empty;
        public SubDetail(string id, string detail)
        {
            Id = id;
            Detail = detail;
        }
    }
}
