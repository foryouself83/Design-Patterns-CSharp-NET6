using Interpreter.Model;
using Interpreter.Model.Interface;

namespace Interpreter.Business
{
    internal class LeftParenthesisExpression : IExpression
    {
        public void Interpret(Context context)
        {
            context.Expression = context.Expression.Replace("LEFT", "(");
        }
    }
}
