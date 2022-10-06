using System;

namespace Iterator.Model.Interface
{
    internal interface ICollection<T>
    {
        public Iterator.Business.Iterator CreateIterator();
        public void Add(T item);
        public bool Remove(T item);
        public void Clear();
    }
}
