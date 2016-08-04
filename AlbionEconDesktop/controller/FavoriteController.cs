using AlbionEconDesktop.model;
using AlbionEconDesktop.storage;
using System;

namespace AlbionEconDesktop.controller
{
    class FavoriteController
    {
        public static void AddFavorite(Item item)
        {
            item.IsFavorite = true;
            FavoriteStorage.Add(item);
        }
        public static void RemoveFavorite(Item item)
        {
            item.IsFavorite = false;
            FavoriteStorage.Remove(item);
        }
    }
}
