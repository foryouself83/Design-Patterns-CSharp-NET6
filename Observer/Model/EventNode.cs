using Observer.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Model
{
    internal class EventNode : NodeObserver
    {
        private string _id;
        private double _cutsetValue;
        private NodeSubject _subject;

        public EventNode(NodeSubject subject, double cutsetValue)
        {
            _id = Guid.NewGuid().ToString();
            _cutsetValue = cutsetValue;
            _subject = subject;
        }
        public override void Update()
        {
            _cutsetValue = _subject.CutsetValue;
            Console.WriteLine($"Subject Detach: {ToString()}");
        }
        public override string ToString()
        {
            return string.Format($"ID: {_id} Cutset : {_cutsetValue}");
        }
    }
}
