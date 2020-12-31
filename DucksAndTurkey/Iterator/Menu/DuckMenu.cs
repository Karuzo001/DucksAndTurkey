using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public class DuckMenu
    {
        List<MenuItem> menuItems = new List<MenuItem>();
        public DuckMenu()
        {
            menuItems.Add(new MenuItem("Duck", 1.00));
            menuItems.Add(new MenuItem("Wood Duck", 2.52));
            menuItems.Add(new MenuItem("Rubber Duck", 3.14));
            menuItems.Add(new MenuItem("Metall Duck", 4.07));
        }
        public DuckMenu(int tt)
        {
        }
        public void AddItem(string name, double price)
        {
            menuItems.Add(new MenuItem(name, price));
        }
        public IIterator CreateIterator()
        {
            return new DuckMenuIterator(menuItems);
        }
    }
}
