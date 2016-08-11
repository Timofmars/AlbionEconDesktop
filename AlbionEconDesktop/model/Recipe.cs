using System;
using System.Collections.Generic;

namespace AlbionEconDesktop.model
{
    public class Recipe
    {
        public Item CreatedItem;
        public int CreatedCount = 1;
        public List<Component> Components;

        public int CraftCost
        {
            get
            {
                var c = 0;
                foreach (var comp in Components) {
                    c += comp.Item.Price * comp.Count;
                }
                return c / CreatedCount;
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
        public DateTime NewestPrice
        {
            get
            {
                DateTime d = Components[0].Item.PriceDate;
                foreach (var c in Components)
                {
                    if (c.Item.PriceDate > d) d = c.Item.PriceDate;
                }
                return d;
            }
        }
        private static int[] baseValue = { 0, 0, 0, 30, 70, 150, 309, 0, 0 };
        public int ReturnsPayOfBelowTaxof
        {
            get
            {
                int tax = 1;
                foreach (var c in Components)
                {
                    tax += c.Count * baseValue[c.Item.Tier];
                }
                if (tax == 0) return 1000;
                return CraftCost * 15 / tax;
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