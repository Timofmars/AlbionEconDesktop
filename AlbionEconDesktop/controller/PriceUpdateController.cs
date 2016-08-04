using AlbionEconDesktop.model;
using AlbionEconDesktop.storage;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace AlbionEconDesktop.controller
{
    public static class PriceUpdateController
    {
        public static void AddPrice(Item item, int value)
        {
            if (value > 0)
            {
                var p = new Price(value, DateTime.Now);
                item.AddPrice(p);
                PriceStorage.Save(p);
            }
            Queue.Remove(item);
        }
        private static ObservableCollection<Item> _queue = new ObservableCollection<Item>();
        public static ObservableCollection<Item> Queue
        {
            get { return _queue; }
        }

        public static void AddToQueue(System.Collections.Generic.IEnumerable<Item> itemList, bool addmaterials, bool recursive)
        {
            if (addmaterials)
            {
                foreach (var item in itemList)
                {
                    if (item.Recipe != null)
                    {
                        AddToQueue(item.Recipe.Components.Select(i => i.Item), recursive, recursive);
                    }
                }
            }
            foreach (var item in itemList) {
                if (!Queue.Contains(item))
                {
                    Queue.Add(item);
                }

            }
        }
    }
}
