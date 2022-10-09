using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Business
{
    internal class ModelMemento
    {
        private object _tag;
        public ModelMemento(object tag)
        {
            _tag = tag;
        }
        public object Tag
        {
            get { return _tag; }
        }
    }
}
