using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Model
{
    internal class Context
    {
        private string _expression;

        public Context(string expression)
        {
            _expression = expression.ToUpper();
        }
        public string Expression { get => _expression; set => _expression = value; }
    }
}
