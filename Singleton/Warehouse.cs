using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class Warehouse
    {
        private static Dictionary<string, int> _dict;
        private Warehouse() { }//пустой приватный конструктор
        public static Dictionary<string, int> Get()//создает ЕДИНСТВЕННЫЙ экземпяр словаря
        {
            if (_dict == null)
                _dict = new Dictionary<string, int>();
            return _dict;
        }
        public static void Add(string key, int value)//Пополнение склада
        {
            if (_dict.ContainsKey(key))
                _dict[key] += value;
            else
                _dict.Add(key, value);
        }
        public static void Sub(string key, int value)//Вывоз со склада
        {
            if (_dict.ContainsKey(key))
                if ((_dict[key] - value) > 0)
                    _dict[key] -= value;
                else
                    Console.WriteLine("'{0}' в недостаточном количестве!\nНа складе: {1}\nНеобходимо: {2}", key, _dict[key], value);
            ////Можно сделать иначе:
            //else
            //{
            //    Console.WriteLine("'{0}' в недостаточном количестве!\nНедостаточно: {1} ", key, value - _dict[key]);
            //    _dict[key] = 0;
            //}
            else
                Console.WriteLine("'{0}' отсутствует ", key);
        }
        public static bool ContainsKey(string key)//Это есть на складе?
        {
            return _dict.ContainsKey(key);
        }
        public static void Show()//Что есть на складе??
        {
            Console.WriteLine("              Warehouse");
            foreach (var item in _dict)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
            Console.WriteLine();
        }
    }
}
