using System;

namespace ObjectClassEx
{
    class MainClass
    {
        public static void Main(String[] args)
        {
            Student std = new Student(10);   //A
            Student std1 = new Student(10);  //B

            Student std2 = std;

            Console.WriteLine(std.Equals(std1));
            Console.WriteLine(Object.ReferenceEquals(std1, std));
            Console.WriteLine(Object.ReferenceEquals(std2, std));

            Console.WriteLine(std.ToString());
        }
    }
}