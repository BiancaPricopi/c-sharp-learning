using System;
namespace tutorial1
{
    class Program
    {
        static void Main(string[] args)
        {
            int friends = 5;
            friends++;
            friends += 6;
            friends -= 2;
            friends--;
            friends *= 6;
            friends /= 4;
            int remainder = friends % 3;
            Console.WriteLine(remainder);
        }
    }
}
