using System;
namespace tutorial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num = random.Next(1, 200);
            Console.WriteLine(num);

            double num2 = random.NextDouble();
            Console.WriteLine(num2);
        }
    }
}
