using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public abstract class Beverage
    {
        protected string _description = "Unknown Beverage";
        public string getDescription()
        {
            return _description;
        }
        public abstract double Cost();
    }
    public class Duck : Beverage
    {
        public Duck()
        {
            _description = "Duck";
        }
        public override double Cost()
        {
            return 3.33;
        }
    }
    public class Duckling : Beverage
    {
        public Duckling()
        {
            _description = "Duckling";
        }
        public override double Cost()
        {
            return 1.78;
        }
    }
    public class Turkey : Beverage
    {
        public Turkey()
        {
            _description = "Turkey";
        }
        public override double Cost()
        {
            return 4.43;
        }
    }
}
