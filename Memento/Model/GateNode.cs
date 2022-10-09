using Memento.Business;
using Memento.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Model
{
    internal class GateNode : IModelItem
    {
        private object _style;
        private object _tag;

        public object Style => _style;
        public object Tag { get => _tag; }

        public ModelMemento CreateModelMemento()
        {
            return new ModelMemento(_tag);
        }

        public void SetNodeMemento(ModelMemento nodeMemento)
        {
            _tag = nodeMemento.Tag;
            Console.WriteLine($"Set Memento {_tag}");
        }

        public void SetTag(object tag)
        {
            _tag = tag;
            Console.WriteLine($"Set Tag {_tag}");
        }
    }
}
