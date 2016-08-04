using AlbionEconDesktop.lib;
using AlbionEconDesktop.model;
using System;
using System.IO;
using System.Linq;

namespace AlbionEconDesktop.storage
{
    public static class FavoriteStorage
    {
        private static string FilePath = Path.Combine(Settings.LocalStoragePath, @"favorites");
        public static string GetLineString(Item item)
        {
            return String.Format("{0}@{1}@true", item.Name, item.Rarity);
        }
        public static void Add(Item item)
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Close();
            }
            using (StreamWriter sw = File.AppendText(FilePath))
            {
                var line = GetLineString(item);
                sw.WriteLine(line);
            }
        }
        public static void Remove(Item item)
        {
            if (!File.Exists(FilePath))
            {
                return;
            }
            var line = GetLineString(item);
            var tempFile = Path.GetTempFileName();
            var linesToKeep = File.ReadLines(FilePath).Where(l => l != line);

            var length = linesToKeep.Count();
            File.WriteAllLines(tempFile, linesToKeep);

            File.Delete(FilePath);
            if (length > 0) File.Move(tempFile, FilePath);
        }
        public static void LoadAll()
        {
            if (File.Exists(FilePath))
            {
                var lines = File.ReadAllLines(FilePath);
                foreach (var line in lines)
                {
                    var sl = line.Split('@');
                    var item = Item.FindByName(sl[0], Int32.Parse(sl[1]));
                    item.IsFavorite = (sl[2] == "true");
                }
            }
        }
    }
}
