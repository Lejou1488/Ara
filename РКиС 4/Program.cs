using System;

namespace РКиС_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double res = 0;

            double a = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            Primer();
            Primer2(a, c, d, res);
            Console.WriteLine(Inc(a, c, d, res));
            Console.WriteLine(Inc(ref a, c, d, res));
        }
        public static void Primer()
        {
            double a = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine((c/d +Math.Log(3*a/2))/(c-a+1));
        }
        public static void Primer2(double a, double c, double d, double res)
        {
            res = (c / d + Math.Log(3 * a / 2)) / (c - a + 1);
            Console.WriteLine(res);
        }
        
        public static double Inc(double a, double c, double d, double res)
        {
            res = (c / d + Math.Log(3 * a / 2)) / (c - a + 1);
            return res;
        }
        public static double Inc(ref double a, double c, double d, double res)
        {
            
            res = (c / d + Math.Log(3 * a / 2)) / (c - a + 1);
            return res;
        }
    }
}
