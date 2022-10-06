
using Iterator.Model;

namespace Iterator.Business
{
    internal class Collection : Model.Interface.ICollection<Item>
    {
        List<Item> items = new List<Item>();
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get => items.Count;
        }

        public Item this[int index]
        {
            get => items[index];
            set => items.Add(value);
        }
        public void Add(Item item)
        {
            items.Add(item);
        }

        public bool Remove(Item item)
        {
            return items.Remove(item);
        }

        public void Clear()
        {
            items.Clear();
        }
    }
}
