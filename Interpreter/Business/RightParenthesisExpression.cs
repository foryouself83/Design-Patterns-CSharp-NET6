using Interpreter.Model;
using Interpreter.Model.Interface;

namespace Interpreter.Business
{
    internal class RightParenthesisExpression : IExpression
    {
        public void Interpret(Context context)
        {
            context.Expression = context.Expression.Replace("RIGHT", ")");
        }
    }
}
