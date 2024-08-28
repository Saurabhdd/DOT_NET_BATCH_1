using System;

namespace ClassTypeDemo
{
    public class DemoClass
    {
        int a;
        double d;

        private void method1()
        {
            Console.WriteLine("Inside method1()");
        }

        public static void Main(string[] args)
        {
            DemoClass dc = new DemoClass();
            dc.method1();
        }
    }
}

