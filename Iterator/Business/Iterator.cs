using Iterator.Model;
using Iterator.Model.Interface;

namespace Iterator.Business
{
    internal class Iterator : IIterator<Item>
    {
        Collection _collection;
        int _current = 0;

        public Iterator(Collection collection)
        {
            _collection = collection;
        }

        public Item? First()
        {
            _current = 0;
            return _collection[_current];
        }

        public Item? Next()
        {
            _current++;
            if (!IsDone)
                return _collection[_current];
            else
                return null;
        }

        public Item? CurrentItem
        {
            get { return _collection[_current]; }
        }

        public bool IsDone
        {
            get { return _current >= _collection.Count; }
        }
    }
}
