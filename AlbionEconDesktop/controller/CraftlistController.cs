using AlbionEconDesktop.model;
using System.Collections.ObjectModel;

namespace AlbionEconDesktop.controller
{
    public static class CraftlistController
    {
        private static ObservableCollection<Component> _craftlist = new ObservableCollection<Component>();
        public static ObservableCollection<Component> Craftlist
        {
            get { return _craftlist; }
        }

        public static void AddItemToList(Item item, int count)
        {
            var comp = findCompnentWithItem(item);
            if (comp == null)
            {
                comp = new Component(item, 0);
                Craftlist.Add(new Component(item, count));
            }
            comp.Count += count;
        }
        public static void RemoveComponentFromList(Component component)
        {
            _craftlist.Remove(component);
        }

        private static Component findCompnentWithItem(Item item)
        {
            foreach (var c in Craftlist)
            {
                if (c.Item == item) return c;
            }
            return null;
        }
    }
}
