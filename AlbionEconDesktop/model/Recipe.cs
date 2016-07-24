using System.Collections.Generic;

namespace AlbionEconDesktop.model
{
    public class Recipe
    {
        public class Component
        {
            Item Item;
            int Count;
        }

        Item CreatedItem;
        List<Component> Components = new List<Component>();
    }
}