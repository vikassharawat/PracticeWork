using System;

namespace RefOutKeyWords
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i = 3;
            int j ;
            func1(ref i);
            func2(out j);
            Console.WriteLine(i + " " + j);
            Console.ReadLine();
        }

        static void func1(ref int num)
        {
            num = num + num;
        }
        static void func2(out int num)
        {
            num = 2;
            num = num * num;
        }
    }
}
