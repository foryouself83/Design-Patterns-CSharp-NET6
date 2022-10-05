using Interpreter.Business;
using Interpreter.Model;
using Interpreter.Model.Interface;

class Program
{
    static void Main(string[] args)
    {
        Context context = new Context("1 And Left 2 OR 3 And 4 Right And 5");
        
        List<IExpression> list = new List<IExpression>();
        list.Add(new AndExpression());
        list.Add(new OrExpression());
        list.Add(new LeftParenthesisExpression());
        list.Add(new RightParenthesisExpression());

        foreach (IExpression exp in list)
        {
            exp.Interpret(context);
        }

        Console.WriteLine($"Output: {context.Expression}");
    }
}

