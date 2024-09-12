// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using ImplementingAnInterface;

namespace DynamicArrays
{
    internal class DynamicArray
    {
        public static void Main()
        {
            // UnorderedIntDynamicArray uID = new UnorderedIntDynamicArray();
            // uID.Add(1);
            // uID.Add(2);
            // uID.Add(3);
            // uID.Add(4);
            // uID.Add(5);

            // Console.WriteLine(uID.ToString());

            //OrderedIntDynamicArray oID = new OrderedIntDynamicArray();
            // oID.Add(12);
            // oID.Add(34);
            // oID.Add(2);
            // oID.Add(423);
            // oID.Add(65);
            // oID.Add(29);

            // Console.WriteLine(oID.ToString());

            OrderedDynamicArray<Rectangle> rectangles = 
                new OrderedDynamicArray<Rectangle>();

                rectangles.Add(new Rectangle(3, 4));
                rectangles.Add(new Rectangle(2, 2));
                rectangles.Add(new Rectangle(1, 2));

                Console.WriteLine(rectangles.ToString());
        }
    }
}
