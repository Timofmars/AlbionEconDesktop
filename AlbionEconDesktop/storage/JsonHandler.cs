using AlbionEconDesktop.model;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AlbionEconDesktop.storage
{
    public class JsonHandler
    {
        public void DeserializeRecipes()
        {
            var json = System.IO.File.ReadAllText(@"resources\recipes.json");
            JsonConvert.DeserializeObject<List<Item>>(json, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.All });
        }
    }
}
