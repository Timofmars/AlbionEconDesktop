using AlbionEconDesktop.model;
using AlbionEconDesktop.storage;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace AlbionEconDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    class WindowContext : INotifyPropertyChanged
    {
        public static ObservableCollection<Item> Items { get { return Item.All; } }
        public static Item _price;
        public Item PriceHistoryItem {
            get { return _price; }
            set { _price = value; NotifyPropertyChanged("PriceHistoryItem"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
    public partial class MainWindow : Window
    {
        private WindowContext _context;
        public MainWindow()
        {
            JsonHandler.DeserializeRecipes();
            PriceStorage.LoadAll();
            WindowContext._price = Item.FindByName("Copper Ore");
            InitializeComponent();
            _context = DataContext as WindowContext;
            var x = new DataGrid();
        }
        private void Itemlist_MouseUp(object sender, System.Windows.Input.MouseEventArgs e)
        {
            _context.PriceHistoryItem = (sender as ListView).SelectedItem as Item;
        }
    }
}
