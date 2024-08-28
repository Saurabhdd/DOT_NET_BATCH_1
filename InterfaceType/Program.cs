using System;

interface myInterface1
{
    void TestMethod();
}

interface myInterface2: myInterface1
{
    void TestMethod2();
}

class MyClass : myInterface2
{
    public void TestMethod()
    {
        Console.WriteLine("Test method of myInterface1");
    }

    public void TestMethod2()
    {
        Console.WriteLine("TestMethod2 of MyInterface2");
    }

    public static void Main(string[] args)
    {
        MyClass mc = new MyClass();
        mc.TestMethod();
        mc.TestMethod2();
    }
}