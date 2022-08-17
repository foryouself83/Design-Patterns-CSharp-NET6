using Compound.FactoryNode.Detail;

namespace Compound.FactoryNode.Node
{
    public class ResponsibilityNode : AbstractNode<SubDetail>
    {
        private readonly string _preset = "LS-";
        private string _uid = string.Empty;
        private int _count = 0;
        private List<SubDetail> _subDetails = new();

        public string UId => _uid;

        public ResponsibilityNode(string uid)
        {
            _uid = uid;
        }
        public override void SetDetailList(string subDetail)
        {
            if (!_subDetails.Any(x => x.Detail.Equals(subDetail)))
                _subDetails.Add(new SubDetail($"{_preset}{++_count}", subDetail));
        }
        public override bool GetValidation()
        {
            return _subDetails.Any(x => !x.Id.Equals(_preset));
        }
        public override IEnumerable<SubDetail> GetEnumerator()
        {
            return _subDetails;
        }
    }
}
