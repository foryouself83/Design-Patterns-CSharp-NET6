using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Model.Interface
{
    internal interface IExpression
    {
        public void Interpret(Context context);
    }
}
