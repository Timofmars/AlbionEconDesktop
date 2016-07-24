using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbionEconDesktop.model
{
    class Item
    {
        public string Name;
        public Recipe Recipe;
        public int Tier;
        public int Rarity;

        public List<Price> Prices = new List<Price>();
    }
}
