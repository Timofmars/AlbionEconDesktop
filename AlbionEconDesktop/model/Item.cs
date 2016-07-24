using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbionEconDesktop.model
{
    public class Item
    {
        private static List<Item> _items = new List<Item>();
        public static List<Item> All { get { return _items; } }
    
        public string Name;
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
