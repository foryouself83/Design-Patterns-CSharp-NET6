using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Business
{
    internal class Memento
    {
        private ModelMemento? _nodeMemento;

        public ModelMemento? NodeMemento { get => _nodeMemento; set => _nodeMemento = value; }
    }
}
