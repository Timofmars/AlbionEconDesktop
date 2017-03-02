using AlbionEconDesktop.model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AlbionEconDesktop.controller
{
    public static class ShoppinglistController
    {
        private static ObservableCollection<Component> _shoppinglist = new ObservableCollection<Component>();
        public static ObservableCollection<Component> Shoppinglist
        {
            get { return _shoppinglist; }
        }
        public static void UpdateShoppinglist(IEnumerable<Component> list)
        {
            _shoppinglist.Clear();
            foreach (Component listComponent in list)
            {
                if (listComponent.Item.Recipe != null)
                {
                    foreach (var component in listComponent.Item.Recipe.Components)
                    {
                        var comp = findCompnentWithItem(component.Item);
                        if (comp == null) _shoppinglist.Add(new Component(component.Item, listComponent.Count * component.Count));
                        else comp.Count += listComponent.Count * component.Count;
                    }
                }
            }
        }
        private static Component findCompnentWithItem(Item item)
        {
            foreach (var c in _shoppinglist)
            {
                if (c.Item == item) return c;
            }
            return null;
        }
    }
}
