using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbionRecipeJson
{
    [JsonObject(IsReference = true)]
    class Item
    {
        public string Name;
        public int Tier;
        public int? Rarity;
        public Recipe Recipe;

        public Item(string name, int tier, int rarity) : 
            this(name, tier)
        {
            Rarity = rarity;
        }
        public Item(string name, int tier) 
        {
            Name = name;
            Tier = tier;
        }
    }
}
