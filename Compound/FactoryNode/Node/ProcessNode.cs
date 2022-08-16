using Compound.FactoryNode.Detail;

namespace Compound.FactoryNode.Node
{
    public class ProcessNode : AbstractNode
    {
        private string _uid = string.Empty;
        private List<SubDetail> _details = new();

        public string UId => _uid;
        public List<SubDetail> Details => _details;

        public ProcessNode(string uid)
        {
            _uid = uid;
        }
        public override void SetDetailList(string subDetail)
        {
            if (!_details.Any(x => x.Detail.Equals(subDetail)))
                _details.Add(new SubDetail(subDetail));
        }
        public override bool SetValidation()
        {
            throw new NotImplementedException();
        }
    }
}
