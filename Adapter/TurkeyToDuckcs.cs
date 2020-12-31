using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Birds;

namespace Adapter
{
    public class TurkeyToDuck : Duck
    {
        private Turkey _turkey;
        public TurkeyToDuck(Turkey turkey)
        {
            _turkey = turkey;
        }
        public new void Quack()
        {
            _turkey.Gobble();
        }
        public new void Fly()
        {
            _turkey.Fly();
        }
        public new void Info()
        {
            _turkey.Fly();
            _turkey.Swim();
            _turkey.Gobble();
        }
    }
}
