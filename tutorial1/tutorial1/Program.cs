using System;
namespace tutorial1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 3.14;
            int b = Convert.ToInt32(a);
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());

            int c = 123;
            double d = Convert.ToDouble(c) + 0.1;
            Console.WriteLine(d);

            int e = 321;
            String f = Convert.ToString(e) + "uuaua";
            Console.WriteLine(f);

            String g = "$";
            char h = Convert.ToChar(g);
            Console.WriteLine(h);

            String i = "true";
            bool j = Convert.ToBoolean(i);
            Console.WriteLine(j);
        }
    }
}
