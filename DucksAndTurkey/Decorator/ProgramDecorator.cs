using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class ProgramDecorator
    {
        static void Main(string[] args)
        {
            Beverage beverage1 = new Turkey();
            Console.WriteLine("{0}: {1}", beverage1.getDescription(), beverage1.Cost());
            beverage1 = new MoreMeat(beverage1);
            Console.WriteLine("{0}: {1}", beverage1.getDescription(), beverage1.Cost());
            beverage1 = new MoreSalat(beverage1);
            Console.WriteLine("{0}: {1}\n", beverage1.getDescription(), beverage1.Cost());

            Beverage beverage2 = new Duck();
            Console.WriteLine("{0}: {1}", beverage2.getDescription(), beverage2.Cost());
            beverage2 = new MoreSous(beverage2);
            Console.WriteLine("{0}: {1}", beverage2.getDescription(), beverage2.Cost());
            beverage2 = new MoreSalat(beverage2);
            Console.WriteLine("{0}: {1}\n", beverage2.getDescription(), beverage2.Cost());

            Beverage beverage3 = new Turkey();
            Console.WriteLine("{0}: {1}", beverage3.getDescription(), beverage3.Cost());
            beverage3 = new MoreMeat(beverage3);
            Console.WriteLine("{0}: {1}", beverage3.getDescription(), beverage3.Cost());
            beverage3 = new MoreSous(beverage3);
            Console.WriteLine("{0}: {1}\n", beverage3.getDescription(), beverage3.Cost());
        }
    }
}
