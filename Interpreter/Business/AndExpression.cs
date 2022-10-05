using Interpreter.Model;
using Interpreter.Model.Interface;

namespace Interpreter.Business
{
    internal class AndExpression : IExpression
    {
        public void Interpret(Context context)
        {
            context.Expression = context.Expression.Replace("AND", "+");
        }
    }
}
