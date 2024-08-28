/*
void (*fun_ptr)(int);

fun_ptr = &fun;
fun_ptr(10);
*/

namespace DeletegateEx
{
    delegate void MyDelegate(int b);

    class Demo
    {
        static void TestMethod(int a)
        {
            System.Console.WriteLine("Test method called");
        }

        public static void Main(string[] args)
        {
            MyDelegate md = new MyDelegate(Demo.TestMethod);
            md(10);
        }
    }

    
}