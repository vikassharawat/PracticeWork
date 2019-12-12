using System;

namespace Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Base d = new Derived();
            int i = 10;
            d.Func(i);
            Console.ReadLine();
        }
    }
    public class Base
    {
        public virtual void Func(int x)
        {
            Console.WriteLine("Base.Func(int)");
        }
    }
    public class Derived : Base
    {
        public override void Func(int x)
        {
            Console.WriteLine("Derived.Func(int)");
        }
        public void Func(object o)
        {
            Console.WriteLine("Derived.Func(object)");
        }
    }
}
