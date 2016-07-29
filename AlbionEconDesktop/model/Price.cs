using System;

namespace AlbionEconDesktop.model
{
    public class Price
    {
        public int Value { get; set; }
        public DateTime Timestamp { get; set; }
        public Item Item { get; set; }

        public Price(int value, DateTime timestamp)
        {
            Value = value;
            Timestamp = timestamp;
        }
        public override string ToString()
        {
            return Item.Name + " " + Value + " " + Timestamp;
        }
    }
}