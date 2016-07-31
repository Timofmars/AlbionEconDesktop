using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbionRecipeJson
{
    class Recipe
    {
        public class Component
        {
            public int Count;
            public Item Item;

        }
        public Item CreatedItem;
        public int? CreatedCount;
        public List<Component> Components = new List<Component>();

        public Recipe(Item createdItem)
        {
            CreatedItem = createdItem;
            createdItem.Recipe = this;
        }
        public Recipe(Item createdItem, int count) :
            this(createdItem)
        {
            CreatedCount = count;
        }
        public void AddComponent(Item item, int count)
        {
            Components.Add(new Component()
            {
                Item = item,
                Count = count
            });
        }
    }
}
