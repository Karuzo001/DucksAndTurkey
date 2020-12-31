using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Birds
{
    public class BaseDuck
    {
        private readonly IFly _fly;
        private readonly ISwim _swim;
        private readonly IQuack _quack;
        protected BaseDuck(IFly fly, ISwim swim, IQuack quack)
        {
            _fly = fly;
            _swim = swim;
            _quack = quack;
        }

        public void Fly()
        {
            _fly.Fly();
        }
        public void Swim()
        {
            _swim.Swim();
        }
        public void Quack()
        {
            _quack.Quack();
        }
        public void Info()
        {
            _fly.Fly();
            _swim.Swim();
            _quack.Quack();
        }
    }
}
