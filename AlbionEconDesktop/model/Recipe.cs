using System;
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

        public List<Component> Components;

        public int CraftCost
        {
            get
            {
                var c = 0;
                foreach (var comp in Components) {
                    c += comp.Item.Price * comp.Count;
                }
                return c;
            }
        }
        public DateTime OldestPrice
        {
            get
            {
                DateTime d = DateTime.Now;
                foreach (var c in Components)
                {
                    if (c.Item.PriceDate < d) d = c.Item.PriceDate;
                }
                return d;
            }
        }
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