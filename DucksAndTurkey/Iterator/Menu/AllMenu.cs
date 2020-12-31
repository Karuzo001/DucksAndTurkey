using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public class AllMenu
    {
        private DuckMenu _DuckMenu;
        private TurkeyMenu _TurkeyMenu;
        public AllMenu(DuckMenu DuckMenu, TurkeyMenu TurkeyMenu)
        {
            _DuckMenu = DuckMenu;
            _TurkeyMenu = TurkeyMenu;
        }
        public void PrintMenu()
        {
            IIterator DuckIterator = _DuckMenu.CreateIterator();
            IIterator TurkeyIterator = _TurkeyMenu.CreateIterator();
            Console.WriteLine("\tDuck Menu:\n ");
            PrintMenu(DuckIterator);
            Console.WriteLine("\n\tTurkey Menu: \n");
            PrintMenu(TurkeyIterator);
        }
        public void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                Console.WriteLine("{0}  {1}", menuItem.Name, menuItem.Price);
            }
        }
    }
}
