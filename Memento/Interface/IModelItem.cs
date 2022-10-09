using Memento.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Interface
{
    internal interface IModelItem
    {
        public object Style { get; }
        public void SetTag(object tag);
        public ModelMemento CreateModelMemento();
        public void SetNodeMemento(ModelMemento nodeMemento);
    }
}
