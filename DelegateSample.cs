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
    class DelegateSample
    {
        static void Main(string[] args)
        {

            del str1 = new del(sample.DelegateSample);
            string str = str1("Welcome,,friends,,to,,TechBeamers");
            Console.WriteLine(str);
            Console.ReadLine();
        }
       
   
    }
   
}
