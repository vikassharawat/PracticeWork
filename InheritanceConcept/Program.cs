using System;

namespace InheritanceConcept
{
    class Program
    {
       
        public static void Main()
        {
            classC a = new classC();
            Console.WriteLine(a.Print());
        }

        public class classA
        {
            public classA()
            {
                Console.WriteLine("Class A");
            }
            public classA(string p1)
            {
                Console.WriteLine($"Class A with para {p1}");
            }
            public virtual string Print()
            {
                return "classA";
            }
        }

        public class classB : classA
        {
            public classB():base("vikas")
            {
                Console.WriteLine("Class b");
            }
            public override string Print()
            {
                return "classB";
            }
        }

        public class classC : classB
        {
            public classC()
            {
                Console.WriteLine("Class C");
            }
            public new string Print()
            {
                return "ClassC";
            }
        }
    }
}
