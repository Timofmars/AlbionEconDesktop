using System.ComponentModel;

namespace AlbionEconDesktop.model
{
    public class Component
    {
        private int _count;

        public Item Item { get; private set; }
        public int Count
        {
            get{ return _count; }
            set { _count = value; }
        }

        public Component(Item item, int count)
        {
            Item = item;
            Count = count;
        }

        public override string ToString()
        {
            return string.Format("{0}x .{1} {2}", Count, Item.Rarity, Item.Name);
        }
    }
}
