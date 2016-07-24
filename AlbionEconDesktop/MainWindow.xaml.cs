using AlbionEconDesktop.model;
using AlbionEconDesktop.storage;
using System.Collections.ObjectModel;
using System.Windows;

namespace AlbionEconDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    class WindowContext
    {
        public static ObservableCollection<Item> Items { get { return Item.All; } }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var json = new JsonHandler();
            json.DeserializeRecipes();
        }
    }
}
