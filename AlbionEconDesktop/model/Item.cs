using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace AlbionEconDesktop.model
{
    public class Item : INotifyPropertyChanged
    {
        private static List<Item> _items = new List<Item>();
        public static List<Item> All { get { return _items; } }

        private string _name;
        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public Recipe Recipe { get; set; }
        public int Tier { get; set; }
        public int Rarity { get; set; } = 1;
        public ItemClass Class { get; set; }
        public bool IsFavorite { get; set; } = false;

        public List<Price> _prices = new List<Price>();
        public List<Price> PriceHistory { get { return _prices; } }
        public int Price {
            get {
                if (_prices.Count == 0) return 0;
                return _prices[0].Value;
            }
        }
        public DateTime PriceDate { get { return _prices.Count > 0 ? _prices[0].Timestamp : new DateTime(1970,1,1,0,0,0,0,DateTimeKind.Utc); } }
        public int Profit
        {
            get
            {
                if (Recipe == null) return 0;
                return (int) (Price * 0.97 - Recipe.CraftCost);
            }
        }
        public void AddPrice(Price price)
        {
            _prices.Insert(0,price);
            price.Item = this;
            NotifyPropertyChanged("Price", "Profit", "PriceHistory", "PriceDate");
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

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(params string[] propertyName)
        {
            foreach (var prop in propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
