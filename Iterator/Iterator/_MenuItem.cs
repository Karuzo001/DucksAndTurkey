using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public interface IIterator
    {
        bool HasNext();
        Object Next();
    }
    public class MenuItem
    {
        private string _name;
        private double _price;
        public MenuItem(string name, double price)
        {
            _name = name;
            _price = price;
        }
        public string Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }
        public double Price
        {
            set
            {
                _price = value;
            }
            get
            {
                return _price;
            }
        }
    }
}
