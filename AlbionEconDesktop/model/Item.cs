using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AlbionEconDesktop.model
{
    public class Item
    {
        private static List<Item> _items = new List<Item>();
        public static List<Item> All { get { return _items; } }

        private string _name;
        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public Recipe Recipe;
        public int Tier { get; set; }
        public int Rarity { get; set; }

        public List<Price> _prices = new List<Price>();
        public List<Price> PriceHistory { get { return _prices; } }
        public int Price {
            get {
                if (_prices.Count == 0) return 0;
                return _prices[0].Value;
            }
        }
        public int Profit
        {
            get
            {
                if (Recipe == null) return 0;
                return Price - Recipe.CraftCost;
            }
        }
        public void AddPrice(Price price)
        {
            _prices.Insert(0,price);
            price.Item = this;
        }
        
        public static Item FindByName(string name)
        {
            return _items.Where(i => i.Name == name).FirstOrDefault();
        }
        public static Item FindByName(string name, int rarity)
        {
            return _items.Where(i => i.Name == name && i.Rarity == rarity).FirstOrDefault();
        }
        public override string ToString()
        {
            return string.Format("{0} (Rarity: {1})", Name, Rarity);
        }

        [System.Runtime.Serialization.OnDeserialized]
        internal void OnDeserializedMethod(System.Runtime.Serialization.StreamingContext context)
        {
            _items.Add(this);
        }
    }
}
