using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract new string getDescription();
    }
    public class MoreSous : CondimentDecorator
    {
        Beverage _beverage;
        public MoreSous(Beverage beverage)
        {
            _beverage = beverage;
            _description = getDescription();
        }
        public override string getDescription()
        {
            return _beverage.getDescription() + ", More Sous";
        }
        public override double Cost()
        {
            return 1.11 + _beverage.Cost();
        }
    }

    public class MoreMeat : CondimentDecorator
    {
        Beverage _beverage;
        public MoreMeat(Beverage beverage)
        {
            _beverage = beverage;
            _description = getDescription();
        }
        public override string getDescription()
        {
            return _beverage.getDescription() + ", More Meat";
        }
        public override double Cost()
        {
            return 2.22 + _beverage.Cost();
        }
    }
    public class MoreSalat : CondimentDecorator
    {
        Beverage _beverage;
        public MoreSalat(Beverage beverage)
        {
            _beverage = beverage;
            _description = getDescription();
        }
        public override string getDescription()
        {
            return _beverage.getDescription() + ", More Salat";
        }
        public override double Cost()
        {
            return 0.68 + _beverage.Cost();
        }
    }
}
