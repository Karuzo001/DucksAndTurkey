using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class ProgramSingleton
    {
        static void Main(string[] args)
        {
            Warehouse.Get();
            Warehouse.Add("Duck", 15);
            Warehouse.Sub("Duck", 17);
            Warehouse.Add("Duck", 1);
            Warehouse.Add("Duckling", 2);
            Warehouse.Add("Turkey", 3);
            Warehouse.Add("Chicken", 4);
            Warehouse.Show();
            Console.WriteLine("Есть {0} на складе? {1}", "Turkey", Warehouse.ContainsKey("Turkey"));
            Console.WriteLine("Есть {0} на складе? {1}", "Wood Duck", Warehouse.ContainsKey("Wood Duck"));
        }
    }
}
