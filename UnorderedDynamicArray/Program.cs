using System;

namespace Program
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DynamicArrays.UnorderedIntDynamicArray unDArr = new DynamicArrays.UnorderedIntDynamicArray();
            const int numberOfDataEntry = 10;

            for(int i = 0; i < numberOfDataEntry; i++)
            {
                unDArr.Add((i + 1) * 2);
            }

            Console.WriteLine(unDArr.ToString());
        }
    }
}
