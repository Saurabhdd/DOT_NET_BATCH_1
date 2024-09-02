using System;

namespace Program
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Arrays.Array array = new Arrays.Array();

            for(int i = 0; i < Arrays.Array.MAX_LENGH; i++)
                array.Add(i);

            array.Print();
            array.Remove(5);
            array.Print();
            array.Add(10);
            array.Print();
        }
        
    }
}
