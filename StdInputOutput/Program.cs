using System;

namespace StandardIO
{
    class ConsoleApp
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Standard IO example");
            Console.WriteLine("===================");
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Output: Your name is : " + name);
        }
    }
}