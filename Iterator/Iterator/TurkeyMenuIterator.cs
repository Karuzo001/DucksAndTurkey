using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class TurkeyMenuIterator : IIterator//IEnumerator<DuckMenu>
    {
        MenuItem[] _items;
        int current = 0;
        public TurkeyMenuIterator(MenuItem[] ddm)
        {
            _items = ddm;
        }
        public Object Next()
        {
            MenuItem menuItem = _items[current];
            current++;
            return menuItem;
        }
        public bool HasNext()
        {
            if (current >= _items.Length || _items[current] == null)
                return false;
            else
                return true;
        }
    }
}
