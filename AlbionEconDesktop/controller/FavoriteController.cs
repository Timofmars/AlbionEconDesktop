using AlbionEconDesktop.model;
using AlbionEconDesktop.storage;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlbionEconDesktop.controller
{
    class FavoriteController
    {
        private static List<Item> _favorites;
        public static List<Item> List
        {
            get
            {
                if (_favorites == null) _favorites = new List<Item>(Item.All.Where(i => i.IsFavorite));
                return _favorites;
            }
        }
        public static void AddFavorite(Item item)
        {
            item.IsFavorite = true;
            FavoriteStorage.Add(item);
            List.Add(item);
        }
        public static void RemoveFavorite(Item item)
        {
            item.IsFavorite = false;
            FavoriteStorage.Remove(item);
            List.Remove(item);
        }
    }
}
