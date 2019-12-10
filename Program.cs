using System;
using System.Linq;
using System.Collections.Generic;

namespace DelegateUse
{
    delegate string del(string str);
    class sample
    {
        public static string DelegateSample(string a)
        {
            return a.Replace(',', '*');
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            del str1 = new del(sample.DelegateSample);
            string str = str1("Welcome,,friends,,to,,TechBeamers");
            Console.WriteLine(str);
            Console.ReadLine();
        }
       
        public class First
        {
            public virtual void Show()
            {
                Console.WriteLine("Object of first class called");
            }
            public void ArrayCollection()
            {
                int[] array = new int[10];
                Console.WriteLine("enter the values of array");
               for(int i=0;i<10;i++)
                {
                    array[i]= int.Parse(Console.ReadLine());                  
                    if (array[i] == 0)
                    {
                        break;
                    }
                }
                var shn = array.OrderByDescending(x => x).Skip(1).FirstOrDefault();
                // secondhighestnumber(array);
                Console.WriteLine("second highest number is:{0}",shn);
                Console.ReadLine();
            }
        }
        public class Second : First
        {
            public override void Show()
            {
                Console.WriteLine("Object of second class called");
            }
        }
    }
   
}
