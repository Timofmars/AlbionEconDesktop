using AlbionEconDesktop.model;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using AlbionEconDesktop.lib;

namespace AlbionEconDesktop.storage
{
    public static class JsonHandler
    {
        public static void DeserializeRecipes()
        {
            string json;
            var locstore = Path.Combine(Settings.LocalStoragePath, @"recipes.json");
            if (File.Exists(locstore)) json = File.ReadAllText(locstore);
            else json = File.ReadAllText(@"resources\recipes.json");
            JsonConvert.DeserializeObject<List<Item>>(json, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.All });
        }
    }
}
