using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Birds
{
    #region//Fly
    public interface IFly
    {
        void Fly();
    }
    public class CFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("я умею летать");
        }
    }
    public class DFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("я не умею летать");
        }
    }
    #endregion
    #region//Swim
    public interface ISwim
    {
        void Swim();
    }
    public class CSwim : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("я умею плавать");
        }
    }
    public class DSwim : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("я не умею плавать");
        }
    }
    #endregion
    #region//Quack
    public interface IQuack
    {
        void Quack();
    }
    public class CQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Кря-кря");
        }
    }
    public class DQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("<< Тишина >>");
        }
    }
    public class SQueack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("<< Писк >>");
        }
    }
    #endregion
}
