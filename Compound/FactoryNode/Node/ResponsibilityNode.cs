using Compound.FactoryNode.Detail;

namespace Compound.FactoryNode.Node
{
    public class ResponsibilityNode : AbstractNode
    {
        private string _uid = string.Empty;
        private List<SubDetail> _subDetails = new();

        public string UId => _uid;
        public List<SubDetail> SubDetails => _subDetails;

        public ResponsibilityNode(string uid)
        {
            _uid = uid;
        }
        public override void SetDetailList(string subDetail)
        {
            if (!_subDetails.Any(x => x.Detail.Equals(subDetail)))
                _subDetails.Add(new SubDetail(subDetail));
        }
        public override bool SetValidation()
        {
            throw new NotImplementedException();
        }
    }
}
