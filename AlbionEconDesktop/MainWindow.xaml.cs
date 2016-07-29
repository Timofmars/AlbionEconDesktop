using AlbionEconDesktop.model;
using AlbionEconDesktop.storage;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AlbionEconDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    class WindowContext : INotifyPropertyChanged
    {
        private static string _filter = "";
        public string ItemListFilter {
            get { return _filter; }
            set { _filter = value; NotifyPropertyChanged("Items"); }
        }
        public static ObservableCollection<Item> Items { get { return new ObservableCollection<Item>(Item.All.Where(p => p.Name.ToLower().Contains(_filter))); } }
        private static Item _price;
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
            InitializeComponent();
            _context = DataContext as WindowContext;
        }
        private void Itemlist_MouseUp(object sender, System.Windows.Input.MouseEventArgs e)
        {
            _context.PriceHistoryItem = (sender as ListView).SelectedItem as Item;
        }

        private void ItemFilterBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _context.ItemListFilter = (sender as TextBox).Text.ToLower();
            ItemListView.ItemsSource = WindowContext.Items;
        }
    }
}
