using System;

namespace StaticConstructor
{
    class Program
    {
        public static void Main()
        {
            var test = SingletonB.Test;
            Console.ReadLine();
        }
    }

    class SingletonB
    {
        static readonly SingletonB _instance = new SingletonB();
        public static SingletonB Test { get { return _instance; } }

        private SingletonB()
        {
            Console.WriteLine("Default Constructor");
        }

        static SingletonB()
        {
            Console.WriteLine("Static Constructor");
        }
    }
}
