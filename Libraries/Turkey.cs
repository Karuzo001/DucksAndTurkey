using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Birds
{
    #region//Gobble
    public interface IGobble
    {
        void Gobble();
    }
    public class CGobble : IGobble
    {
        public void Gobble()
        {
            Console.WriteLine("...Gobble Gobble...");
        }
    }
    public class DGobble : IGobble
    {
        public void Gobble()
        {
            Console.WriteLine("<< Тишина >>");
        }
    }
    #endregion
    public class Turkey
    {
        private IFly _fly;
        private ISwim _swim;
        private IGobble _gobble;
        public Turkey()
        {
            _fly = new CFly();
            _swim = new CSwim();
            _gobble = new CGobble();
        }
        public void Fly()
        {
            _fly.Fly();
        }
        public void Swim()
        {
            _swim.Swim();
        }
        public void Gobble()
        {
            _gobble.Gobble();
        }
        public void Info()
        {
            _fly.Fly();
            _swim.Swim();
            _gobble.Gobble();
        }
    }
}
