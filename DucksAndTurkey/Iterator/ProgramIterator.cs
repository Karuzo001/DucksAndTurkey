using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class ProgramIterator
    {
        static void Main(string[] args)
        {
        //IEnumerator
            AllMenu menu1 = new AllMenu(new DuckMenu(), new TurkeyMenu());
            DuckMenu dm = new DuckMenu(1);
            dm.AddItem("Eternal Dragon Fire",25.49);
            dm.AddItem("Who are you , Duck ??",9.64);
            dm.AddItem("I was cooked and I began zombie ",3.33);
            dm.AddItem("Lunch for Satan", 3.49);
            dm.AddItem("Devil`s summon", 6.66);
            TurkeyMenu tm = new TurkeyMenu(1);
            tm.AddItem("First circle of hell", 1.11);
            tm.AddItem("Second circle of hell", 2.22);
            tm.AddItem("Third circle of hell", 3.33);
            tm.AddItem("Fourth circle of hell", 4.44);
            tm.AddItem("Fifth circle of hell", 5.55);
            tm.AddItem("Sixth circle of hell", 6.66);
            tm.AddItem("Seventh circle of hell", 7.77);
            AllMenu menu2 = new AllMenu(dm, tm);
            Console.WriteLine("First menu");
            menu1.PrintMenu();
            Console.WriteLine("\nSecond menu");
            menu2.PrintMenu();
            Console.WriteLine("\nWhich will menu you choose ?");
            Console.ReadLine();
        }
    }
}
