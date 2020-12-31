using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class DuckMenuIterator : IIterator
    {
        List<MenuItem> _items;
        int current = 0;
        public DuckMenuIterator(List<MenuItem> ddm)
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
            if (current >= _items.Count || _items[current] == null)
                return false;
            else
                return true;
        }
    }
}
