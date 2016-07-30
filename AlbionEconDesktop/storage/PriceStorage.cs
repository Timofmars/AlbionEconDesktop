using AlbionEconDesktop.lib;
using AlbionEconDesktop.model;
using System;
using System.IO;

namespace AlbionEconDesktop.storage
{
    public static class PriceStorage
    {
        private static string FilePath = Path.Combine(Settings.LocalStoragePath, @"prices");
        public static void Save(Price price)
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath);
            }
            using (StreamWriter sw = File.AppendText(FilePath))
            {
                var line = String.Format("{0}@{1}@{2}@{3}", price.Item.Name, price.Value, price.Timestamp, price.Item.Rarity);
                sw.WriteLine(line);
            }
        }
        public static void LoadAll()
        {
            var tmp = new System.Collections.Generic.List<Price>();
            if (File.Exists(FilePath))
            {
                var lines = File.ReadAllLines(FilePath);
                foreach (var line in lines)
                {
                    var sl = line.Split('@');
                    var item = Item.FindByName(sl[0], Int32.Parse(sl[3]));
                    var itemValue = Int32.Parse(sl[1]);
                    var date = DateTime.Parse(sl[2]);

                    var price = new Price(itemValue, date);
                    item.AddPrice(price);
                }
            }
        }
    }
}
