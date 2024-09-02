using System;

namespace Arrays
{
    internal class Array
    {
        int[] items;
        public const int MAX_LENGH = 10;
        int index;
        

        public Array()
        {
            items = new int[MAX_LENGH];
            index = 0;
        }

        public void Add(int data)
        {
            if(index >= MAX_LENGH)
                return;
            items[index++] = data;
        }

        public bool Remove(int data)
        {
            int itemIndex = IndexOf(data);
            if(itemIndex == -1)
                return false;
            items[itemIndex] = items[MAX_LENGH - 1];
            index--;
            return true;

        }

        public int IndexOf(int data)
        {
            for(int i = 0; i < MAX_LENGH; i++)
                if(items[i] == data)
                    return i;
            return -1;
        }

        public void Print()
        {
            for(int i = 0; i < index; i++)
                Console.Write("[" + items[i] + "]");
            Console.WriteLine("[END]");
        }

        
    }
}
