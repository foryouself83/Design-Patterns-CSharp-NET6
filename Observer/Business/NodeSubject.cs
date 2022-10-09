using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Business
{
    internal class NodeSubject : Subject
    {
        private double _cutsetValue;

        public double CutsetValue { get => _cutsetValue; set { _cutsetValue = value; } }
    }
}
