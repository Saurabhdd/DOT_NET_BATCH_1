using System;


class ConversionSamp
{
   	static void Main()
    {
        //Implicit conversion
        int num1 = 123;
        long num2 = num1;
        Console.WriteLine(num1.ToString());
        Console.WriteLine(num2.ToString());

        //explicit conversion
        long num1 = Int64.MaxValue;
        int num2 =(int)num1;
        Console.WriteLine(num1.ToString());
        Console.WriteLine(num2.ToString());


        //Boxing example
        int num1 = 123;
        Object obj = num1;

        Console.WriteLine(num1.ToString());
        Console.WriteLine(obj.ToString());

        //Unboxing example
        Object obj1 = 123;
        int num2 = (int)obj1;

        Console.WriteLine(num2.ToString());
        Console.WriteLine(obj1.ToString());

    }
}

