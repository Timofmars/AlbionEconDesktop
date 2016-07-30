using Newtonsoft.Json;
using System.Collections.Generic;

namespace AlbionEconDesktop.model
{
    public class Recipe
    {
        public class Component
        {
            public Item Item;
            public int Count;
        }
        
        public Item CreatedItem;

        [JsonProperty("Components")]
        public List<Component> Components;

        public override string ToString()
        {
            var str = "(";
            foreach (Component c in Components)
            {
                str += c.Count + "x" + c.Item;
            }
            str += ")";
            return str;
        }
    }
}