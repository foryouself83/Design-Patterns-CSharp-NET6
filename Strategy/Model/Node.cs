using Strategy.Interface;

namespace Strategy.Model
{
    internal class Node
    {
        private IAlgorithmStrategy _algorithm;
        private double _value;

        public Node(AlgorithmStrategy algorithm, double value)
        {
            _algorithm = algorithm;
            _value = value;
        }

        public double Calculate(double left)
        {
            return _algorithm.Calculate(left, _value);
        }
    }
}
