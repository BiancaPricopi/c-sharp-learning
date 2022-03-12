using System;
namespace tutorial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);

            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are " + age + " years old.");
        }
    }
}
