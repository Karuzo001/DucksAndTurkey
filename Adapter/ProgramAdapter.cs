using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Birds;

namespace Adapter
{
    class ProgramAdapter
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
            Turkey turkey = new Turkey();
            Console.WriteLine("\nTurkey");
            turkey.Info();
            TurkeyToDuck turkToDuck = new TurkeyToDuck(turkey);
            Console.WriteLine("\nTurkeyToDuck");
            turkToDuck.Info();
            turkToDuck.Quack();
            Console.ReadLine();
        }
    }
}
