using AlbionEconDesktop.controller;
using AlbionEconDesktop.model;
using AlbionEconDesktop.storage;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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
        public static bool FilterUnprofitable { get; set; }
        public static ObservableCollection<Item> PriceUpdateQueue { get { return PriceUpdateController.Queue; } }
        public static ObservableCollection<Item> Items { get {
                return new ObservableCollection<Item>(Item.All.Where(i => i.Name.ToLower().Contains(_filter) && (!FilterUnprofitable || i.Profit > 0)));
            }
        }
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
        private void UpdateItemList()
        {
            ItemListView.ItemsSource = WindowContext.Items;
        }
        private void ItemFilterBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _context.ItemListFilter = (sender as TextBox).Text.ToLower();
            UpdateItemList();
        }
        private void ItemListFilterUnprofitCheckBox_CheckedChanged(object sender, RoutedEventArgs e)
        {
            UpdateItemList();
        }
        private void AddToUpdateQueueButton_Clicked(object sender, RoutedEventArgs e)
        {
            PriceUpdateController.AddToQueue(ItemListView.ItemsSource as System.Collections.Generic.IEnumerable<Item>, (bool) AddRecursiveCheckbox.IsChecked);
        }

        #region UpdateQueue
        private void UpdateQueuePrice_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                UpdatePriceSaveButton_Clicked(null, null);
            }
        }
        private void UpdatePriceSaveButton_Clicked(object sender, RoutedEventArgs e)
        {
            PriceUpdateController.AddPrice(WindowContext.PriceUpdateQueue[0], Int32.Parse(PriceUpdateTextBox.Text));
            PriceUpdateTextBox.SelectAll();
        }
        #endregion
    }
}
