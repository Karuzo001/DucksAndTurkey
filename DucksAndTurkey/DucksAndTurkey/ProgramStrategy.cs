using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Birds;
namespace DucksAndTurkey
{
    class ProgramStrategy
    {
        static void Main(string[] args)
        {
            Duck dd = new Duck();
            Console.WriteLine("Duck");
            dd.Info();
            WoodDuck wd = new WoodDuck();
            Console.WriteLine("\nWoodDuck");
            wd.Info();
            RubberDuck rb = new RubberDuck();
            Console.WriteLine("\nRubberDuck");
            rb.Info();
            MetallDuck md = new MetallDuck();
            Console.WriteLine("\nMetallDuck");
            md.Info();
            Console.ReadLine();
        }
    }
}
