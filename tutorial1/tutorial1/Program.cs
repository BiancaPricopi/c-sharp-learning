using System;
namespace tutorial1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3;
            double a = Math.Pow(x, 2);
            double b = Math.Sqrt(a);
            Console.WriteLine(a);
            Console.WriteLine(b);

            int c = -5;
            Console.WriteLine(Math.Abs(c));

            double d = Math.Round(3.14);
            Console.WriteLine(d);

            double e = Math.Ceiling(3.14);
            Console.WriteLine(e);

            double f = 5.5;
            Console.WriteLine(Math.Max(x,f));

            Console.WriteLine(Math.Min(x,f));
        }
    }
}
