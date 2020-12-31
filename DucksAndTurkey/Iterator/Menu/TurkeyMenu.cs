using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public class TurkeyMenu
    {
        static int _length = 10;
        int _current = 0;
        MenuItem[] menuItems = new MenuItem[_length];
        public TurkeyMenu()
        {
            menuItems[0] = new MenuItem("Turkey", 5.01);
            menuItems[1] = new MenuItem("Wood Turkey", 6.52);
            menuItems[2] = new MenuItem("Rubber Turkey", 7.14);
            menuItems[3] = new MenuItem("Metall Turkey", 8.07);
            _current = 4;
        }
        public TurkeyMenu(int tt)
        {
        }
        public void AddItem(string name, double price)
        {
            if (_current < _length)
            {
                menuItems[_current] = new MenuItem(name, price);
                _current++;
            }
            else
            {
                throw new Exception("Fault");
            }
        }
        public IIterator CreateIterator()
        {
            return new TurkeyMenuIterator(menuItems);
        }
    }
}
