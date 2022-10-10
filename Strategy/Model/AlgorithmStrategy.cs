using Strategy.Model.Interface;

namespace Strategy.Model
{
    internal abstract class AlgorithmStrategy : IAlgorithmStrategy
    {
        public abstract double Calculate(double left, double right);
    }
}
