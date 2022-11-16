using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactFactory.Model
{
    internal class EventCutSetCalModel : CutSetCalModel
    {
        public EventCutSetCalModel()
        {
            Console.WriteLine($"{GetType().Name}");
        }
    }
}
