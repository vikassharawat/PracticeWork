using System;

namespace CustomExceptions
{
    public class Calculation
    {
        int sum = 0;
        int count = 0;
        float average;
        public void CalAverage()
        {
            if (count == 0)
                throw (new CountIsZeroException("Zero count in DoAverage"));
            {
                average = sum / count;
                Console.WriteLine("Average is :{0}",average);
                Console.WriteLine("Program executed successfully");
            }
        }
    }

    public class CountIsZeroException : ApplicationException
    {
        public CountIsZeroException(string message) : base(message)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
            try
            {
                c.CalAverage();
            }
            catch (CountIsZeroException e)
            {
                Console.WriteLine("CountIsZeroException : {0}", e);
            }
            Console.ReadLine();
        }
    }
}
