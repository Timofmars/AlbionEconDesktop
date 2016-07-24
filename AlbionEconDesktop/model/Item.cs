using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AlbionEconDesktop.model
{
    public class Item
    {
        private static ObservableCollection<Item> _items = new ObservableCollection<Item>();
        public static ObservableCollection<Item> All { get { return _items; } }

        private string _name;
        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public Recipe Recipe;
        public int Tier;
        public int Rarity;

        public List<Price> Prices = new List<Price>();
        
        public static Item FindByName(string name)
        {
            return _items.Where(i => i.Name == name).FirstOrDefault();
        }
        public override string ToString()
        {
            return Name;
        }

        [System.Runtime.Serialization.OnDeserialized]
        internal void OnDeserializedMethod(System.Runtime.Serialization.StreamingContext context)
        {
            _items.Add(this);
        }
    }
}
