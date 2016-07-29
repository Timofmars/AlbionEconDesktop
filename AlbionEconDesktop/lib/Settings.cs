using System;
using System.Diagnostics;
using System.IO;

namespace AlbionEconDesktop.lib
{
    public static class Settings
    {
        public static string LocalStoragePath
        {
            get
            {
                var p = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"krss\albionecon");
                if (!Directory.Exists(p))
                    Directory.CreateDirectory(p);
                return p;
            }
        }
    }
}
