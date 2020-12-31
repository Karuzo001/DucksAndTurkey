using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Birds
{
    public class Duck : BaseDuck
    {
        public Duck()
            : base(new CFly(), new CSwim(), new CQuack())
        { }
    }
    public class WoodDuck : BaseDuck
    {
        public WoodDuck()
            : base(new DFly(), new CSwim(), new DQuack())
        { }
    }
    public class RubberDuck : BaseDuck
    {
        public RubberDuck()
            : base(new DFly(), new CSwim(), new SQueack())
        { }
    }
    public class MetallDuck : BaseDuck
    {
        public MetallDuck()
            : base(new DFly(), new DSwim(), new DQuack())
        { }
    }
}
