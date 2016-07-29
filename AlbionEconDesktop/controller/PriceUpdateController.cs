using AlbionEconDesktop.model;
using AlbionEconDesktop.storage;
using System;

namespace AlbionEconDesktop.controller
{
    public static class PriceUpdateController
    {
        public static void AddPrice(Item item, int value)
        {
            var p = new Price(value, DateTime.Now);
            item.AddPrice(p);
            PriceStorage.Save(p);
        }
    }
}
