using AlbionEconDesktop.model;
using AlbionEconDesktop.storage;
using System.Collections.Generic;
using System.Windows;

namespace AlbionEconDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Item> items = new List<Item>();
        public MainWindow()
        {
            InitializeComponent();
            var json = new JsonHandler();
            json.DeserializeRecipes();
        }
    }
}
